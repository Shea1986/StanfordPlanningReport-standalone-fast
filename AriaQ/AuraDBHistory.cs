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
    
    public partial class AuraDBHistory
    {
        public long AuraDBHistoryID { get; set; }
        public string EventType { get; set; }
        public string StartingRelease { get; set; }
        public string EndingRelease { get; set; }
        public string Description { get; set; }
        public string UpgrVersion { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> InstalledDateTime { get; set; }
        public Nullable<System.DateTime> UnInstalledDateTime { get; set; }
    }
}
