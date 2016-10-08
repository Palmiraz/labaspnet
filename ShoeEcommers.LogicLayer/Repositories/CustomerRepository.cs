using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShoeEcommers.LogicLayer.Modelos;

namespace ShoeEcommers.LogicLayer.Repositories
{
    public class CustomerRepository
    {
        public List<Customers> GetCustomers(string name = "")
        {
            List<Customers> result = new List<Customers>();
            for(int i = 1; i < 10; i++)
            {
                Customers customer = new Customers();
                customer.Id = i;
                customer.DateCreated = DateTime.Now;
                customer.Name = "name" + i;
                customer.FirstName = "app" + i;
                customer.LastName = "appMat" + i;
                customer.DateBirth = DateTime.Now.AddYears(-18);
                result.Add(customer);
            }
            return result;
        }

    }
}
