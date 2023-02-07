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
    public partial class providers : System.Web.UI.Page
    {
        private string ParseRow(DataRow r, string attr)
        {
            return $"<td>{r[attr]}</td>";
        }
        private string GetProvidersTable(DataSet ds)
        {
            string table = "<table><tr><td>קוד ספק</td><td>שם ספק</td><td>כתובת</td><td>טלפון</td><td>מייל</td></tr>";
            string[] values = { "ProviderCode", "ProviderName", "ProviderAdress", "Phone", "Mail" };
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
                this.TableDiv.InnerHtml = GetProvidersTable(GetDataSet("SELECT * FROM ProvidersTable"));
            }
        }

        protected void SearchProviderByName_Click(object sender, EventArgs e)
        {
            string provider = Request.Form["provider"];
            this.TableDiv.InnerHtml = GetProvidersTable(GetDataSet($"SELECT * FROM ProvidersTable WHERE ProviderName LIKE '%{provider}%'"));
        }
    }
}