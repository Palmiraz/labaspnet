using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExamplesLinq.Models;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace ExamplesLinq
{
    class Program
    {
         

        private static ListData list = new ListData();
        static void Main(string[] args)
        {

            //GenericClass<string, string> objClass = new GenericClass<string, string>();
            //list.GetProductList();
            //SelectExample();
            

            SelectXml();
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

        public static void SelectXml()
        {
            XDocument document = XDocument.Load("..\\..\\Models\\Categories.xml");
            if (document.Root != null)
            {
                var query = from d in document.Root.Elements("department")
                            let xAttribute = d.Attribute("deparment") 
                            where xAttribute != null 
                            select new Deparment
                            {
                                Name=xAttribute.Value,
                                Categories = (
                                from c in d.Elements("category")
                                let xCat = c.Attribute("category")
                                where xCat != null
                                select new Categories
                                {
                                    Name=xCat.Value,
                                    SubCategories = (
                                    from s in c.Elements("subcategory")
                                    let xSub = s.Attribute("subcategory")
                                    where xSub != null
                                    select new Subcategories{Name=xSub.Value}
                                    ).ToList()
                                }
                                ).ToList()

                            };

                foreach (var deparment in query)
                {
                   
                    foreach (var category in deparment.Categories)
                    {
                        foreach (var sub  in category.SubCategories)
                        {
                            Console.WriteLine("{0} {1} {2}", deparment.Name, category.Name, sub.Name);
                        }
                    }
                }
            }
        }
    }
}

public class Deparment
{
    public string Name { get; set; }
    public List<Categories> Categories { get; set; }

}

public class Categories
{
    public string Name { get; set; }
    public List<Subcategories> SubCategories { get; set; }
}

public class Subcategories
{
    public string Name { get; set; }
}