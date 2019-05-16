﻿using System;
using System.Collections.Generic;
using Dwapi.SharedKernel.Model;
using Dwapi.SharedKernel.Utility;

namespace Dwapi.SharedKernel.DTOs
{
    public class SendManifestPackageDTO
    {
        public Registry Destination { get; set; }
        public Guid ExtractId { get; set; }
        public string ExtractName { get; set; }
        public string Endpoint { get; private set; }

        public SendManifestPackageDTO()
        {
        }

        public SendManifestPackageDTO(Registry destination)
        {
            Destination = destination;
        }

        public bool IsValid()
        {
            return null != Destination && !string.IsNullOrWhiteSpace(Destination.Url);
        }

        public string GetUrl(string endPoint = "")
        {
            Endpoint = string.IsNullOrWhiteSpace(endPoint) ? string.Empty : endPoint.HasToStartWith("/");
            var url = $"{Destination.Url}{Endpoint}";
            return url;
        }
    }
}
