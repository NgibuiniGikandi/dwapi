﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dwapi.Domain
{
    public class TempPatientExtract
    {
        [Key]
        //[DoNotRead]
        public Guid Id { get; set; }
        public int? PatientPK { get; set; }
        public string PatientID { get; set; }
        public int? FacilityId { get; set; }
        public int? SiteCode { get; set; }

        //[DoNotRead]
        public DateTime DateExtracted { get; set; }
        //[DoNotRead]
        public bool CheckError { get; set; }

        //[DoNotRead]
        [NotMapped]
        public bool HasError { get; set; }

        public string Emr { get; set; }
        public string Project { get; set; }
        public string FacilityName { get; set; }
        public string Gender { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? RegistrationAtCCC { get; set; }
        public DateTime? RegistrationAtPMTCT { get; set; }
        public DateTime? RegistrationAtTBClinic { get; set; }
        public string PatientSource { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string Village { get; set; }
        public string ContactRelation { get; set; }
        public DateTime? LastVisit { get; set; }
        public string MaritalStatus { get; set; }
        public string EducationLevel { get; set; }
        public DateTime? DateConfirmedHIVPositive { get; set; }
        public string PreviousARTExposure { get; set; }
        public DateTime? DatePreviousARTStart { get; set; }
        public string StatusAtCCC { get; set; }
        public string StatusAtPMTCT { get; set; }
        public string StatusAtTBClinic { get; set; }

    }
}