using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirtsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolDataContext dc = new SchoolDataContext();
            Students student = new Students {Name="Marco"};
            dc.Students.Add(student);
            dc.SaveChanges();
        }
    }
}
