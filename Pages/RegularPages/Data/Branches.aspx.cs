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
    public partial class Branches : System.Web.UI.Page
    {
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        public string ParseRow(DataRow r, string att)
        {
            return $"<td>{r[att]}</td>";
        }
        public string GetBranches(DataSet ds)
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
            return all;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            /*this.Select.DataBind();
            string q = $"SELECT * FROM BranchesTable";
            DataSet ds = GetDataSet(q);
            int count = 0;
            string value;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                value = row["BranchesName"].ToString();
                this.Select.Items.Insert(count, value);
            } */
            if (IsPostBack)
            {
                this.TableDiv.InnerHtml = click();
            } else
            {
                this.TableDiv.InnerHtml = ListBranches();
            }
        }
        public string ListBranches()
        {
            string q = "SELECT * FROM BranchesTable\nORDER BY BranchesName ASC;";
            return GetBranches(GetDataSet(q));
        }

        protected void Search_Click(object sender, EventArgs e)
        {

        }
        private string click()
        {
            string SearchQuery = Request.Form["searchQuery"];
            string ElementToSearch = Request.Form["search"];
            
            if (ElementToSearch.Equals("code"))
            {
                string query = $"SELECT * FROM BranchesTable WHERE BranchesCode LIKE '{SearchQuery}%'";
                DataSet ds = GetDataSet(query);
                return GetBranches(ds);
            }
            if (ElementToSearch.Equals("name"))
            {
                string query = $"SELECT * FROM BranchesTable WHERE BranchesName LIKE '{SearchQuery}%'";
                return GetBranches(GetDataSet(query));
            }
            if (ElementToSearch.Equals("address"))
            {
                string query = $"SELECT * FROM BranchesTable WHERE BranchesAddress LIKE '{SearchQuery}%'";
                return GetBranches(GetDataSet(query));
            }
            if (ElementToSearch.Equals("phone"))
            {
                string query = $"SELECT * FROM BranchesTable WHERE BranchesPhone LIKE '{SearchQuery}%'";
                return GetBranches(GetDataSet(query));
            }
            return "";
        }
    }
}