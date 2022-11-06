using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;



namespace Nave_Project2.Pages.RegularPages.Data
{
    public partial class countries : System.Web.UI.Page
    {
        public string GetConnectionString()
        {
            //return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Nave_Project2\Nave_Project2\App_Data\Naves_Project_Ina_final.mdb;Persist Security Info=True";
            return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Naves_Project_Ina_final.mdb;Persist Security Info=True";
        }
        public DataSet GetDataSet(string query)
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = new OleDbConnection(GetConnectionString());
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            conn.Open();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }
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



        public void ExecuteJS(string text)
        {
            //ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('Hello World');", true);
            ClientScript.RegisterStartupScript(GetType(), "hwa", $"alert({text})", true);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public void ListCountries()
        {
            string q = "SELECT * FROM CountriesTable\nORDER BY CountryName ASC;";
            GetCountries(
                GetDataSet(q)
            );
        }
        
    }
}