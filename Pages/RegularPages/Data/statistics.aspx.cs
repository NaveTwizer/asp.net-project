using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nave_Project2.Pages.RegularPages.Data
{
    public partial class statistics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // button1 on click event
            Alert("First alert"); // this does show up on the screen
            Alert("Second alert"); // this does not show up
        }
    }
}