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
    
    public partial class DimRxHydra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DimRxHydra()
        {
            this.DimRxAgts = new HashSet<DimRxAgt>();
        }
    
        public long DimRxHydraID { get; set; }
        public long DimRxID { get; set; }
        public string ctrpt_id { get; set; }
        public Nullable<int> ctrpt_visit_id { get; set; }
        public Nullable<int> ctrrx_id { get; set; }
        public Nullable<int> ctrr_hydra_id { get; set; }
        public Nullable<int> RxHydraFluidId { get; set; }
        public Nullable<decimal> RxHydraVolume { get; set; }
        public long RxHydraVolumeUnit_DimLookupID { get; set; }
        public string RxHydraDescription { get; set; }
        public Nullable<int> RxHydraSequence { get; set; }
        public Nullable<int> RxHydraInfusionLine { get; set; }
        public Nullable<decimal> RxHydraOrderVolume { get; set; }
        public long RxHydraOrderVolumeUnit_DimLookupID { get; set; }
        public Nullable<decimal> RxHydraTotalBagVolume { get; set; }
        public string RxHydraCalculationType { get; set; }
        public Nullable<int> LogID { get; set; }
    
        public virtual DimRx DimRx { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DimRxAgt> DimRxAgts { get; set; }
    }
}
