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
    
    public partial class ExecutionLog
    {
        public int LogID { get; set; }
        public Nullable<int> ParentLogID { get; set; }
        public string Description { get; set; }
        public string PackageName { get; set; }
        public System.Guid PackageGuid { get; set; }
        public string MachineName { get; set; }
        public System.Guid ExecutionGuid { get; set; }
        public Nullable<System.DateTime> LogicalDate { get; set; }
        public string Operator { get; set; }
        public System.DateTime StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public byte Status { get; set; }
        public string FailureTask { get; set; }
    }
}
