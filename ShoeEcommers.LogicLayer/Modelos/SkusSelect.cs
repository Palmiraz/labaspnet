using ShoeEcommers.LogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeEcommers.LogicLayer.Modelos
{
    public class SkusSelect
    {
        public int IdSku { get; set; }
        public int Quantity { get; set; }
        public Skus Sku { get; set; }
    }
}
