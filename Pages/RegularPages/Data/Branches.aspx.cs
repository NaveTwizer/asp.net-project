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
    public partial class Branches : System.Web.UI.Page
    {
        public string ParseRow(DataRow r, string att)
        {
            return $"<td>{r[att]}</td>";
        }
        public void GetBranches(DataSet ds)
        {
            string all = "<table border='1' align='center'>";
            all += "<tr><td>סניף</td><td>קוד סניף</td><td>כתובת</td><td>מספר טלפון</td></tr>";
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
            GetBranches(GetDataSet(q));
        }
    }
}