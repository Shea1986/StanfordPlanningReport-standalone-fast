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
    
    public partial class DimPatientDepartmentbyCUID
    {
        public long DimPatientDepartmentbyCUIDID { get; set; }
        public Nullable<long> DimPatientID { get; set; }
        public Nullable<long> DimUserID { get; set; }
        public Nullable<long> DimHospitalDepartmentID { get; set; }
        public Nullable<System.DateTime> EffectiveStartDate { get; set; }
        public Nullable<System.DateTime> EffectiveEndDate { get; set; }
        public Nullable<long> ctrPatientDepartmentSer { get; set; }
        public Nullable<int> LogID { get; set; }
    
        public virtual DimHospitalDepartment DimHospitalDepartment { get; set; }
        public virtual DimPatient DimPatient { get; set; }
        public virtual DimUser DimUser { get; set; }
    }
}
