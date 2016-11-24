using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoeEcommers.LogicLayer.Modelos;
using System.Web;


namespace ShoesEcommers.ShopWeb.Globals
{
    public static class Vars
    {
        private static ShopingCars _currentCar;
        public static ShopingCars CurrentCar
        {
            get
            {
                if (_currentCar == null)
                {
                    if (HttpContext.Current.Session["ShopingCar"] == null)
                    {
                        HttpContext.Current.Session["ShopingCar"] = new ShopingCars();
                    }
                    _currentCar = (ShopingCars)HttpContext.Current.Session["ShopingCar"];
                }
                return _currentCar;
            }
            set
            {
                HttpContext.Current.Session["ShopingCar"] = value;
                _currentCar = value;
            }
        }
    }
}