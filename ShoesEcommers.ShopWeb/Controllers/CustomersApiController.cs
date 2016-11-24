using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoeEcommers.LogicLayer.Entities;

namespace ShoesEcommers.ShopWeb.Controllers
{
    public class CustomersApiController : BaseApiController
    {
        private readonly ecommersEntities _dc;
        public CustomersApiController()
        {
            _dc = new ecommersEntities();
        }

        public HttpResponseMessage Get(int id = 0)
        {
            try
            {
                if (id > 0 && _dc.Customers.Any(c => c.Id == id))
                {
                    Customers customer = _dc.Customers.First(c => c.Id == id);
                    Res.Response = new
                    {
                        customer.Id,
                        customer.Name,
                        customer.FirstName,
                        customer.LastName,
                        customer.DateBirth,
                        customer.Email
                    };
                    Res.IsCorrect = true;
                }
                return CreateResponse();
            }
            catch (Exception er)
            {
                return Error(er);
            }
        }

        public HttpResponseMessage Post(Customers customer)
        {
            try
            {
                UserProfile user = _dc.UserProfile.First(u => u.UserName == User.Identity.Name);
                if (customer.Id == 0)
                {
                    customer.IdUser = user.UserId;
                    _dc.Customers.Add(customer);
                    _dc.SaveChanges();
                }
                else
                {
                    Customers customerDb = _dc.Customers.First(c => c.IdUser == user.UserId);
                    customerDb.FirstName = customer.FirstName;
                    customerDb.LastName = customer.LastName;
                    customerDb.Name = customer.Name;
                    customerDb.Email = customer.Email;
                    customerDb.DateBirth = customer.DateBirth;
                    _dc.SaveChanges();

                }
                Res.IsCorrect = true;
                return CreateResponse();
            }
            catch (Exception er)
            {
                return Error(er);
            }
        }


    }
}
