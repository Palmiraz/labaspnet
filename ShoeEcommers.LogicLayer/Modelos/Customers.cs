using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeEcommers.LogicLayer.Modelos
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}
