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
    
    public partial class FactPatientSocialHistory
    {
        public long FactPatientSocialHistoryID { get; set; }
        public Nullable<long> DimPatientID { get; set; }
        public Nullable<int> NoAlcoholUsePerWeek { get; set; }
        public Nullable<int> NoAlcoholUsePerDay { get; set; }
        public Nullable<decimal> NoPacksPerDay { get; set; }
        public Nullable<int> NoYearsQuitAlcohol { get; set; }
        public Nullable<int> NoYearsQuitSmoking { get; set; }
        public Nullable<int> NoYearsActiveSmoker { get; set; }
        public string HazardMaterialContactIndicator { get; set; }
        public string AlcoholUseStatus { get; set; }
        public string SmokingUseStatus { get; set; }
        public string ValidEntryIndicator { get; set; }
        public Nullable<int> ctrPatientSocialHistoryId { get; set; }
        public Nullable<int> LogID { get; set; }
    
        public virtual DimPatient DimPatient { get; set; }
    }
}
