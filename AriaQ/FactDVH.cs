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
    
    public partial class FactDVH
    {
        public long FactDVHID { get; set; }
        public double DoseValue { get; set; }
        public Nullable<double> Volume { get; set; }
        public Nullable<long> DimCourseID { get; set; }
        public Nullable<long> DimPlanID { get; set; }
        public Nullable<long> DimPatientID { get; set; }
        public Nullable<long> DimStructureID { get; set; }
        public Nullable<long> ctrPlanSer { get; set; }
        public Nullable<long> ctrCourseSer { get; set; }
        public Nullable<long> ctrPatientSer { get; set; }
        public Nullable<long> ctrStructureSer { get; set; }
        public Nullable<long> ctrStructureSetSer { get; set; }
        public string MaxDoseUnit { get; set; }
        public string MinDoseUnit { get; set; }
        public Nullable<decimal> MaxDose { get; set; }
        public Nullable<decimal> MinDose { get; set; }
        public Nullable<double> Coverage { get; set; }
        public Nullable<double> SamplingCoverage { get; set; }
        public Nullable<decimal> StdDev { get; set; }
        public Nullable<double> DataArrayVolume { get; set; }
        public Nullable<double> RelativeDose { get; set; }
        public Nullable<double> RelativeVolume { get; set; }
        public Nullable<int> LogID { get; set; }
        public Nullable<double> RelativeVolumeRounded { get; set; }
    
        public virtual DimCourse DimCourse { get; set; }
        public virtual DimPatient DimPatient { get; set; }
        public virtual DimPlan DimPlan { get; set; }
        public virtual DimStructure DimStructure { get; set; }
    }
}