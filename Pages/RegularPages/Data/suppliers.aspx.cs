using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using static Nave_Project2.utils.Database; // CUSTOM CLASS

namespace Nave_Project2.Pages.RegularPages.Data
{
    public partial class suppliers : System.Web.UI.Page
    {
        public string ParseRow(DataRow r, string att)
        {
            return $"<td>{r[att]}</td>";
        }
        public void GetSuppliers(DataSet ds)
        {
            string all = "<table>";
            all += "<tr><td>שם ספק</td><td>קוד ספק</td><td>כתובת</td><td>טלפון</td><td>מייל</td></tr>";

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                all += "<tr>";
                all += ParseRow(r, "ProviderName");
                all += ParseRow(r, "ProviderCode");
                all += ParseRow(r, "ProviderAdress");
                all += ParseRow(r, "Phone");
                all += ParseRow(r, "Mail");
                all += "</tr>";
            }
            all += "</table>";
            Response.Write(all);
        }
        public void ListSuppliers()
        {
            string query = "SELECT * FROM ProvidersTable\nORDER BY ProviderName ASC;";
            GetSuppliers(GetDataSet(query));
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}