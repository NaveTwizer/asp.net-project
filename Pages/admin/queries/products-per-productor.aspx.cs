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
    public partial class products_per_productor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
            if (!IsPostBack)
            {
                string query = "SELECT * FROM ProductsPerProductor";
                DataSet ds = GetDataSet(query);
                string table = "<table><tr><td>שם יצרן</td><td>סך מוצרים</td></tr>";
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    table += "<tr>";
                    table += "<td>" + row["ProductorName"].ToString() + "</td>";
                    table += "<td>" + row["count"].ToString() + "</td>";
                    table += "</tr>";
                }
                table += "</table>";
                this.TableDiv.InnerHtml = table;
            }
        }
    }
}