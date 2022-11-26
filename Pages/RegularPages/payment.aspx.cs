using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nave_Project2.Pages.RegularPages
{
    public partial class payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Total = Request.QueryString["total"];
            int CurrentYear = DateTime.Now.Year;
            this.YearSelect.DataBind();
            string value;
            for (int i = CurrentYear; i < CurrentYear + 16; i++)
            {
                value = i.ToString();
                this.YearSelect.Items.Add(new ListItem(value, value));
            }
            this.toPay.InnerText = "לתשלום:" + " " + Total + " " + "שקלים";
        }
    }
}