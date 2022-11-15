using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using static Nave_Project2.Pages.MasterPages.Database; // CUSTOM CLASS

namespace Nave_Project2.Pages.RegularPages.Data
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public void GetUsers(DataSet ds)
        {
            string all = "<table border='1' align='center'>";
            all += "<tr><td>Username</td><td>Password</td><td>First Name</td><td>Last Name</td><td>Address</td><td>Gender</td><td>Mail</td><td>Birthday</td></tr>";
            
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                all += "<tr>";
                all += "<td>" + row["username"] + "</td>";
                all += "<td>" + row["pswd"] + "</td>";
                all += "<td>" + row["firstname"] + "</td>";
                all += "<td>" + row["lastname"] + "</td>";
                all += "<td>" + row["address"] + "</td>";
                all += "<td>" + row["gender"] + "</td>";
                all += "<td>" + row["mail"] + "</td>";
                all += "<td>" + row["birthday"] + "</td>";
                all += "<tr>";
            }
            all += "</table>";
            Response.Write(all);
        }
        public void ListUsers()
        {
            string sql = "SELECT * FROM Users\nORDER BY username ASC;";
            GetUsers(GetDataSet(sql));
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}