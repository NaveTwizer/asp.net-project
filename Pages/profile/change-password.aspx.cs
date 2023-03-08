using System;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Security;
namespace Nave_Project2.Pages.profile
{
    public partial class change_password : System.Web.UI.Page
    {   // דף שינוי סיסמה
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectUnloggedUser(System.Web.HttpContext.Current);
            this.BadFeedback.InnerText = String.Empty;
            this.GoodFeedback.InnerText = String.Empty;
        }
        private (string, string) GetFormData()
        {
            return (
                Request.Form["CurrentPassword"],
                Request.Form["NewPassword"]
            );
        }
        protected void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            (string current, string NewPassword) = GetFormData();
            string username = Session["username"].ToString();
            DataSet ds = GetDataSet($"SELECT * FROM Users WHERE username='{username}' AND pswd='{current}'");
            if (ds.Tables[0].Rows.Count == 0)
            {
                this.BadFeedback.InnerText = "סיסמתך אינה נכונה";
                return;
            }
            DataRow row = ds.Tables[0].Rows[0];
            row["pswd"] = NewPassword;
            SaveDatabase("SELECT * FROM Users", ds);
            this.GoodFeedback.InnerText = "הסיסמה שונתה בהצלחה";
        }
    }
}