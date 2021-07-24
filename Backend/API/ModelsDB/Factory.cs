using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class Factory
    {
        public Factory()
        {
            AppointmentsFactories = new HashSet<AppointmentsFactory>();
            EnquiryItems = new HashSet<EnquiryItem>();
            FactoriesContactPeople = new HashSet<FactoriesContactPerson>();
            FactoryCollaborationCollaborationFactories = new HashSet<FactoryCollaboration>();
            FactoryCollaborationFactories = new HashSet<FactoryCollaboration>();
            FactoryConnections = new HashSet<FactoryConnection>();
            FactoryFeatures = new HashSet<FactoryFeature>();
            MaterialFeatures = new HashSet<MaterialFeature>();
        }

        public int Id { get; set; }
        public string Abc { get; set; }
        public double? AccordFccInternalId { get; set; }
        public string Address { get; set; }
        public int? Agent2Id { get; set; }
        public int? AgentId { get; set; }
        public string AldiFacilityCode { get; set; }
        public DateTime? AppliedForNewBoilerLicenceOn { get; set; }
        public DateTime? AppliedForNewFireLicenceOn { get; set; }
        public DateTime? AppliedForNewGeneratorLicenceOn { get; set; }
        public string AuditCompanyOfLast3rdPartyAudit { get; set; }
        public string AuditNumberOfLastBsciAudit { get; set; }
        public string BepiLevel { get; set; }
        public DateTime? BoilerLicenceValidUntil { get; set; }
        public string BsciDatabaseId { get; set; }
        public string BsciResponsibleGp { get; set; }
        public string BsciStatus { get; set; }
        public string BsciStatus2 { get; set; }
        public bool? BuildingApprovalPlan { get; set; }
        public string CertificateIssuer { get; set; }
        public double? ChemicalsUsedCompliant { get; set; }
        public double? ChemicalsUsedTotal { get; set; }
        public string City { get; set; }
        public string CommentsAboutAccord { get; set; }
        public string ComplianceComments { get; set; }
        public string Country { get; set; }
        public DateTime? DateLastExtChemManAuditRep { get; set; }
        public DateTime? DateOfCapFinalizationForGpReAudit { get; set; }
        public DateTime? DateOfLastInternalGpAudit { get; set; }
        public DateTime? DateOfSelfAssessment { get; set; }
        public DateTime? DateOfTestReportDischargeData { get; set; }
        public bool? Deleted { get; set; }
        public string DetoxComments { get; set; }
        public bool? DetoxRelevantFactory { get; set; }
        public double? DetoxScoreByAldi { get; set; }
        public string Email { get; set; }
        public DateTime? EstimatedDateOfNext3rdPartyAudit { get; set; }
        public string Etp { get; set; }
        public double? ExtChemManagemAuditResultRep { get; set; }
        public string FactNeededByDepartm { get; set; }
        public string FactoryImage { get; set; }
        public DateTime? FireLicenceValidUntil { get; set; }
        public bool? FloorLayoutApprovalPlanFromFactoryInspector { get; set; }
        public string FurtherDescriptionOfProductPortfolio { get; set; }
        public string GeneralComments { get; set; }
        public string GeneralFactoryType { get; set; }
        public DateTime? GeneratorLicenceValidUntil { get; set; }
        public string HouseNumber { get; set; }
        public DateTime? InspectionDateAccordElectricalSafety { get; set; }
        public DateTime? InspectionDateAccordFireSafety { get; set; }
        public DateTime? InspectionDateStructuralSafety { get; set; }
        public double? IntChemManagemAuditResultRep { get; set; }
        public string InternalGpDetoxScore { get; set; }
        public string InternallyApproved { get; set; }
        public DateTime? IpeUploadOn { get; set; }
        public bool? IsBepiRegistered { get; set; }
        public int ItemId { get; set; }
        public DateTime? Last3rdPartyAudit { get; set; }
        public DateTime? Last3rdPartyBsciFullAudit { get; set; }
        public DateTime? LastOekoTexStePaudit { get; set; }
        public string LeadBrandAccord { get; set; }
        public string NameOfFireSafetyOfficer { get; set; }
        public string NameOfGpLeadAuditor { get; set; }
        public DateTime? Next3rdPartyAuditBookedOn { get; set; }
        public double? NumProdStaffLastCount { get; set; }
        public double? NumberOfEmployees { get; set; }
        public DateTime? OekoTexStePcertificateValidUntil { get; set; }
        public string OrdersPlacedInFactory { get; set; }
        public string OtherClientsOfFactory { get; set; }
        public string Penalties { get; set; }
        public string PhoneNumber { get; set; }
        public string ProdLevelAldiDetox { get; set; }
        public string Province { get; set; }
        public string RatingOfAccordStructuralInspection { get; set; }
        public DateTime? ReceivingDateAccordFireSafetyReport { get; set; }
        public DateTime? ReceivingDateAccordStructuralSafetyReport { get; set; }
        public DateTime? ReceivingDateElectricalSafetyReport { get; set; }
        public bool? RegisteredAtIpe { get; set; }
        public string ResultOfLastInternalGpAudit { get; set; }
        public string Sa8000CertificateNumber { get; set; }
        public string SedexReferenceNumber { get; set; }
        public string SubcontractingRisk { get; set; }
        public string Title { get; set; }
        public DateTime? ValidityOfCertificateOrLastAudit { get; set; }
        public string WovenOrKnitFactory { get; set; }
        public string ZipCode { get; set; }
        public string InternallyApprovedDryProcesses { get; set; }
        public string InternallyApprovedForWetProcess { get; set; }
        public string InternallyApprovedSpinning { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string AvarageCapacity { get; set; }
        public string CapacityGroupId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Agent Agent2 { get; set; }
        public virtual ICollection<AppointmentsFactory> AppointmentsFactories { get; set; }
        public virtual ICollection<EnquiryItem> EnquiryItems { get; set; }
        public virtual ICollection<FactoriesContactPerson> FactoriesContactPeople { get; set; }
        public virtual ICollection<FactoryCollaboration> FactoryCollaborationCollaborationFactories { get; set; }
        public virtual ICollection<FactoryCollaboration> FactoryCollaborationFactories { get; set; }
        public virtual ICollection<FactoryConnection> FactoryConnections { get; set; }
        public virtual ICollection<FactoryFeature> FactoryFeatures { get; set; }
        public virtual ICollection<MaterialFeature> MaterialFeatures { get; set; }
    }
}
