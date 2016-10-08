using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeEcommers.LogicLayer.Repositories;

namespace ShoesEcommers.WebAdmin.Catalogs
{
    public partial class FrmCustomers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.IsEnabled = true;
            if (!IsPostBack)
            {
                FillData();
            }
        }

        private void FillData()
        {
            CustomerRepository repo = new CustomerRepository();
            GridCustomer.DataSource = repo.GetCustomers();
            GridCustomer.DataBind();
        }
    }
}