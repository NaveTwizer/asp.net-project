using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Email;

namespace Nave_Project2.Pages
{
    public partial class registration : System.Web.UI.Page
    {
        private bool DoesUsernameExist(string username)
        {
            return GetDataSet($"SELECT * FROM Users WHERE username='{username}'")
                .Tables[0].Rows.Count != 0;
        }
        private bool DoesEmailExist(string email)
        {
            return GetDataSet($"SELECT * FROM Users WHERE mail='{email}'")
                .Tables[0].Rows.Count != 0;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UsernameError.InnerText = "";
            this.EmailError.InnerText = "";
            if (IsPostBack)
            {
                string username = Request.Form["username"];
                if (DoesUsernameExist(username))
                {
                    this.UsernameError.InnerText = "שם משתמש זה תפוס";
                    return;
                }
                string email = Request.Form["email"];
                if (DoesEmailExist(email))
                {
                    this.EmailError.InnerText = "אימייל זה כבר נמצא בשימוש";
                    return;
                }
                string pw = Request.Form["pswd"];
                string name = Request.Form["name"];
                string lastname = Request.Form["lastname"];
                string address = Request.Form["address"];
                string gender = Request.Form["gender"];
                object bday = DateTime.Parse(Request.Form["birthday"]);
                //Alert(bday.ToString());

                string query = "SELECT * FROM Users";
                DataSet ds = GetDataSet(query);

                DataRow row = ds.Tables[0].NewRow();
                row["username"] = username;
                row["pswd"] = pw;
                row["firstname"] = name;
                row["lastname"] = lastname;
                row["address"] = address;
                row["gender"] = gender;
                row["mail"] = email;
                row["birthday"] = bday;
                var now = DateTime.Now;
                row["CreatedAt"] = $"{now.Day}/{now.Month}/{now.Year}";

                ds.Tables[0].Rows.Add(row);
                SaveDatabase(query, ds);
                this.GoodFeedback.InnerText = "המשתמש נוצר בהצלחה!";


                string WelcomeMessage = $@"
ברוך הבא אל האתר שלנו! מעכשיו תוכל לגלוש באתר בפרטים שהזנת.
במידה ותשכח את סיסמתך, תקבל סיסמה חדשה למייל הזה.
";
                SendMail(email, $"ברוך הבא, {username}", WelcomeMessage, "navenavejopa@gmail.com");
            }
        }
    }
}