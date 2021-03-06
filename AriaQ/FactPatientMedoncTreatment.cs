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
    
    public partial class FactPatientMedoncTreatment
    {
        public long FactPatientMedoncTreatmentID { get; set; }
        public Nullable<long> DimPatientID { get; set; }
        public Nullable<long> DimMedoncPlanID { get; set; }
        public Nullable<long> DimMedoncPlanPhaseID { get; set; }
        public Nullable<long> DimDateID_TreatmentPlanInit { get; set; }
        public Nullable<long> DimDateID_TreatmentPlanEnd { get; set; }
        public Nullable<long> DimDateID_TreatmentStartDate { get; set; }
        public Nullable<long> DimDateID_TreatmentEndDate { get; set; }
        public Nullable<long> DimHospitalDepartmentID { get; set; }
        public Nullable<System.DateTime> TreatmentPlanInitDate { get; set; }
        public Nullable<System.DateTime> TreatmentPlanInitTime { get; set; }
        public Nullable<System.DateTime> TreatmentPlanEndDate { get; set; }
        public Nullable<System.DateTime> TreatmentStartDate { get; set; }
        public Nullable<System.DateTime> TreatmentEndDate { get; set; }
        public Nullable<long> DimUserID_Provider { get; set; }
        public string ClinicalTrialTreatmentIndicator { get; set; }
        public string ClinicalTrialFlag { get; set; }
        public Nullable<int> NumberOfCycles { get; set; }
        public Nullable<int> NoOfCyclesCompleted { get; set; }
        public Nullable<int> CycleLength { get; set; }
        public Nullable<int> StartCycle { get; set; }
        public Nullable<int> StartDay { get; set; }
        public Nullable<int> TreatmentLine { get; set; }
        public string TreatmentIntent { get; set; }
        public string TreatmentUse { get; set; }
        public string TreatmentComments { get; set; }
        public Nullable<int> TreatmentModality { get; set; }
        public string TreatmentDescription { get; set; }
        public string DiseaseSite { get; set; }
        public Nullable<int> ctrpt_tx_id { get; set; }
        public Nullable<System.DateTime> PtTxLastModifiedDate { get; set; }
        public string PtTxLastModifiedByUser { get; set; }
        public Nullable<System.DateTime> PtTpLastModifiedDate { get; set; }
        public string PtTpLastModifiedByUser { get; set; }
        public Nullable<int> LogID { get; set; }
        public Nullable<int> ctrDiagnosisID { get; set; }
    
        public virtual DimHospitalDepartment DimHospitalDepartment { get; set; }
        public virtual DimMedoncPlan DimMedoncPlan { get; set; }
        public virtual DimMedoncPlanPhase DimMedoncPlanPhase { get; set; }
        public virtual DimPatient DimPatient { get; set; }
        public virtual DimUser DimUser { get; set; }
    }
}
