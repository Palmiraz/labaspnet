using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace CodeFirtsDemo
{
    public class SchoolDataContext : DbContext
    {
        public DbSet<Students> Students { get; set; }
    }
}
