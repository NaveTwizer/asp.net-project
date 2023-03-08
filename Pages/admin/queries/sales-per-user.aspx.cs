using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Security;
namespace Nave_Project2.Pages.admin.queries
{
    public partial class sales_per_user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
            if (!IsPostBack)
            {
                string query1 = "SELECT * FROM Users";
                DataSet ds1 = GetDataSet(query1);
                string query2;
                string username;
                string table = "<table><tr><td>שם משתמש</td><td>סך רכישות</td></tr>";
                foreach (DataRow row1 in ds1.Tables[0].Rows)
                {
                    username = row1["username"].ToString();
                    query2 = $"SELECT DISTINCT(invoice_number) FROM InvoicesTable WHERE username='{username}'";
                    DataSet ds2 = GetDataSet(query2);
                    table += "<tr>";
                    table += $"<td>{username}</td>";
                    table += "<td>" + ds2.Tables[0].Rows.Count.ToString() + "</td>";
                    table += "</tr>";
                }
                table += "</table>";
                this.TableDiv.InnerHtml = table;
            }
        }
    }
}