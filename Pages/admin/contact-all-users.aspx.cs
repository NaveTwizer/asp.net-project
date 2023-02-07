using System;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Email;
using static Nave_Project2.Utils.Security;

namespace Nave_Project2.Pages.admin
{
    public partial class contact_all_users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(System.Web.HttpContext.Current);
        }

        protected void SendMailToUsers_Click(object sender, EventArgs e)
        {

            string content = Request.Form["UsersContent"];
            string subject = Request.Form["UsersSubject"];
            string query = "SELECT * FROM Users";
            DataSet ds = GetDataSet(query);
            string EmailAddress;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                EmailAddress = row["mail"].ToString();
                try
                {
                    SendMail(EmailAddress, subject, content, "navenavejopa@gmail.com");
                } catch {}
            }
        }

        protected void SendMailToWorkers_Click(object sender, EventArgs e)
        {

        }
    }
}