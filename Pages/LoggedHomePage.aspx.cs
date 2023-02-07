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
                string name = GetDataSet($"SELECT * FROM Users WHERE username='{username}'")
                    .Tables[0].Rows[0]["firstname"].ToString();
                this.title.InnerText = $"ברוך הבא, {name}";
                DateTime today = DateTime.Today;
                string _today = $"{today.Day}/{today.Month}/{today.Year}";
                string query = $"SELECT * FROM DiscountsTable WHERE TodayDate='{_today}'";
                DataSet ds = GetDataSet(query);
                try
                {
                    DataRow _row = ds.Tables[0].Rows[0];
                }
                catch (IndexOutOfRangeException)
                {
                    this.discount3.InnerText = "אין כרגע כלום";
                    return;
                }
                DataRow row = ds.Tables[0].Rows[0];
                this.discount1.InnerText = $@"{row["product1"]} {row["discount1"]} אחוז";
                this.discount2.InnerText = $@"{row["product2"]} {row["discount2"]} אחוז";
                this.discount3.InnerText = $@"{row["product3"]} {row["discount3"]} אחוז";

                string path;
                if (File.Exists(Server.MapPath($"/images/profiles/{username.ToLower()}.png")))
                    path = $"/images/profiles/{username.ToLower()}.png";
                else
                    path = $"/images/profiles/default.png";

                this.pfp.Src = path;
            }
        }
    }
}