using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.utils.Database;


namespace Nave_Project2.Pages.RegularPages
{
    public partial class my_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["username"] as string))
            {
                Response.Redirect("~/Pages/RegularPages/403.aspx");
                Response.End();
            }
            string _username = Session["username"].ToString();
            DataRow row = GetDataSet($"SELECT * FROM Users WHERE username='{_username}'")
                .Tables[0].Rows[0];

            string _pswd = row["pswd"].ToString();
            string _name = row["firstname"].ToString();
            string last = row["lastname"].ToString();
            string addr = row["address"].ToString();
            string sex = row["gender"].ToString();
            string mail = row["mail"].ToString();
            string bday = row["birthday"].ToString();
            string birthday = DateTime.Parse(bday).ToString("dddd, dd MMMM yyyy");
            /*string lastname = row["lastname"].ToString();
            string _addr = row["address"].ToString();
            string _gender = row["gender"].ToString();
            string _mail = row["mail"].ToString();
            string _birthday = row["birthday"].ToString(); */

            this.username.InnerText = _username;
            this.password.InnerText = _pswd;
            this.name.InnerText = _name;
            this.lastname.InnerText = last;
            this.address.InnerText = addr;
            this.gender.InnerText = sex;
            this.email.InnerText = mail;
            this.birthday.InnerText = birthday;
        }
    }
}