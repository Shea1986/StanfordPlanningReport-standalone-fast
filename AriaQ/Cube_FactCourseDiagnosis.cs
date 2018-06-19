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
    
    public partial class Cube_FactCourseDiagnosis
    {
        public long FactCourseDiagnosisID { get; set; }
        public long DimCourseID { get; set; }
        public long FactPatientDiagnosisID { get; set; }
        public Nullable<long> DimPatientID { get; set; }
        public Nullable<long> DimPrimaryOncologistID { get; set; }
        public Nullable<long> DimHospitalDepartmentID { get; set; }
        public Nullable<long> DimDiagnosisCodeID { get; set; }
        public string DiagnosisCode { get; set; }
        public string DiagnosisClinicalDescription { get; set; }
        public string DiagnosisFullTitle { get; set; }
        public Nullable<long> DimICDOSiteID { get; set; }
        public Nullable<long> DimCellTypeID { get; set; }
        public Nullable<long> DimLookupID_DiagnosisStatus { get; set; }
        public Nullable<long> DimLookupID_Ranking { get; set; }
        public Nullable<long> DimLookupID_Source { get; set; }
        public Nullable<long> DimLookupID_HistoricDxFlag { get; set; }
        public Nullable<long> DimLookupID_CellCategory { get; set; }
        public Nullable<long> DimLookupID_CellGrade { get; set; }
        public string Stage { get; set; }
        public Nullable<long> DimLookupID_StageStatus { get; set; }
        public Nullable<long> DimLookupID_Her2neuMethodType { get; set; }
        public Nullable<long> DimLookupID_Her2neuStatusType { get; set; }
        public Nullable<long> DimLookupID_Her2neuMethod2Type { get; set; }
        public Nullable<long> DimLookupID_Her2neuStatus2Type { get; set; }
        public Nullable<long> DimLookupID_Recurrence { get; set; }
        public Nullable<long> DimLookupID_Invasive { get; set; }
        public Nullable<long> DimLookupID_ConfirmedDx { get; set; }
        public string DiagnosisType { get; set; }
        public string DiagnosisMethodType { get; set; }
        public Nullable<long> DimLookupID_ICDOVersion { get; set; }
        public Nullable<long> DimDxSiteID_BodySystem { get; set; }
        public Nullable<int> TpClsTypeId { get; set; }
        public Nullable<int> TpClsValueId { get; set; }
        public string DxSite { get; set; }
        public string Laterality { get; set; }
        public string ERStatus { get; set; }
        public string PRStatus { get; set; }
        public Nullable<System.DateTime> DiagnosisDate { get; set; }
        public Nullable<int> PatientAgeAtDiagnosis { get; set; }
        public Nullable<System.DateTime> DiagnosisStatusDate { get; set; }
        public string DiagnosisDescription { get; set; }
        public string ClinicalDescription { get; set; }
        public string HistoricDetails { get; set; }
        public string Comments { get; set; }
        public string PathologyComments { get; set; }
        public string Behaviour { get; set; }
        public string DistantMets { get; set; }
        public Nullable<int> Nodes { get; set; }
        public Nullable<int> NodesPositive { get; set; }
        public Nullable<decimal> Size { get; set; }
        public string StageCriteria { get; set; }
        public string Stagebasis { get; set; }
        public string StageScheme { get; set; }
        public Nullable<decimal> SPhase { get; set; }
        public string MethodDescription { get; set; }
        public Nullable<int> CoresTaken { get; set; }
        public Nullable<int> CoresPositive { get; set; }
        public Nullable<int> GleasonPrimary { get; set; }
        public Nullable<int> GleasonSecondary { get; set; }
        public Nullable<int> GleasonTotal { get; set; }
        public Nullable<int> GleasonScore { get; set; }
        public string ObjectStatus { get; set; }
        public string HistologyCode { get; set; }
        public string HistologyTableName { get; set; }
        public string TStage { get; set; }
        public string NStage { get; set; }
        public string MStage { get; set; }
        public string SummaryStage { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
        public Nullable<int> ctrDiagnosisID { get; set; }
        public Nullable<long> ctrDiagnosisSer { get; set; }
        public Nullable<int> CalYearNo { get; set; }
        public Nullable<int> DiagnosisMonthNo { get; set; }
        public Nullable<int> DiagnosisQuarterNo { get; set; }
        public string DiagnosisQuarterName { get; set; }
        public string DiagnosisMonthName { get; set; }
    }
}
