using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nave_Project2.Pages.shop
{
    public partial class search_invoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SearchButton_Click(object sender, EventArgs e)
        {
            string RequestedInvoice = (string)Request.Form["invoice-number"].ToString();
            string url = $"/Pages/shop/Invoices/{RequestedInvoice}";
            Response.Redirect(url);
        }
    }
}