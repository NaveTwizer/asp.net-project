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
    public partial class products : System.Web.UI.Page
    {
        private string ParseRow(DataRow row, string attr)
        {
            return $"<td>{row[attr]}</td>";
        }
        private string GetProductsTable(DataSet ds)
        {
            string table = "<table><tr><td>קוד מוצר</td><td>שם מוצר</td><td>מחלקה</td><td>יצרן</td><td>קוד ספק</td><td>תיאור</td><td>מחיר</td><td>כמות</td></tr>";
            string[] values = { "ProductCode", "ProductName", "DepName", "ProductorName", "ProviderCode", "ProductDesc", "Price", "Amount" };
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
                this.TableDiv.InnerHtml = GetProductsTable(GetDataSet("SELECT * FROM ProductsTable"));
            }
        }

        protected void SearchProductByName_Click(object sender, EventArgs e)
        {
            string product = Request.Form["product"];
            string query = $"SELECT * FROM ProductsTable WHERE ProductName='{product}'";
            DataSet ds = GetDataSet(query);
            this.TableDiv.InnerHtml = GetProductsTable(ds);
        }
    }
}