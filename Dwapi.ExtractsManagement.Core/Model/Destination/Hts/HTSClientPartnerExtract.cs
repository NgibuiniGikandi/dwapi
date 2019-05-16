﻿using System;

namespace Dwapi.ExtractsManagement.Core.Model.Destination.Hts
{
    public class HTSClientPartnerExtract : HTSExtract
    {
        public int? PartnerPatientPk { get; set; }
        public int? PartnerPersonId { get; set; }
        public string RelationshipToIndexClient { get; set; }
        public string ScreenedForIpv { get; set; }
        public string IpvScreeningOutcome { get; set; }
        public string CurrentlyLivingWithIndexClient { get; set; }
        public string KnowledgeOfHivStatus { get; set; }
        public string PnsApproach { get; set; }
        public string Trace1Outcome { get; set; }
        public string Trace1Type { get; set; }
        public DateTime? Trace1Date { get; set; }
        public string Trace2Outcome { get; set; }
        public string Trace2Type { get; set; }
        public DateTime? Trace2Date { get; set; }
        public string Trace3Outcome { get; set; }
        public string Trace3Type { get; set; }
        public DateTime? Trace3Date { get; set; }
        public string PnsConsent { get; set; }
        public string Linked { get; set; }
        public DateTime? LinkDateLinkedToCare { get; set; }
        public string CccNumber { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }
}
