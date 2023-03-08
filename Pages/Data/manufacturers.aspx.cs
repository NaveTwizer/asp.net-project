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
    public partial class manufacturers : System.Web.UI.Page
    {
        private string ParseRow(DataRow row, string attr)
        { // td מחזיר תגית 
            return $"<td>{row[attr]}</td>";
        }
        private string GetManuTable(DataSet ds)
        { // מחזיר טבלת יצרנים כמחרוזת
            string table = "<table><tr><td>שם יצרן</td><td>מדינה</td></tr>";
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                table += "<tr>";
                table += ParseRow(row, "ProductorName");
                table += ParseRow(row, "CountryName");
                table += "</tr>";
            }
            table += "</table>";
            return table;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
            if (!IsPostBack)
                this.TableDiv.InnerHtml = GetManuTable(GetDataSet("SELECT * FROM ProductorsTable"));

        }

        protected void SearchManuByName_Click(object sender, EventArgs e)
        { // חיפוש יצרן לפי שם
            string manu = Request.Form["manu"];
            string query = $"SELECT * FROM ProductorsTable WHERE ProductorName='{manu}'";
            this.TableDiv.InnerHtml = GetManuTable(GetDataSet(query));
        }
    }
}