using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nave_Project2.Pages
{
    public partial class LoggedHomePage : System.Web.UI.Page
    {
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Application.Lock();
            if (Application["visits"] == null)
                Application["visits"] = 0;
            Application["visits"] = (int)Application["visits"] + 1;
            Application.UnLock();

            string visits = Application["visits"].ToString();
            try
            {
                string username = Session["username"].ToString();
                this.WelcomeDiv.InnerHtml = $"<h1>Welcome, {username}, {visits}</h1>";
            }
            catch (Exception)
            {
                this.WelcomeDiv.InnerHtml = "<h1>Welcome</h1>";
            }
        }
    }
}