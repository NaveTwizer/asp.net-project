using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Security;
using static Nave_Project2.Utils.Database;

namespace Nave_Project2.Pages.admin.queries
{
    public partial class workers_per_branch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
            if (!IsPostBack)
            {
                string query = "SELECT * FROM WorkersPerBranch";
                DataSet ds = GetDataSet(query);
                string table = "<table><tr><td>שם סניף</td><td>סך עובדים</td></tr>";
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    table += "<tr>";
                    table += "<td>" + row["BranchesName"].ToString() + "</td>";
                    table += "<td>" + row["count"].ToString() + "</td>";
                    table += "</tr>";
                }
                table += "</table>";
                this.TableDiv.InnerHtml = table;
            }
        }
    }
}