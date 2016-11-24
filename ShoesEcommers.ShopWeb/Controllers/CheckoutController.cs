using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoeEcommers.LogicLayer.Modelos;
using ShoeEcommers.LogicLayer.Entities;
using ShoesEcommers.ShopWeb.Globals;

namespace ShoesEcommers.ShopWeb.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ecommersEntities _dc;
        public CheckoutController()
        {
            _dc = new ecommersEntities();
        }


        public ActionResult Index()
        {
            ShopingCars car = Vars.CurrentCar;
            car.SkusSelect.ForEach(se=>se.Sku = _dc.Skus.First(s=>s.Id == se.IdSku));
            return View(car);
        }

        [Authorize]
        public ActionResult PayProduct()
        {
            return View();
        }



    }
}
