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
    
    public partial class InSightiveWaitTimeAppointments_TB
    {
        public long DimActivityTransactionID { get; set; }
        public string DepartmentName { get; set; }
        public string HospitalName { get; set; }
        public long DimPatientID { get; set; }
        public string PatientId { get; set; }
        public string ActivityCategoryCode { get; set; }
        public string CurrentActivity { get; set; }
        public string IsScheduled { get; set; }
        public long DimActivityID { get; set; }
        public Nullable<System.DateTime> CurrentActivityAppointmentDateTime { get; set; }
        public Nullable<System.DateTime> CurrentActivityStartDateTime { get; set; }
        public string CurrentActivityDxSite { get; set; }
        public string CurrentActivityAppointmentStatus { get; set; }
        public string CurrentActivityObjectStatus { get; set; }
        public Nullable<long> DimResourceID { get; set; }
        public string DoctorFullName { get; set; }
        public Nullable<byte> isIgnore { get; set; }
        public Nullable<short> ActivityOrder { get; set; }
        public string NextActivity { get; set; }
        public Nullable<System.DateTime> NextActivityAppointmentDateTime { get; set; }
        public Nullable<System.DateTime> NextActivityStartDateTime { get; set; }
        public string NextActivityDxSite { get; set; }
        public string NextActivityAppointmentStatus { get; set; }
        public string NextActivityObjectStatus { get; set; }
        public Nullable<int> CurrDate_NextDate { get; set; }
        public Nullable<bool> isFirstEntry { get; set; }
        public Nullable<bool> isLastEntry { get; set; }
    }
}
