using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeEcommers.LogicLayer.Modelos;
using ShoeEcommers.LogicLayer.Repositories;

namespace ShoesEcommers.WebAdmin.Catalogs
{
    public partial class FrmNewCustomer : System.Web.UI.Page
    {
        private readonly CustomerRepository _repo;
        public FrmNewCustomer()
        {
            _repo = new CustomerRepository();
        }
        

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillData();
            }
        }

        private void FillData()
        {
            string strId = Request.QueryString["id"];
            if (string.IsNullOrEmpty(strId))
            {
                return;
            }
            this.HiddId.Value = strId;
            Customers customer = 
                _repo.GetCustomerById(Convert.ToInt32(strId));

            TxtName.Text = customer.Name;
            TxtFirstName.Text = customer.FirstName;
            TxtLastName.Text = customer.LastName;
            TxtEmail.Text = customer.Email;
            CtlDate.SelectDate = customer.DateBirth;


        }

        public override void Dispose()
        {
            _repo.Dispose();
            base.Dispose();
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (!IsValid)
            {
                LblMessage.Text = "Formulario Incorrecto";
                ContentMessage.Attributes.Add("class", "alert alert-danger");
            }
            else
            {
                Customers customer = new Customers();
                if (!string.IsNullOrEmpty(HiddId.Value))
                {
                    customer.Id = Convert.ToInt32(HiddId.Value);
                }
                customer.Name = TxtName.Text;
                customer.FirstName = TxtFirstName.Text;
                customer.LastName = TxtLastName.Text;
                customer.Email = TxtEmail.Text;
                customer.DateBirth = CtlDate.SelectDate;

                if (_repo.SaveCustomer(customer))
                {
                    this.HiddId.Value = customer.Id.ToString();
                    LblMessage.Text = "<strong>¡Datos Almacenados! </strong>formulario correcto";
                    ContentMessage.Attributes.Add("class", "alert alert-success");
                }
                else
                {
                    LblMessage.Text = "Error al guardar en base de datos";
                    ContentMessage.Attributes.Add("class", "alert alert-danger");
           
                }

            }
        }

        
    }
}