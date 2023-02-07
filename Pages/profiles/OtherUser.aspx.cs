using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Nave_Project2.Utils.Security;
namespace Nave_Project2.Pages.profiles
{
    public partial class OtherUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectUnloggedUser(System.Web.HttpContext.Current);
            string RequestedUsername = Page.RouteData.Values["username"].ToString();
            string username = Session["username"].ToString();
            if (RequestedUsername.ToLower().Equals(username))
            {
                Response.Redirect($"~/Pages/profiles/my.aspx", true);
                return;
            }
            this.title.InnerText = $"Requested for {RequestedUsername}";
        }
    }
}