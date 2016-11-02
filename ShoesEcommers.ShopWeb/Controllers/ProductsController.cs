using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesEcommers.ShopWeb.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Campaign(int id)
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
