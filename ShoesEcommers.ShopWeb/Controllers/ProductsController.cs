using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoeEcommers.LogicLayer.Entities;
using ShoeEcommers.LogicLayer.Modelos;
using ShoesEcommers.ShopWeb.Globals;

namespace ShoesEcommers.ShopWeb.Controllers
{
    public class ProductsController : ShopBaseController
    {
        public readonly ecommersEntities _dc;
        public ProductsController()
        {
            _dc = new ecommersEntities();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Campaign(int id)
        {
            var query = from p in _dc.Products
                join s in _dc.Skus on p.Id equals s.IdProduct
                join a in _dc.AttributeSkus on s.Id equals a.IdSku
                        where p.Campaigns.Any(c => c.Id == id) && p.Active == true
                        group s by new GroupsSkusFront { IdProduct = p.Id, ValueGroup= a.ValueLabel } into groupsData
                select groupsData;
            List<IGrouping<GroupsSkusFront, Skus>> result = query.ToList();
            return View(result);
        }

        public ActionResult Details(int id)
        {
            Products product = _dc.Products.First(p=>p.Id == id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Details(SkuSelectProduct data)
        {
            Products product = _dc.Products.First(p => p.Id == data.IdProduct);
            var query = product.Skus.Where(s => s.Sku == data.LookSize);
            if (query.Any() && data.Quantity > 0)
            {
                Vars.CurrentCar.AddProduct(query.First().Id, data.Quantity);
                return Redirect("~/Checkout/Index");
            }
            ViewBag.ErrorMessage = "Selecciona una talla o ingresa la cantidad";
            return View(product);
        }

        protected override void Dispose(bool disposing)
        {
            _dc.Dispose();
            base.Dispose(disposing);
        }
    }
  

    
}
