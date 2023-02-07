using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Nave_Project2.Utils.Email;
using static Nave_Project2.Utils.Database;
using System.Data;

namespace Nave_Project2.Pages.profile
{
    public partial class forgot_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GoodFeedback.InnerText = String.Empty;
            this.feedback.InnerText = String.Empty;
        }
        private string GetNewPassword(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private string GetBodyMessage(string password)
        {
            return $@"
שלום,
אתה מקבל מייל זה משום שביקשת סיסמה חדשה לאתר שלנו
סיסמתך החדשה תהיה {password}
במידה ולא אתה ביקשת שחזור סיסמה, צור איתנו קשר.
בברכה,
הנהלת הסופר
";
        }
        private bool DoesMailExist(string mail)
        {
            return GetDataSet($"SELECT * FROM Users WHERE mail='{mail}'")
                .Tables[0].Rows.Count != 0;
        }
        protected void SendPasswordButton_Click(object sender, EventArgs e)
        {
            string mail = Request.Form["mail"];
            if (!DoesMailExist(mail))
            {
                this.feedback.InnerText = "מייל זה לא משויך לשום פרופיל קיים";
                return;
            }
            string query = $"SELECT * FROM Users";
            DataSet ds = GetDataSet(query);
            string pw = GetNewPassword(10);
            DataRow row = ds.Tables[0].Select($"mail='{mail}'").First();
            row["pswd"] = pw;
            SaveDatabase(query, ds);
            SendMail(mail, "איפוס סיסמה", GetBodyMessage(pw), "navenavejopa@gmail.com");
            this.GoodFeedback.InnerText = "שלחנו לך מייל!";
        }
    }
}