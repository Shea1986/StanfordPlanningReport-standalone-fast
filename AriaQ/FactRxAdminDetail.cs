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
    
    public partial class FactRxAdminDetail
    {
        public long FactRxAdminDetailID { get; set; }
        public long DimRxAdminID { get; set; }
        public Nullable<int> ctrRxAdminDetailId { get; set; }
        public long RxAdminDetailDatetimeID { get; set; }
        public string RxAdminDetailType { get; set; }
        public Nullable<decimal> RxAdminDetailDoseTaken { get; set; }
        public Nullable<decimal> RxAdminDetailDose { get; set; }
        public long RxAdminDetailApprDatetimeID { get; set; }
        public Nullable<long> RxAdminDetailApprovedBy_DimUserID { get; set; }
        public string RxAdminDetailValidEntry { get; set; }
        public Nullable<long> RxAdminDetailEnteredBy_DimUserID { get; set; }
        public Nullable<System.DateTime> RxAdminDetailEnteredDatetime { get; set; }
        public Nullable<long> RxAdminDetailLastModifiedBy_DimUserID { get; set; }
        public Nullable<System.DateTime> RxAdminDetailLastModifiedDatetime { get; set; }
        public Nullable<int> LogID { get; set; }
    
        public virtual DimRxAdmin DimRxAdmin { get; set; }
    }
}