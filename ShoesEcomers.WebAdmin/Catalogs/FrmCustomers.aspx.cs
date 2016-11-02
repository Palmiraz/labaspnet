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
        private readonly CustomerRepository _repo;
        public FrmCustomers()
        {
            _repo = new CustomerRepository();
        }

        public override void Dispose()
        {
            _repo.Dispose();
            base.Dispose();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            //Trace.IsEnabled = true;
            if (!IsPostBack)
            {
                //FillData();
            }
        }

        private void FillData()
        {
            GridCustomer.DataSource = _repo.GetCustomers();
            GridCustomer.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridCustomer.DataSource = 
                _repo.GetCustomers(TxtName.Text);
            GridCustomer.DataBind();
        }
    }
}