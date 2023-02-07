using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Nave_Project2.Utils.Security;
namespace Nave_Project2.Pages.data.update
{
    public partial class update_users1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
        }
    }
}