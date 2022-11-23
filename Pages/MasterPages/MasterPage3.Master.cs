using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nave_Project2.Pages.MasterPages
{
    public partial class MasterPage3 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["username"] as string))
            {
                Response.Redirect("~/Pages/RegularPages/403.aspx");
                Response.End();
            }
            if (Session["username"].ToString() != "admin")
            {
                Response.Redirect("~/Pages/RegularPages/403.aspx");
                Response.End();
            }
            /*if (Session["username"] == null)
            {
                Response.Redirect("~/Pages/RegularPages/403.aspx");
                Response.End();
            }*/
        }
    }
}