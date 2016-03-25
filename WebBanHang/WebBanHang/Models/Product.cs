﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.DetailOrders = new HashSet<DetailOrder>();
        }

        public long Id { get; set; }
        [Required(ErrorMessage = "yêu cầu nhập ô này")]
        public string Name { get; set; }
        [AllowHtml]
        [Required(ErrorMessage = "yêu cầu nhập ô này")]
        public string Description { get; set; }
        [Required(ErrorMessage = "yêu cầu nhập ô này")]
        public string Image { get; set; }
        [Required(ErrorMessage = "yêu cầu nhập ô này")]
        public Nullable<int> QuantityAvailable { get; set; }
        [Required(ErrorMessage = "yêu cầu nhập ô này")]
        public Nullable<decimal> Price { get; set; }
        [Required(ErrorMessage = "yêu cầu nhập ô này")]
        public Nullable<bool> IsTop { get; set; }
        [Required(ErrorMessage = "yêu cầu nhập ô này")]
        public long Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailOrder> DetailOrders { get; set; }
    }
}
