using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoesEcommers.WebAdmin.Catalogs
{
    public partial class FrmNewCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        public override void Dispose()
        {
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
                LblMessage.Text = "<strong>¡Datos Almacenados! </strong>formulario correcto";
                ContentMessage.Attributes.Add("class", "alert alert-success");
            }
        }

        
    }
}