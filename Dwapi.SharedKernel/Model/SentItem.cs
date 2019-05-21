﻿using System;
using Dwapi.SharedKernel.Enum;

namespace Dwapi.SharedKernel.Model
{
    public class SentItem
    {
        public Guid Id { get; set; }
        public SendStatus Status { get; set; }
        public string StatusInfo { get; set; }
        public DateTime StatusDate { get; set; }=DateTime.Now;
        public string Extract { get; set; }

        public SentItem(Guid id, SendStatus status)
        {
            Id = id;
            Status = status;
        }
        public SentItem(Guid id, SendStatus status, string statusInfo,string extract=""):this(id,status)
        {
            Extract = extract;
            StatusInfo = statusInfo;
        }
    }
}
