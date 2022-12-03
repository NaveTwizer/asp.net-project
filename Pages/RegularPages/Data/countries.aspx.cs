using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using static Nave_Project2.utils.Database; // CUSTOM CLASS

namespace Nave_Project2.Pages.RegularPages.Data
{
    public partial class countries : System.Web.UI.Page
    {
        public string ParseRow(DataRow r, string att)
        {
            return $"<td>{r[att]}</td>";
        }
        public string GetCountries(DataSet ds)
        {
            string all = "<table>";
            all += "<tr><td>שם מדינה</td><td>מספר סניפים</td></tr>";

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                all += "<tr>";
                all += ParseRow(row, "CountryName");
                all += ParseRow(row, "BranchesNum");
                all += "</tr>";
            }
            all += "</table>";
            return all;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                this.TableDiv.InnerHtml = click();
            } else
            {
                this.TableDiv.InnerHtml = ListCountries();
            }
        }
        public string ListCountries()
        {
            string q = "SELECT * FROM CountriesTable\nORDER BY CountryName ASC;";
            return GetCountries(GetDataSet(q));
        }
        public string click()
        {
            string SearchQuery = Request.Form["searchQuery"];
            string ElementToSearch = Request.Form["search"];

            if (ElementToSearch.Equals("country"))
            {
                string query = $"SELECT * FROM CountriesTable WHERE CountryName LIKE '{SearchQuery}%'";
                return GetCountries(GetDataSet(query));
            }
            if (ElementToSearch.Equals("branchesNum"))
            {
                string query = $"SELECT * FROM CountriesTable WHERE BranchesNum LIKE '{SearchQuery}%'";
                return GetCountries(GetDataSet(query));
            }
            return "";
        }
    }
}