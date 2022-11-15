using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using static Nave_Project2.Pages.MasterPages.Database; // CUSTOM CLASS

namespace Nave_Project2.Pages.RegularPages.Data
{
    public partial class countries : System.Web.UI.Page
    {
        public string ParseRow(DataRow r, string att)
        {
            return $"<td>{r[att]}</td>";
        }
        public void GetCountries(DataSet ds)
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
            Response.Write(all);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public void ListCountries()
        {
            string q = "SELECT * FROM CountriesTable\nORDER BY CountryName ASC;";
            GetCountries(GetDataSet(q));
        }
    }
}