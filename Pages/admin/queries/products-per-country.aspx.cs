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
    public partial class products_per_country : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
            if (!IsPostBack)
            {
                string query = "SELECT * FROM ProductsPerCountry";
                DataSet ds = GetDataSet(query);
                string table = "<table><tr><td>שם מדינה</td><td>סך מוצרים</td></tr>";
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    table += "<tr>";
                    table += "<td>" + row["CountryName"].ToString() + "</td>";
                    table += "<td>" + row["count"].ToString() + "</td>";
                    table += "</tr>";
                }
                table += "</table>";
                this.TableDiv.InnerHtml = table;
            }
        }
    }
}