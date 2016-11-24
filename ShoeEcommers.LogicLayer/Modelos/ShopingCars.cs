using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeEcommers.LogicLayer.Modelos
{
    public class ShopingCars
    {
        public ShopingCars()
        {
            SkusSelect = new List<SkusSelect>();
        }
        public List<SkusSelect> SkusSelect { get; set; }
        public void AddProduct(int idSku, int quantity)
        {
            var query = SkusSelect.Where(s => s.IdSku == idSku);
            if (query.Any())
            {
                SkusSelect skuS = query.First();
                skuS.Quantity = skuS.Quantity + quantity;
            }
            else
            {
                SkusSelect skuS = new SkusSelect();
                skuS.Quantity = quantity;
                skuS.IdSku = idSku;
                SkusSelect.Add(skuS);
            }
        }

    }
}
