using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using System.Net;
using System.Net.Sockets;
namespace Nave_Project2.Pages.auth
{
    public partial class login2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.error.Style.Add("display", "none");
        }
        public static string GetIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            //throw new Exception("No network adapters with an IPv4 address in the system!");
            return "Unknown";
        }
        private bool IsDeviceKnown(string ip, string username)
        {
            string q = $"SELECT * FROM Logins WHERE IPv4='{ip}' AND username='{username}'";
            return GetDataSet(q).Tables[0].Rows.Count != 0;
        }
        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string username = Request.Form["username"];
            string pswd = Request.Form["pswd"];

            string query = $"SELECT * FROM Users WHERE username='{username}' AND pswd='{pswd}'";
            DataSet ds = GetDataSet(query);

            bool IsLoggedIn = ds.Tables[0].Rows.Count == 1;

            if (!IsLoggedIn)
            {
                this.error.Style.Add("display", "block");
                return;
            }
            Session["username"] = username;


            // Record login from new device
            string ip = GetIP();
            if (!IsDeviceKnown(ip, username))
            {
                string q = "SELECT * FROM Logins";
                DataSet _ds = GetDataSet(q);
                DataRow row = _ds.Tables[0].NewRow();
                row["IPv4"] = ip;
                row["username"] = username;
                var now = DateTime.Now;
                row["LoggedAt"] = $"{now.Day}/{now.Month}/{now.Year} {now.Hour}:{now.Minute}:{now.Second}";

                _ds.Tables[0].Rows.Add(row);
                SaveDatabase(q, _ds);
            }
            if (username.ToLower() == "nave" && pswd == "admin")
            {
                Response.Redirect("~/Pages/admin/home.aspx", true);
                return;
            }
            Response.Redirect("~/Pages/LoggedHomePage.aspx", true);
        }
    }
}