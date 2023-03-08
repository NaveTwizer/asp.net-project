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
    public partial class branches : System.Web.UI.Page
    {
        private string ParseRow(DataRow row, string attr)
        {
            return $"<td>{row[attr]}</td>";
        }
        private string GetBranchesTable(DataSet ds)
        {
            // בונה טבלת סניפים ומציג אותה על המסך
            string table = "<table><tr><td>קוד סניף</td><td>שם סניף</td><td>כתובת</td><td>טלפון</td></tr>";
            string[] values = { "BranchesCode", "BranchesName", "BranchesAddress", "BranchesPhone"};
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                table += "<tr>";
                foreach (string value in values)
                    table += ParseRow(row, value);
                table += "</tr>";
            }
            table += "</table>";
            return table;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(HttpContext.Current); // redirect non admins
            if (!IsPostBack)
            {
                this.BranchesDiv.InnerHtml = GetBranchesTable(GetDataSet("SELECT * FROM BranchesTable"));
            }
        }
    }
}