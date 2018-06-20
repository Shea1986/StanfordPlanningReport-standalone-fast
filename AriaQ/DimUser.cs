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
    
    public partial class DimUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DimUser()
        {
            this.DimActivityTransactions = new HashSet<DimActivityTransaction>();
            this.DimPatientDepartmentbyCUIDs = new HashSet<DimPatientDepartmentbyCUID>();
            this.DimPatientJournals = new HashSet<DimPatientJournal>();
            this.DimUserDepartments = new HashSet<DimUserDepartment>();
            this.FactActivityBillings = new HashSet<FactActivityBilling>();
            this.FactActivityBillings1 = new HashSet<FactActivityBilling>();
            this.FactActivityBillings2 = new HashSet<FactActivityBilling>();
            this.FactActivityBillings3 = new HashSet<FactActivityBilling>();
            this.FactActivityBillings4 = new HashSet<FactActivityBilling>();
            this.FactActivityBillings5 = new HashSet<FactActivityBilling>();
            this.FactActivityBillings6 = new HashSet<FactActivityBilling>();
            this.FactInVivoDosimetries = new HashSet<FactInVivoDosimetry>();
            this.FactPatientExams = new HashSet<FactPatientExam>();
            this.FactPatientExams1 = new HashSet<FactPatientExam>();
            this.FactPatientImages = new HashSet<FactPatientImage>();
            this.FactPatientLabResults = new HashSet<FactPatientLabResult>();
            this.FactPatientMedoncTreatments = new HashSet<FactPatientMedoncTreatment>();
            this.FactPhysicianOrders = new HashSet<FactPhysicianOrder>();
            this.FactPhysicianOrders1 = new HashSet<FactPhysicianOrder>();
            this.FactQuestionnaires = new HashSet<FactQuestionnaire>();
            this.FactRxDispSyringes = new HashSet<FactRxDispSyringe>();
            this.FactRxDispSyringes1 = new HashSet<FactRxDispSyringe>();
            this.FactTreatmentHistories = new HashSet<FactTreatmentHistory>();
            this.FactTreatmentHistories1 = new HashSet<FactTreatmentHistory>();
            this.FactTreatmentHistories2 = new HashSet<FactTreatmentHistory>();
            this.FactTreatmentHistories3 = new HashSet<FactTreatmentHistory>();
            this.FactTreatmentHistories4 = new HashSet<FactTreatmentHistory>();
            this.FactTreatmentHistories5 = new HashSet<FactTreatmentHistory>();
            this.FactTreatmentHistories6 = new HashSet<FactTreatmentHistory>();
            this.FactTreatmentHistories7 = new HashSet<FactTreatmentHistory>();
        }
    
        public long DimUserID { get; set; }
        public Nullable<long> DimResourceID { get; set; }
        public string UserCUID { get; set; }
        public string UserId { get; set; }
        public string LanguageId { get; set; }
        public Nullable<long> ctrAppUserSer { get; set; }
        public Nullable<int> LogID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string ctrinst_id { get; set; }
        public string ctruserid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DimActivityTransaction> DimActivityTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DimPatientDepartmentbyCUID> DimPatientDepartmentbyCUIDs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DimPatientJournal> DimPatientJournals { get; set; }
        public virtual DimResource DimResource { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DimUserDepartment> DimUserDepartments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactActivityBilling> FactActivityBillings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactActivityBilling> FactActivityBillings1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactActivityBilling> FactActivityBillings2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactActivityBilling> FactActivityBillings3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactActivityBilling> FactActivityBillings4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactActivityBilling> FactActivityBillings5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactActivityBilling> FactActivityBillings6 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactInVivoDosimetry> FactInVivoDosimetries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactPatientExam> FactPatientExams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactPatientExam> FactPatientExams1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactPatientImage> FactPatientImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactPatientLabResult> FactPatientLabResults { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactPatientMedoncTreatment> FactPatientMedoncTreatments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactPhysicianOrder> FactPhysicianOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactPhysicianOrder> FactPhysicianOrders1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactQuestionnaire> FactQuestionnaires { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactRxDispSyringe> FactRxDispSyringes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactRxDispSyringe> FactRxDispSyringes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactTreatmentHistory> FactTreatmentHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactTreatmentHistory> FactTreatmentHistories1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactTreatmentHistory> FactTreatmentHistories2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactTreatmentHistory> FactTreatmentHistories3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactTreatmentHistory> FactTreatmentHistories4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactTreatmentHistory> FactTreatmentHistories5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactTreatmentHistory> FactTreatmentHistories6 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactTreatmentHistory> FactTreatmentHistories7 { get; set; }
    }
}