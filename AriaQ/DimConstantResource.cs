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
    
    public partial class DimConstantResource
    {
        public long DimConstantResourceID { get; set; }
        public Nullable<long> DimLookupID_ResourceType { get; set; }
        public string ResourceId { get; set; }
        public string ResourceFullName { get; set; }
        public string ResourceAliasName { get; set; }
        public Nullable<int> ResourceTypeNum { get; set; }
        public string ResourceObjectStatus { get; set; }
        public string Schedulable { get; set; }
        public string ResourceCompleteAddress { get; set; }
        public Nullable<int> IsPrimaryResourceAddress { get; set; }
        public string ResourceAddressType { get; set; }
        public string ResourceAddressComment { get; set; }
        public string ResourcePrimaryPhoneNumber { get; set; }
        public string ResourceSecondaryPhoneNumber { get; set; }
        public string ResourcePagerNumber { get; set; }
        public string ResourceFaxNumber { get; set; }
        public string ResourceEMailAddress { get; set; }
        public Nullable<System.DateTime> ResourceOriginationDate { get; set; }
        public Nullable<System.DateTime> ResourceTerminationDate { get; set; }
        public Nullable<long> ctrResourceSer { get; set; }
        public Nullable<int> LogID { get; set; }
    
        public virtual DimLookup DimLookup { get; set; }
    }
}
