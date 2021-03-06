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
    
    public partial class FactPatient
    {
        public long FactPatientID { get; set; }
        public long DimPatientID { get; set; }
        public Nullable<long> DimNationalityID { get; set; }
        public Nullable<long> DimLookupID_Race { get; set; }
        public Nullable<long> DimLookupID_Gender { get; set; }
        public Nullable<long> DimLocationID { get; set; }
        public Nullable<long> DimHospitalDepartmentID { get; set; }
        public Nullable<long> DimPrimaryOncologistID { get; set; }
        public Nullable<long> DimDateID_PatientCreation { get; set; }
        public Nullable<long> DimDateID_PatientDischarge { get; set; }
        public Nullable<long> DimDateID_PatientAdmission { get; set; }
        public Nullable<long> DimPrimaryReferringPhysicianID { get; set; }
        public Nullable<long> DimLookupID_PatientStatus { get; set; }
        public Nullable<System.DateTime> PatientCreationDate { get; set; }
        public Nullable<System.DateTime> PatientAdmissionDate { get; set; }
        public Nullable<System.DateTime> PatientDischargeDate { get; set; }
        public Nullable<int> LogID { get; set; }
        public Nullable<long> DimMedoncHospitalDepartmentID { get; set; }
        public Nullable<long> DimMedoncPrimaryOncologistID { get; set; }
        public Nullable<long> DimMedoncPrimaryReferringPhysicianID { get; set; }
        public string MOROIndicator { get; set; }
    
        public virtual DimDate DimDate { get; set; }
        public virtual DimDate DimDate1 { get; set; }
        public virtual DimDate DimDate2 { get; set; }
        public virtual DimDoctor DimDoctor { get; set; }
        public virtual DimDoctor DimDoctor1 { get; set; }
        public virtual DimHospitalDepartment DimHospitalDepartment { get; set; }
        public virtual DimLocation DimLocation { get; set; }
        public virtual DimLookup DimLookup { get; set; }
        public virtual DimLookup DimLookup1 { get; set; }
        public virtual DimLookup DimLookup2 { get; set; }
        public virtual DimNationality DimNationality { get; set; }
        public virtual DimPatient DimPatient { get; set; }
    }
}
