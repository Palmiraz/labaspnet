using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShoeEcommers.LogicLayer.Modelos;
using ShoeEcommers.LogicLayer.Entities;

namespace ShoeEcommers.LogicLayer.ServicesApp
{
    public class ServicesHome : ServicesBase
    {
        private readonly ecommersEntities1 _dc;
        private readonly DataHomeSite _result;
        public ServicesHome()
        {
            _dc = new ecommersEntities1();
            _result = new DataHomeSite();
            ListDisposable.Add(_dc);
        }

        public DataHomeSite GetDataHome()
        {
            _result.CampaignsCarrousel = _dc.Campaigns.Where(c => c.IsPrincipal == true).OrderBy(c => c.OrderPrincipal).ToList();
            _result.CampaignsHome= _dc.Campaigns.OrderBy(c => c.OrderCamp).ToList();
            return _result;
        }

        public void SaveContactUs(ContactUs contact)
        {
            contact.DateCreated = DateTime.Now;
            _dc.ContactUs.Add(contact);
            _dc.SaveChanges();

        }

    }
}
