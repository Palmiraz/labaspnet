using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExamplesLinq.Models;

namespace ExamplesLinq
{
    class Program
    {
        private static ListData list = new ListData();
        static void Main(string[] args)
        {
            list.GetProductList();
            SelectExample();
            Console.Read();
        }

        private static void SelectExample()
        {
            var query = from c in list.categories
                join p in list.GetProductList() on c equals p.Category into ps
                from p in ps.DefaultIfEmpty()
                where p == null 
                select c;

            query.ToList().ForEach(c => Console.WriteLine(c));

        }

        


    }
}
