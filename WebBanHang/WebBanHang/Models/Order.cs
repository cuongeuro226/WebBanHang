//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanHang.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.DetailOrders = new HashSet<DetailOrder>();
        }
    
        public long Id { get; set; }
        public Nullable<long> Detail { get; set; }
        public Nullable<decimal> SumCost { get; set; }
        public Nullable<bool> deliverred { get; set; }
        public Nullable<bool> comfirmed { get; set; }
        public Nullable<bool> deteled { get; set; }
        public Nullable<System.DateTime> CreateDay { get; set; }
        public string Address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailOrder> DetailOrders { get; set; }
    }
}
