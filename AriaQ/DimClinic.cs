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
    
    public partial class DimClinic
    {
        public long DimClinicID { get; set; }
        public Nullable<long> DimHospitalDepartmentID { get; set; }
        public string ClinicName { get; set; }
        public string ActiveEntryInd { get; set; }
        public Nullable<int> ctrclinic_id { get; set; }
        public Nullable<int> LogID { get; set; }
    
        public virtual DimHospitalDepartment DimHospitalDepartment { get; set; }
    }
}
