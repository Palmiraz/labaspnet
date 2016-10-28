using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;


namespace ShoeEcommers.WebAdminDynamic.DynamicData.FieldTemplates
{
    public partial class DateTimeText_Edit :  System.Web.DynamicData.FieldTemplateUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                FillControls();
                

                //if (FieldValueString != null && DateTime.TryParse(FieldValueString, out date))
                //{
                //    SelectDate = date;
                //}
            
        }

        public string SetValue(string strValue)
        {
            DateTime date;
            if (FieldValueString != null && DateTime.TryParse(FieldValueString, out date))
            {
                SelectDate = date;
            }
            return string.Empty;
        }
      

        private void FillControls()
        {
            if (DropDay.Items.Count > 1) return;
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

        protected void ValidDate_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = Information.IsDate(StrDate);
        }

        protected override void ExtractValues(System.Collections.Specialized.IOrderedDictionary dictionary)
        {
            dictionary[Column.Name] = ConvertEditedValue(StrDate);
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
        
    }
}