using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nave_Project2.Master_Pages
{
    public partial class AdminNested : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String _us = Session["username"].ToString();
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/login.aspx", true);
                return;
            }
            String username = Session["username"].ToString();
            if (String.IsNullOrEmpty(username))
            {
                Response.Redirect("~/Pages/login.aspx", true);
                return;
            }
            if (!username.Equals("nave"))
            {
                Response.Redirect("~/Pages/LoggedHomePage.aspx", true);
                return;
            }
        }
    }
}