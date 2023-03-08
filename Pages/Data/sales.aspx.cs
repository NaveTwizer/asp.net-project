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
    public partial class sales : System.Web.UI.Page
    {   // מחלקת דף המכירות
        private string ParseRow(DataRow r, string attr)
        {
            return $"<td>{r[attr]}</td>";
        }
        private string GetSalesTable(DataSet ds)
        {
            string table = "<table><tr><td>קוד מכירה</td><td>תאריך</td><td>קוד סניף</td><td>תז עובד</td></tr>";
            string[] values = { "SaleCode", "SaleDate", "BranchCode", "WorkerID" };
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
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
            if (!IsPostBack)
            {
                this.TableDiv.InnerHtml = GetSalesTable(GetDataSet("SELECT * FROM SalesTable"));
            }
        }

        protected void SearchSaleByCode_Click(object sender, EventArgs e)
        {
            string code = Request.Form["code"];
            this.TableDiv.InnerHtml = GetSalesTable(GetDataSet($"SELECT * FROM SalesTable WHERE SaleCode='{code}'"));
        }
    }
}