using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoeEcommers.LogicLayer.Modelos;

namespace ShoesEcommers.ShopWeb.Controllers
{
    public class ShopBaseController : Controller
    {

        public int NoProducts()
        {
            return Car.Count;
        }

        private List<ShopingCar> _car;
        public List<ShopingCar> Car {
            get {
                if (_car == null)
                {
                    if (Session["ShopingCardSession"] == null)
                    {
                        _car = new List<ShopingCar>();
                        Session["ShopingCardSession"] = _car;
                    }
                    _car = (List<ShopingCar>)Session["ShopingCardSession"];
                }
                return _car;
            }
            set
            {
                _car = value;
                Session["ShopingCardSession"] = value;
            }
        }

    }
}
