using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;

namespace ShoesEcommers.WebAdmin.Controls
{
    public partial class CtlDate : System.Web.UI.UserControl
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
            List<string> days = new List<string>();
            for (int i = DateTime.Now.Year - 1; i > DateTime.Now.Year - 100; i--)
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

        public string StrDate
        {
            get
            {

                return string.Format("{0}-{1}-{2}", DropYear.SelectedValue, DropMonth.SelectedIndex + 1, DropDay.SelectedIndex + 1);
            }
        }

        public DateTime SelectDate
        {
            get
            {
                if (Information.IsDate(StrDate))
                {
                    return DateTime.Parse(StrDate);
                }
                return DateTime.MinValue;
            }
            set
            {
                if (value == DateTime.MinValue)
                {
                    return;
                }
                DateTime date = value;
                DropDay.SelectedIndex = date.Day - 1;

                DropMonth.SelectedIndex = date.Month - 1;
                DropYear.SelectedValue = date.Year.ToString();


            }
        }



        protected void ValidDate_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = Information.IsDate(StrDate);
        }

        protected void DropDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}