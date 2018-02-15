﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AutoMapper;
using Dwapi.ExtractsManagement.Core.Interfaces.Repository;
using Dwapi.ExtractsManagement.Core.Interfaces.Services.Psmart;
using Dwapi.ExtractsManagement.Core.Interfaces.Stage.Psmart.Repository;
using Dwapi.ExtractsManagement.Core.Interfaces.Stage.Source.Psmart.Reader;
using Dwapi.ExtractsManagement.Core.Model;
using Dwapi.ExtractsManagement.Core.Model.Source.Psmart;
using Dwapi.ExtractsManagement.Core.Model.Stage.Psmart;
using Dwapi.SharedKernel.DTOs;
using Dwapi.SharedKernel.Enum;
using Dwapi.SharedKernel.Model;

namespace Dwapi.ExtractsManagement.Core.Services.Psmart
{
    public class PsmartExtractService:IPsmartExtractService
    {
        private readonly IPsmartSourceReader _psmartSourceReader;
        private readonly IPsmartStageRepository _psmartStageRepository;
        private readonly IMapper _mapper;
        private string _emr;
        private List<string> errorList=new List<string>();

        private IExtractHistoryRepository _extractHistoryRepository;

        public PsmartExtractService(IPsmartSourceReader psmartSourceReader, IPsmartStageRepository psmartStageRepository, IExtractHistoryRepository extractHistoryRepository)
        {
            _psmartSourceReader = psmartSourceReader;
            _psmartStageRepository = psmartStageRepository;
            _extractHistoryRepository = extractHistoryRepository;

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMissingTypeMaps = false;
                cfg.AllowNullCollections = true;
                cfg.CreateMap<PsmartSource, PsmartStage>();
            });

            _mapper = new Mapper(config);
        }

        public ExtractHistory HasStarted(Guid extractId)
        {
            var history = _extractHistoryRepository.GetLatest(extractId);

            if (null == history)
            {
                _extractHistoryRepository.UpdateStatus(extractId,ExtractStatus.Idle);
                return _extractHistoryRepository.GetLatest(extractId);
            }

            return history;
        }

        public void Find(IEnumerable<DbExtractProtocolDTO> extracts)
        {
            foreach (var dbExtractProtocolDTO in extracts)
            {
                var extract = dbExtractProtocolDTO.Extract;
                var protocol = dbExtractProtocolDTO.DatabaseProtocol;

                _extractHistoryRepository.ClearHistory(extract.Id);

                _extractHistoryRepository.UpdateStatus(extract.Id, ExtractStatus.Idle);
                _extractHistoryRepository.UpdateStatus(extract.Id, ExtractStatus.Finding);

                var found = _psmartSourceReader.Find(protocol, extract);

                _extractHistoryRepository.UpdateStatus(extract.Id, ExtractStatus.Found, found);
            }
          
        }

        public IEnumerable<PsmartSource> Extract(DbProtocol protocol, DbExtract extract)
        {
            _emr = extract.Emr;
            return _psmartSourceReader.Read(protocol, extract);
        }

        public int Load(IEnumerable<PsmartSource> sources, bool clearFirst = true)
        {
            if (clearFirst)
                _psmartStageRepository.Clear(_emr);

            var stages = _mapper.Map<IEnumerable<PsmartSource>, IEnumerable<PsmartStage>>(sources);
            _psmartStageRepository.Load(stages);

            _psmartStageRepository.SaveChanges();

            return _psmartStageRepository.Count(_emr);
        }

        public void Sync(IEnumerable<DbExtractProtocolDTO> extracts)
        {
            foreach (var extract in extracts)
            {
                try
                {
                    _extractHistoryRepository.UpdateStatus(extract.Extract.Id, ExtractStatus.Loading);

                   var count= Load(Extract(extract.DatabaseProtocol, extract.Extract));

                    _extractHistoryRepository.UpdateStatus(extract.Extract.Id, ExtractStatus.Loaded,count);
                    //_extractHistoryRepository.UpdateStatus(extract.Extract.Id, ExtractStatus.Idle);
                }
                catch (Exception e)
                {
                   errorList.Add(e.Message);
                    throw;
                }
               
            }
        }

        public string GetLoadError()
        {
            if (errorList.Any())
                return errorList.First();
            return string.Empty;
        }
    }
}