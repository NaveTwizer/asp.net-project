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
    public partial class my_purchases : System.Web.UI.Page
    {
        public string ParseRow(DataRow r, string att)
        {
            return $"<td>{r[att]}</td>";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("403.aspx", true);
                return;
            }
            string username = Session["username"].ToString();
            string query = $"SELECT * FROM purchases WHERE username='{username} ORDER BY PurchaseTime DESC'";
            string table = "<table><tr><td>שולם</td><td>תאריך</td><td>מוצר</td></tr>";
            DataSet ds = GetDataSet(query);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                table += "<tr>";
                table += ParseRow(row, "paid");
                table += ParseRow(row, "PurchaseTime");
                table += ParseRow(row, "product");
                table += "</tr>";
            }
            table += "</table>";
            this.TableDiv.InnerHtml = table;
        }
    }
}