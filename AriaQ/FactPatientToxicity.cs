//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AriaQ
{
    using System;
    using System.Collections.Generic;
    
    public partial class FactPatientToxicity
    {
        public long FactPatientToxicityID { get; set; }
        public Nullable<long> DimPatientID { get; set; }
        public Nullable<long> DimToxicityGradingCriteriaID { get; set; }
        public Nullable<long> DimLookupID_Scheme { get; set; }
        public Nullable<long> DimLookupID_ToxicityCauseCertaintyType { get; set; }
        public Nullable<long> DimLookupID_ToxicityCauseType { get; set; }
        public Nullable<long> DimDiagnosisCodeID { get; set; }
        public Nullable<long> DimDateID_AssessmentDateTime { get; set; }
        public Nullable<System.DateTime> AssessmentDateTime { get; set; }
        public Nullable<int> ToxicityGradeAuthour { get; set; }
        public Nullable<System.DateTime> ToxicityEffectiveDate { get; set; }
        public string ToxicityAssessmentType { get; set; }
        public string ToxicityComponentName { get; set; }
        public string ToxicitySubcomponentName { get; set; }
        public string ToxicitySubComponentGradeName { get; set; }
        public Nullable<int> ToxicityGrade { get; set; }
        public string AdverseEventsIndicator { get; set; }
        public string ValidEntryIndicator { get; set; }
        public Nullable<int> PatientToxicityAssessmentId { get; set; }
        public Nullable<int> PatientVisitId { get; set; }
        public Nullable<int> PatientToxicityAssessmentHeaderId { get; set; }
        public Nullable<int> LogID { get; set; }
        public Nullable<int> GradePerAssessmentType { get; set; }
        public Nullable<int> AssessmentType { get; set; }
        public string ToxicityReason { get; set; }
        public string ToxicityApprovedIndicator { get; set; }
        public Nullable<long> DimDateID_AssessmentPerformedDateTime { get; set; }
        public Nullable<long> DimDateID_ToxicityApprovedDateTime { get; set; }
        public string ToxicityReviewRequestIndicator { get; set; }
        public string ToxicityReviewedIndicator { get; set; }
        public Nullable<long> DimResourceID_Reviewer { get; set; }
        public Nullable<long> DimDateID_ToxicityReviewedDateTime { get; set; }
        public string ToxicityHeaderValidEntryIndicator { get; set; }
        public Nullable<int> RevisionNumber { get; set; }
        public Nullable<long> DimActivityTransactionID { get; set; }
        public Nullable<long> DimDateID_AssessmentStartDateTime { get; set; }
        public string CorrectedEntryIndicator { get; set; }
        public Nullable<long> DimDateID_AssessmentEndDateTime { get; set; }
        public string AssessmentTypeDesc { get; set; }
        public Nullable<System.DateTime> ToxicityApprovedDateTime { get; set; }
        public Nullable<System.DateTime> AssessmentPerformedDateTime { get; set; }
        public Nullable<System.DateTime> ToxicityReviewedDateTime { get; set; }
        public Nullable<System.DateTime> AssessmentStartDateTime { get; set; }
        public Nullable<System.DateTime> AssessmentEndDateTime { get; set; }
    
        public virtual DimActivityTransaction DimActivityTransaction { get; set; }
        public virtual DimDate DimDate { get; set; }
        public virtual DimDate DimDate1 { get; set; }
        public virtual DimDate DimDate2 { get; set; }
        public virtual DimDate DimDate3 { get; set; }
        public virtual DimDate DimDate4 { get; set; }
        public virtual DimDate DimDate5 { get; set; }
        public virtual DimDiagnosisCode DimDiagnosisCode { get; set; }
        public virtual DimLookup DimLookup { get; set; }
        public virtual DimLookup DimLookup1 { get; set; }
        public virtual DimLookup DimLookup2 { get; set; }
        public virtual DimPatient DimPatient { get; set; }
        public virtual DimResource DimResource { get; set; }
        public virtual DimToxicityGradingCriteria DimToxicityGradingCriteria { get; set; }
    }
}
