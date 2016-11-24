using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoesEcommers.ShopWeb.Models
{
    public class Result
    {
        public int State { get; set; }
        public dynamic Response { get; set; }
        public string Message { get; set; }
        public int TotalRows { get; set; }
        public bool IsCorrect { get; set; }
    }
}