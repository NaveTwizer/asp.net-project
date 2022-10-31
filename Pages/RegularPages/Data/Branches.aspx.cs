using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
namespace Nave_Project2.Pages.RegularPages.Data
{
    public partial class Branches : System.Web.UI.Page
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
        public void GetBranches(DataSet ds)
        {
            string all = "<table border='1' align='center'>";
            all += "<tr><td>Branch</td><td>Branch Code</td><td>Address</td><td>Phone</td></tr>";
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                all += "<tr>";
                all += ParseRow(row, "BranchesName");
                all += ParseRow(row, "BranchesCode");
                all += ParseRow(row, "BranchesAddress");
                all += ParseRow(row, "BranchesPhone");
                all += "</tr>";
            }
            all += "</table>";
            Response.Write(all);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void ListBranches()
        {
            string q = "SELECT * FROM BranchesTable\nORDER BY BranchesName ASC;";
            GetBranches(
                GetDataSet(q)
            );
        }
    }
}