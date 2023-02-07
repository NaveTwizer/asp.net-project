using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Security;

namespace Nave_Project2.Pages.data
{
    public partial class users : System.Web.UI.Page
    {
        private string ParseRow(DataRow r, string attr)
        {
            return $"<td>{r[attr]}</td>";
        }
        private string GetUsersTable(DataSet ds)
        {
            string table = "<table><tr><td>שם משתמש</td><td>סיסמה</td><td>שם פרטי</td><td>משפחה</td><td>כתובת</td><td>מין</td><td>כתובת דואל</td><td>תאריך לידה</td></tr>";

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                table += "<tr>";
                table += ParseRow(row, "username");
                table += ParseRow(row, "pswd");
                table += ParseRow(row, "firstname");
                table += ParseRow(row, "lastname");
                table += ParseRow(row, "address");
                table += ParseRow(row, "gender");
                table += ParseRow(row, "mail");
                table += ParseRow(row, "birthday");
                table += "</tr>";
            }
            table += "</table>";
            return table;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
            if (!IsPostBack)
            {
                string query = "SELECT * FROM Users";
                this.UsersDiv.InnerHtml = GetUsersTable(GetDataSet(query));
            }
        }

        protected void UsernameByNameSearch_Click(object sender, EventArgs e)
        {
            string username = Request.Form["username"];
            string query = $"SELECT * FROM Users WHERE username='{username}'";
            this.UsersDiv.InnerHtml = GetUsersTable(GetDataSet(query));
        }


        protected void Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = this.Sort.SelectedValue;

            string query = $"SELECT * FROM Users ORDER BY {val} ASC";
            this.UsersDiv.InnerHtml = GetUsersTable(GetDataSet(query:query));
        }

        protected void CountUsersByGender_Click(object sender, EventArgs e)
        {
            string RequestedGender = Request.Form["gender"];
            string query = $"SELECT * FROM Users WHERE gender='{RequestedGender}'";
            this.Result.Value = GetDataSet(query).Tables[0].Rows.Count.ToString();
        }
    }
}