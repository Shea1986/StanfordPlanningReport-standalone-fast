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
    
    public partial class FactActivityCaptureAttribute
    {
        public long FactActivityCaptureAttributeID { get; set; }
        public Nullable<long> DimActivityAttributeID { get; set; }
        public string AttributeValue { get; set; }
        public Nullable<long> ctrActivityCaptureSer { get; set; }
        public Nullable<int> ActivityCaptureRevCount { get; set; }
        public long ctrActivityCaptureAttributeSer { get; set; }
        public Nullable<int> ActivityCaptureAttrRevCount { get; set; }
        public string ActivityCaptureAttributeObjectStatus { get; set; }
        public Nullable<int> LogID { get; set; }
    
        public virtual DimActivityAttribute DimActivityAttribute { get; set; }
    }
}