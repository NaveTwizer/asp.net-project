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
    public partial class sales : System.Web.UI.Page
    {
        public string ParseRow(DataRow r, string att)
        {
            return $"<td>{r[att]}</td>";
        }
        public string GetSales(DataSet dataset)
        {
            string all = "<table>";
            all += "<tr><td>קוד מכירה</td><td>תאריך</td><td>קוד סניף</td><td>תז עובד</td></tr>";

            foreach (DataRow r in dataset.Tables[0].Rows)
            {
                all += "<tr>";
                all += ParseRow(r, "SaleCode");
                all += ParseRow(r, "SaleDate");
                all += ParseRow(r, "BranchCode");
                all += ParseRow(r, "WorkerID");
                all += "<tr>";
            }
            all += "</table>";
            return all;
        }
        public string ListSales()
        {
            string query = "SELECT * FROM SalesTable\nORDER BY SaleDate DESC;";
            DataSet ds = GetDataSet(query);
            return GetSales(ds);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                this.TableDiv.InnerHtml = search();
            } else
            {
                this.TableDiv.InnerHtml = ListSales();
            }
        }
        private string search()
        {
            string SearchQuery = Request.Form["SearchQuery"];
            string ElementToSearch = Request.Form["search"];

            string query = "";
            switch (ElementToSearch)
            {
                case "code":
                    query = $"SELECT * FROM SalesTable WHERE SaleCode='{SearchQuery}'";
                    break;
                case "date":
                    // TODO
                    break;
                case "BranchCode":
                    query = $"SELECT * FROM SalesTable WHERE BranchCode='{SearchQuery}'";
                    break;
                case "WorkerId":
                    query = $"SELECT * FROM SalesTable WHERE WorkerID='{SearchQuery}'";
                    break;
            }
            return GetSales(GetDataSet(query));
        }
    }
}