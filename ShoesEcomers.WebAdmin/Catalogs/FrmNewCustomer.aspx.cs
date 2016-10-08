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
                FillControls();
            }
        }

        private void FillControls()
        {
            List<int> years = new List<int>();
            List<string> days  = new List<string>();
            for (int i = DateTime.Now.Year -1; i >  DateTime.Now.Year -100 ; i--)
            {
                years.Add(i);
            }
            if (DateTimeFormatInfo.CurrentInfo != null)
            {
                DropMonth.DataSource = DateTimeFormatInfo.CurrentInfo.MonthNames;
                DropMonth.DataBind();
            }
            for (int i = 1; i <= 31; i++)
            {
                string day = ((i < 10) ? "0" : "") + i;
                days.Add(day);
            }
            DropDay.DataSource = days;
            DropDay.DataBind();

            DropYear.DataSource = years;
            DropYear.DataBind();

        }
    }
}