using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Nave_Project2.Utils.Security;
namespace Nave_Project2.Pages.profile
{
    public partial class update_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectUnloggedUser(System.Web.HttpContext.Current);
        }
    }
}