using System;
using System.IO;
using System.Data;
using static Nave_Project2.Utils.Database;
using System.Web.UI.WebControls;
using static Nave_Project2.Utils.Security;

namespace Nave_Project2.Pages
{
    public partial class LoggedHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectUnloggedUser(System.Web.HttpContext.Current);
            if (!IsPostBack)
            {
                string username = Session["username"].ToString();
                //string username = "AndrewTate";
                string name = GetDataSet($"SELECT * FROM Users WHERE username='{username}'")
                    .Tables[0].Rows[0]["firstname"].ToString();
                this.title.InnerText = $"ברוך הבא, {name}";
                string path;
                // שים תמונת פרופיל של המשתמש בתור תמונה לניווט באתר
                if (File.Exists(Server.MapPath($"/images/profiles/{username.ToLower()}.png")))
                    path = $"/images/profiles/{username.ToLower()}.png";
                else
                    path = $"/images/profiles/default.png";

                this.pfp.Src = path;
            }
        }
    }
}