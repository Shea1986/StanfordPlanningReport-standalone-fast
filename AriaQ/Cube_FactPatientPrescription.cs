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
    
    public partial class Cube_FactPatientPrescription
    {
        public long FactPatientPrescriptionID { get; set; }
        public string BolusFrequency { get; set; }
        public string BolusThickness { get; set; }
        public string PrescriptionName { get; set; }
        public Nullable<int> NumberOfFractions { get; set; }
        public string Gating { get; set; }
        public Nullable<int> SimulationNeeded { get; set; }
        public string Site { get; set; }
        public string Technique { get; set; }
        public string TimeGapType { get; set; }
        public string AnatomyName { get; set; }
        public Nullable<short> AnatomyRole { get; set; }
        public string Param1Value { get; set; }
        public string Param1ValueUnit { get; set; }
        public string AnatomyItemType { get; set; }
        public string AnatomyItemValue { get; set; }
        public string AnatomyItemValueUnit { get; set; }
        public Nullable<short> PropertyType { get; set; }
        public string PropertyValue { get; set; }
        public Nullable<short> ItemType { get; set; }
        public string ItemValue { get; set; }
        public Nullable<long> DimCourseID { get; set; }
        public string CourseId { get; set; }
        public Nullable<System.DateTime> CourseStartDateTime { get; set; }
        public Nullable<int> CourseDuration { get; set; }
        public Nullable<int> NoTxSessionDelivered { get; set; }
        public Nullable<int> NoTxSessionPlanned { get; set; }
        public Nullable<int> NoTxSessionRemaining { get; set; }
        public Nullable<long> DimPatientID { get; set; }
    }
}
