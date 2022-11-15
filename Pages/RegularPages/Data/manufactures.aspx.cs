using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using static Nave_Project2.Pages.MasterPages.Database; // CUSTOM CLASS
namespace Nave_Project2.Pages.RegularPages.Data
{
    public partial class manufactures : System.Web.UI.Page
    {
        public string ParseRow(DataRow r, string att)
        {
            return $"<td>{r[att]}</td>";
        }
        public void GetManufactures(DataSet ds)
        {
            string all = "<table>";
            all += "<tr><td>שם יצרן</td><td>מדינה</td></tr>";
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                all += "<tr>";
                all += ParseRow(r, "ProductorName");
                all += ParseRow(r, "CountryName");
                all += "</tr>";
            }
            all += "</table>";
            Response.Write(all);
        }
        public void ListManufactures()
        {
            string query = "SELECT * FROM ProductorsTable\nORDER BY ProductorName ASC;";
            DataSet ds = GetDataSet(query);
            GetManufactures(ds);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}