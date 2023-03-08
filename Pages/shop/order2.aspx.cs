using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Security;

namespace Nave_Project2.Pages.shop
{
    public partial class order2 : System.Web.UI.Page
    {
        private string ParseRow (DataRow row, string attr)
        {
            return $"<td>{row[attr]}</td>";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string query = "SELECT * FROM ProductsTable";
                DataSet ds = GetDataSet(query: query);
                string html = "<table id='tbl'><tr style='font-size:25px;'><td>שם מוצר</td><td>תמונת מוצר</td><td>כמות</td><td>מחיר ליחידה</td></tr>";
                string src = "src";
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    html += "<tr>";
                    html += ParseRow(row, "ProductName");
                    html += $"<td><img alt='product' src='{row[src]}' height='200' width='200' /></td>";
                    string ProductName = row["ProductName"].ToString();
                    html += $"<td><input type='number' class='inputs' min='0' value='0' name='{ProductName}'></td>";
                    html += ParseRow(row, "Price");
                    html += "<td id='td1' />";
                    html += "</tr>";
                }
                html += "</table>";
                this.OrderSection.InnerHtml = html;
                
            }
        }
        protected void OrderProduct(object sender, EventArgs e)
        {
            this.OrderSection.InnerHtml = "<h1>Hi</h1>";
        }
    }
}