﻿// <auto-generated />
using Dwapi.ExtractsManagement.Infrastructure;
using Dwapi.SharedKernel.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Dwapi.ExtractsManagement.Infrastructure.Migrations
{
    [DbContext(typeof(ExtractsContext))]
    [Migration("20180411061512_DwhExtracts")]
    partial class DwhExtracts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dwapi.Domain.ClientPatientArtExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("AgeARTStart");

                    b.Property<decimal?>("AgeEnrollment");

                    b.Property<decimal?>("AgeLastVisit");

                    b.Property<Guid?>("ClientPatientExtractId");

                    b.Property<DateTime?>("DOB");

                    b.Property<decimal?>("Duration");

                    b.Property<string>("Emr");

                    b.Property<DateTime?>("ExitDate");

                    b.Property<string>("ExitReason");

                    b.Property<DateTime?>("ExpectedReturn");

                    b.Property<string>("Gender");

                    b.Property<DateTime?>("LastARTDate");

                    b.Property<string>("LastRegimen");

                    b.Property<string>("LastRegimenLine");

                    b.Property<DateTime?>("LastVisit");

                    b.Property<string>("PatientID");

                    b.Property<int>("PatientPK");

                    b.Property<string>("PatientSource");

                    b.Property<string>("PreviousARTRegimen");

                    b.Property<DateTime?>("PreviousARTStartDate");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("Provider");

                    b.Property<string>("QueueId");

                    b.Property<DateTime?>("RegistrationDate");

                    b.Property<int>("SiteCode");

                    b.Property<DateTime?>("StartARTAtThisFacility");

                    b.Property<DateTime?>("StartARTDate");

                    b.Property<string>("StartRegimen");

                    b.Property<string>("StartRegimenLine");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.HasKey("Id");

                    b.HasIndex("ClientPatientExtractId");

                    b.ToTable("PatientArtExtract");
                });

            modelBuilder.Entity("Dwapi.Domain.ClientPatientBaselinesExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClientPatientExtractId");

                    b.Property<string>("Emr");

                    b.Property<string>("PatientID");

                    b.Property<int>("PatientPK");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("QueueId");

                    b.Property<int>("SiteCode");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<int?>("bCD4");

                    b.Property<DateTime?>("bCD4Date");

                    b.Property<int?>("bWAB");

                    b.Property<DateTime?>("bWABDate");

                    b.Property<int?>("bWHO");

                    b.Property<DateTime?>("bWHODate");

                    b.Property<int?>("eCD4");

                    b.Property<DateTime?>("eCD4Date");

                    b.Property<int?>("eWAB");

                    b.Property<DateTime?>("eWABDate");

                    b.Property<int?>("eWHO");

                    b.Property<DateTime?>("eWHODate");

                    b.Property<int?>("lastCD4");

                    b.Property<DateTime?>("lastCD4Date");

                    b.Property<int?>("lastWAB");

                    b.Property<DateTime?>("lastWABDate");

                    b.Property<int?>("lastWHO");

                    b.Property<DateTime?>("lastWHODate");

                    b.Property<int?>("m12CD4");

                    b.Property<DateTime?>("m12CD4Date");

                    b.Property<int?>("m6CD4");

                    b.Property<DateTime?>("m6CD4Date");

                    b.HasKey("Id");

                    b.HasIndex("ClientPatientExtractId");

                    b.ToTable("PatientBaselinesExtract");
                });

            modelBuilder.Entity("Dwapi.Domain.ClientPatientExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContactRelation");

                    b.Property<DateTime?>("DOB");

                    b.Property<DateTime?>("DateConfirmedHIVPositive");

                    b.Property<DateTime?>("DateLastVisit");

                    b.Property<DateTime?>("DatePreviousARTStart");

                    b.Property<DateTime?>("DateRegistered");

                    b.Property<DateTime?>("DateRegistrationAtCCC");

                    b.Property<DateTime?>("DateRegistrationAtPMTCT");

                    b.Property<DateTime?>("DateRegistrationAtTBClinic");

                    b.Property<string>("District");

                    b.Property<string>("EducationLevel");

                    b.Property<string>("Emr");

                    b.Property<string>("FacilityName");

                    b.Property<string>("Gender");

                    b.Property<string>("MaritalStatus");

                    b.Property<string>("PatientID");

                    b.Property<int>("PatientPK");

                    b.Property<string>("PatientSource");

                    b.Property<string>("PreviousARTExposure");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("QueueId");

                    b.Property<string>("Region");

                    b.Property<int>("SiteCode");

                    b.Property<string>("Status");

                    b.Property<string>("StatusAtCCC");

                    b.Property<string>("StatusAtPMTCT");

                    b.Property<string>("StatusAtTBClinic");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<string>("Village");

                    b.HasKey("Id");

                    b.ToTable("PatientExtract");
                });

            modelBuilder.Entity("Dwapi.Domain.ClientPatientLaboratoryExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClientPatientExtractId");

                    b.Property<string>("Emr");

                    b.Property<int?>("EnrollmentTest");

                    b.Property<DateTime?>("OrderedByDate");

                    b.Property<string>("PatientID");

                    b.Property<int>("PatientPK");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("QueueId");

                    b.Property<DateTime?>("ReportedByDate");

                    b.Property<int>("SiteCode");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<string>("TestName");

                    b.Property<string>("TestResult");

                    b.Property<int?>("VisitId");

                    b.HasKey("Id");

                    b.HasIndex("ClientPatientExtractId");

                    b.ToTable("PatientLaboratoryExtract");
                });

            modelBuilder.Entity("Dwapi.Domain.ClientPatientPharmacyExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClientPatientExtractId");

                    b.Property<DateTime?>("DispenseDate");

                    b.Property<string>("Drug");

                    b.Property<decimal?>("Duration");

                    b.Property<string>("Emr");

                    b.Property<DateTime?>("ExpectedReturn");

                    b.Property<string>("PatientID");

                    b.Property<int>("PatientPK");

                    b.Property<string>("PeriodTaken");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("ProphylaxisType");

                    b.Property<string>("Provider");

                    b.Property<string>("QueueId");

                    b.Property<string>("RegimenLine");

                    b.Property<int>("SiteCode");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<string>("TreatmentType");

                    b.Property<int?>("VisitID");

                    b.HasKey("Id");

                    b.HasIndex("ClientPatientExtractId");

                    b.ToTable("PatientPharmacyExtract");
                });

            modelBuilder.Entity("Dwapi.Domain.ClientPatientStatusExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClientPatientExtractId");

                    b.Property<string>("Emr");

                    b.Property<DateTime?>("ExitDate");

                    b.Property<string>("ExitDescription");

                    b.Property<string>("ExitReason");

                    b.Property<string>("PatientID");

                    b.Property<int>("PatientPK");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("QueueId");

                    b.Property<int>("SiteCode");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.HasKey("Id");

                    b.HasIndex("ClientPatientExtractId");

                    b.ToTable("PatientStatusExtract");
                });

            modelBuilder.Entity("Dwapi.Domain.ClientPatientVisitExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adherence");

                    b.Property<string>("AdherenceCategory");

                    b.Property<string>("BP");

                    b.Property<Guid?>("ClientPatientExtractId");

                    b.Property<DateTime?>("EDD");

                    b.Property<string>("Emr");

                    b.Property<string>("FamilyPlanningMethod");

                    b.Property<decimal?>("GestationAge");

                    b.Property<decimal?>("Height");

                    b.Property<DateTime?>("LMP");

                    b.Property<DateTime?>("NextAppointmentDate");

                    b.Property<string>("OI");

                    b.Property<DateTime?>("OIDate");

                    b.Property<string>("PatientID");

                    b.Property<int>("PatientPK");

                    b.Property<string>("Pregnant");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("PwP");

                    b.Property<string>("QueueId");

                    b.Property<DateTime?>("SecondlineRegimenChangeDate");

                    b.Property<string>("SecondlineRegimenChangeReason");

                    b.Property<string>("Service");

                    b.Property<int>("SiteCode");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<DateTime?>("SubstitutionFirstlineRegimenDate");

                    b.Property<string>("SubstitutionFirstlineRegimenReason");

                    b.Property<DateTime?>("SubstitutionSecondlineRegimenDate");

                    b.Property<string>("SubstitutionSecondlineRegimenReason");

                    b.Property<DateTime?>("VisitDate");

                    b.Property<int?>("VisitId");

                    b.Property<string>("VisitType");

                    b.Property<string>("WABStage");

                    b.Property<int?>("WHOStage");

                    b.Property<decimal?>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("ClientPatientExtractId");

                    b.ToTable("PatientVisitExtract");
                });

            modelBuilder.Entity("Dwapi.Domain.EMR", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConnectionKey");

                    b.Property<bool>("IsDefault");

                    b.Property<string>("Name");

                    b.Property<Guid>("ProjectId");

                    b.Property<string>("Version");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("EMR");
                });

            modelBuilder.Entity("Dwapi.Domain.EventHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Display");

                    b.Property<Guid>("ExtractSettingId");

                    b.Property<int?>("Found");

                    b.Property<DateTime?>("FoundDate");

                    b.Property<string>("FoundStatus");

                    b.Property<DateTime?>("ImportDate");

                    b.Property<string>("ImportStatus");

                    b.Property<int?>("Imported");

                    b.Property<bool?>("IsFoundSuccess");

                    b.Property<bool?>("IsImportSuccess");

                    b.Property<bool?>("IsLoadSuccess");

                    b.Property<bool?>("IsSendSuccess");

                    b.Property<DateTime?>("LoadDate");

                    b.Property<string>("LoadStatus");

                    b.Property<int?>("Loaded");

                    b.Property<int?>("NotImported");

                    b.Property<int?>("NotSent");

                    b.Property<int?>("Rejected");

                    b.Property<DateTime?>("SendDate");

                    b.Property<string>("SendStatus");

                    b.Property<int?>("Sent");

                    b.Property<int?>("SiteCode");

                    b.HasKey("Id");

                    b.HasIndex("ExtractSettingId");

                    b.ToTable("EventHistory");
                });

            modelBuilder.Entity("Dwapi.Domain.ExtractSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Destination");

                    b.Property<string>("Display");

                    b.Property<Guid>("EmrId");

                    b.Property<string>("ExtractCsv");

                    b.Property<string>("ExtractSql")
                        .HasMaxLength(8000);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsPriority");

                    b.Property<string>("Name");

                    b.Property<decimal>("Rank");

                    b.HasKey("Id");

                    b.HasIndex("EmrId");

                    b.ToTable("ExtractSettings");
                });

            modelBuilder.Entity("Dwapi.Domain.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Dwapi.Domain.TempPatientArtExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("AgeARTStart");

                    b.Property<decimal?>("AgeEnrollment");

                    b.Property<decimal?>("AgeLastVisit");

                    b.Property<bool>("CheckError");

                    b.Property<DateTime?>("DOB");

                    b.Property<DateTime>("DateExtracted");

                    b.Property<decimal?>("Duration");

                    b.Property<string>("Emr");

                    b.Property<DateTime?>("ExitDate");

                    b.Property<string>("ExitReason");

                    b.Property<DateTime?>("ExpectedReturn");

                    b.Property<int?>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<string>("Gender");

                    b.Property<DateTime?>("LastARTDate");

                    b.Property<string>("LastRegimen");

                    b.Property<string>("LastRegimenLine");

                    b.Property<DateTime?>("LastVisit");

                    b.Property<string>("PatientID");

                    b.Property<int?>("PatientPK");

                    b.Property<string>("PatientSource");

                    b.Property<string>("PreviousARTRegimen");

                    b.Property<DateTime?>("PreviousARTStartDate");

                    b.Property<string>("Project");

                    b.Property<string>("Provider");

                    b.Property<DateTime?>("RegistrationDate");

                    b.Property<int?>("SiteCode");

                    b.Property<DateTime?>("StartARTAtThisFacility");

                    b.Property<DateTime?>("StartARTDate");

                    b.Property<string>("StartRegimen");

                    b.Property<string>("StartRegimenLine");

                    b.HasKey("Id");

                    b.ToTable("TempPatientArtExtracts");
                });

            modelBuilder.Entity("Dwapi.Domain.TempPatientBaselinesExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CheckError");

                    b.Property<DateTime>("DateExtracted");

                    b.Property<string>("Emr");

                    b.Property<int?>("FacilityId");

                    b.Property<string>("PatientID");

                    b.Property<int?>("PatientPK");

                    b.Property<string>("Project");

                    b.Property<int?>("SiteCode");

                    b.Property<int?>("bCD4");

                    b.Property<DateTime?>("bCD4Date");

                    b.Property<int?>("bWAB");

                    b.Property<DateTime?>("bWABDate");

                    b.Property<int?>("bWHO");

                    b.Property<DateTime?>("bWHODate");

                    b.Property<int?>("eCD4");

                    b.Property<DateTime?>("eCD4Date");

                    b.Property<int?>("eWAB");

                    b.Property<DateTime?>("eWABDate");

                    b.Property<int?>("eWHO");

                    b.Property<DateTime?>("eWHODate");

                    b.Property<int?>("lastCD4");

                    b.Property<DateTime?>("lastCD4Date");

                    b.Property<int?>("lastWAB");

                    b.Property<DateTime?>("lastWABDate");

                    b.Property<int?>("lastWHO");

                    b.Property<DateTime?>("lastWHODate");

                    b.Property<int?>("m12CD4");

                    b.Property<DateTime?>("m12CD4Date");

                    b.Property<int?>("m6CD4");

                    b.Property<DateTime?>("m6CD4Date");

                    b.HasKey("Id");

                    b.ToTable("TempPatientBaselinesExtracts");
                });

            modelBuilder.Entity("Dwapi.Domain.TempPatientExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CheckError");

                    b.Property<string>("ContactRelation");

                    b.Property<DateTime?>("DOB");

                    b.Property<DateTime?>("DateConfirmedHIVPositive");

                    b.Property<DateTime>("DateExtracted");

                    b.Property<DateTime?>("DateLastVisit");

                    b.Property<DateTime?>("DatePreviousARTStart");

                    b.Property<DateTime?>("DateRegistered");

                    b.Property<DateTime?>("DateRegistrationAtCCC");

                    b.Property<DateTime?>("DateRegistrationAtPMTCT");

                    b.Property<DateTime?>("DateRegistrationAtTBClinic");

                    b.Property<string>("District");

                    b.Property<string>("EducationLevel");

                    b.Property<string>("Emr");

                    b.Property<int?>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<string>("Gender");

                    b.Property<string>("MaritalStatus");

                    b.Property<string>("PatientID");

                    b.Property<int?>("PatientPK");

                    b.Property<string>("PatientSource");

                    b.Property<string>("PreviousARTExposure");

                    b.Property<string>("Project");

                    b.Property<string>("Region");

                    b.Property<int?>("SiteCode");

                    b.Property<string>("StatusAtCCC");

                    b.Property<string>("StatusAtPMTCT");

                    b.Property<string>("StatusAtTBClinic");

                    b.Property<string>("Village");

                    b.HasKey("Id");

                    b.ToTable("TempPatientExtracts");
                });

            modelBuilder.Entity("Dwapi.Domain.TempPatientLaboratoryExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CheckError");

                    b.Property<DateTime>("DateExtracted");

                    b.Property<string>("Emr");

                    b.Property<int?>("EnrollmentTest");

                    b.Property<int?>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<DateTime?>("OrderedByDate");

                    b.Property<string>("PatientID");

                    b.Property<int?>("PatientPK");

                    b.Property<string>("Project");

                    b.Property<DateTime?>("ReportedByDate");

                    b.Property<string>("SatelliteName");

                    b.Property<int?>("SiteCode");

                    b.Property<string>("TestName");

                    b.Property<string>("TestResult");

                    b.Property<int?>("VisitId");

                    b.HasKey("Id");

                    b.ToTable("TempPatientLaboratoryExtracts");
                });

            modelBuilder.Entity("Dwapi.Domain.TempPatientPharmacyExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CheckError");

                    b.Property<DateTime>("DateExtracted");

                    b.Property<DateTime?>("DispenseDate");

                    b.Property<string>("Drug");

                    b.Property<decimal?>("Duration");

                    b.Property<string>("Emr");

                    b.Property<DateTime?>("ExpectedReturn");

                    b.Property<int?>("FacilityId");

                    b.Property<string>("PatientID");

                    b.Property<int?>("PatientPK");

                    b.Property<string>("PeriodTaken");

                    b.Property<string>("Project");

                    b.Property<string>("ProphylaxisType");

                    b.Property<string>("Provider");

                    b.Property<string>("RegimenLine");

                    b.Property<int?>("SiteCode");

                    b.Property<string>("TreatmentType");

                    b.Property<int?>("VisitID");

                    b.HasKey("Id");

                    b.ToTable("TempPatientPharmacyExtracts");
                });

            modelBuilder.Entity("Dwapi.Domain.TempPatientStatusExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CheckError");

                    b.Property<DateTime>("DateExtracted");

                    b.Property<string>("Emr");

                    b.Property<DateTime?>("ExitDate");

                    b.Property<string>("ExitDescription");

                    b.Property<string>("ExitReason");

                    b.Property<int?>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<string>("PatientID");

                    b.Property<int?>("PatientPK");

                    b.Property<string>("Project");

                    b.Property<int?>("SiteCode");

                    b.HasKey("Id");

                    b.ToTable("TempPatientStatusExtracts");
                });

            modelBuilder.Entity("Dwapi.Domain.TempPatientVisitExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adherence");

                    b.Property<string>("AdherenceCategory");

                    b.Property<string>("BP");

                    b.Property<bool>("CheckError");

                    b.Property<DateTime>("DateExtracted");

                    b.Property<DateTime?>("EDD");

                    b.Property<string>("Emr");

                    b.Property<int?>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<string>("FamilyPlanningMethod");

                    b.Property<decimal?>("GestationAge");

                    b.Property<decimal?>("Height");

                    b.Property<DateTime?>("LMP");

                    b.Property<DateTime?>("NextAppointmentDate");

                    b.Property<string>("OI");

                    b.Property<DateTime?>("OIDate");

                    b.Property<string>("PatientID");

                    b.Property<int?>("PatientPK");

                    b.Property<string>("Pregnant");

                    b.Property<string>("Project");

                    b.Property<string>("PwP");

                    b.Property<DateTime?>("SecondlineRegimenChangeDate");

                    b.Property<string>("SecondlineRegimenChangeReason");

                    b.Property<string>("Service");

                    b.Property<int?>("SiteCode");

                    b.Property<DateTime?>("SubstitutionFirstlineRegimenDate");

                    b.Property<string>("SubstitutionFirstlineRegimenReason");

                    b.Property<DateTime?>("SubstitutionSecondlineRegimenDate");

                    b.Property<string>("SubstitutionSecondlineRegimenReason");

                    b.Property<DateTime?>("VisitDate");

                    b.Property<int?>("VisitId");

                    b.Property<string>("VisitType");

                    b.Property<string>("WABStage");

                    b.Property<int?>("WHOStage");

                    b.Property<decimal?>("Weight");

                    b.HasKey("Id");

                    b.ToTable("TempPatientVisitExtracts");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.Extract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Display")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Extracts");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.ExtractHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ExtractId");

                    b.Property<int?>("Stats");

                    b.Property<int>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<string>("StatusInfo");

                    b.HasKey("Id");

                    b.HasIndex("ExtractId");

                    b.ToTable("ExtractHistories");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.PsmartStage", b =>
                {
                    b.Property<Guid>("EId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateExtracted");

                    b.Property<DateTime?>("DateSent");

                    b.Property<DateTime>("DateStaged");

                    b.Property<DateTime?>("Date_Created");

                    b.Property<string>("Emr");

                    b.Property<int?>("Id");

                    b.Property<string>("RequestId");

                    b.Property<string>("Shr");

                    b.Property<string>("Status")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("Status_Date");

                    b.Property<string>("Uuid");

                    b.HasKey("EId");

                    b.ToTable("PsmartStages");
                });

            modelBuilder.Entity("Dwapi.Domain.ClientPatientArtExtract", b =>
                {
                    b.HasOne("Dwapi.Domain.ClientPatientExtract")
                        .WithMany("ClientPatientArtExtracts")
                        .HasForeignKey("ClientPatientExtractId");
                });

            modelBuilder.Entity("Dwapi.Domain.ClientPatientBaselinesExtract", b =>
                {
                    b.HasOne("Dwapi.Domain.ClientPatientExtract")
                        .WithMany("ClientPatientBaselinesExtracts")
                        .HasForeignKey("ClientPatientExtractId");
                });

            modelBuilder.Entity("Dwapi.Domain.ClientPatientLaboratoryExtract", b =>
                {
                    b.HasOne("Dwapi.Domain.ClientPatientExtract")
                        .WithMany("ClientPatientLaboratoryExtracts")
                        .HasForeignKey("ClientPatientExtractId");
                });

            modelBuilder.Entity("Dwapi.Domain.ClientPatientPharmacyExtract", b =>
                {
                    b.HasOne("Dwapi.Domain.ClientPatientExtract")
                        .WithMany("ClientPatientPharmacyExtracts")
                        .HasForeignKey("ClientPatientExtractId");
                });

            modelBuilder.Entity("Dwapi.Domain.ClientPatientStatusExtract", b =>
                {
                    b.HasOne("Dwapi.Domain.ClientPatientExtract")
                        .WithMany("ClientPatientStatusExtracts")
                        .HasForeignKey("ClientPatientExtractId");
                });

            modelBuilder.Entity("Dwapi.Domain.ClientPatientVisitExtract", b =>
                {
                    b.HasOne("Dwapi.Domain.ClientPatientExtract")
                        .WithMany("ClientPatientVisitExtracts")
                        .HasForeignKey("ClientPatientExtractId");
                });

            modelBuilder.Entity("Dwapi.Domain.EMR", b =>
                {
                    b.HasOne("Dwapi.Domain.Project")
                        .WithMany("Emrs")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwapi.Domain.EventHistory", b =>
                {
                    b.HasOne("Dwapi.Domain.ExtractSetting")
                        .WithMany("Events")
                        .HasForeignKey("ExtractSettingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwapi.Domain.ExtractSetting", b =>
                {
                    b.HasOne("Dwapi.Domain.EMR")
                        .WithMany("ExtractSettings")
                        .HasForeignKey("EmrId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.ExtractHistory", b =>
                {
                    b.HasOne("Dwapi.ExtractsManagement.Core.Model.Extract")
                        .WithMany("ExtractHistories")
                        .HasForeignKey("ExtractId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
