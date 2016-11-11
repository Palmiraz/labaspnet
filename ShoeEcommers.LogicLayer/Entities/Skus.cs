//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoeEcommers.LogicLayer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Skus
    {
        public Skus()
        {
            this.AttributeSkus = new HashSet<AttributeSkus>();
            this.ImagesSkus = new HashSet<ImagesSkus>();
            this.OrderDetail = new HashSet<OrderDetail>();
        }
    
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public string Sku { get; set; }
        public bool Active { get; set; }
        public decimal Price { get; set; }
        public decimal ListPrice { get; set; }
        public string Thumbnail { get; set; }
        public Nullable<int> IdRef { get; set; }
    
        public virtual ICollection<AttributeSkus> AttributeSkus { get; set; }
        public virtual ICollection<ImagesSkus> ImagesSkus { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual Products Products { get; set; }
    }
}
