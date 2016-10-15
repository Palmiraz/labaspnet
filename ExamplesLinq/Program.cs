using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExamplesLinq.Models;

namespace ExamplesLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            ListData list = new ListData();
            list.GetProductList();
        }
    }
}
