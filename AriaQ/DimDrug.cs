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
    
    public partial class DimDrug
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DimDrug()
        {
            this.FactActivityBillings = new HashSet<FactActivityBilling>();
        }
    
        public long DimDrugID { get; set; }
        public string UnitOfMeasure { get; set; }
        public string AgentName { get; set; }
        public string MedispanDrugName { get; set; }
        public string PreferredAgentName { get; set; }
        public string AgentClassDescription { get; set; }
        public string Route { get; set; }
        public string Form { get; set; }
        public string Strength { get; set; }
        public string ctrdrug_desc_id { get; set; }
        public Nullable<int> LogID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactActivityBilling> FactActivityBillings { get; set; }
    }
}
