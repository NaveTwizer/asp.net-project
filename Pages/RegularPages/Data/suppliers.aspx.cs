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
        public string GetSuppliers(DataSet ds)
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
            return all;
        }
        public string ListSuppliers()
        {
            string query = "SELECT * FROM ProvidersTable\nORDER BY ProviderName ASC;";
            return GetSuppliers(GetDataSet(query));
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                this.TableDiv.InnerHtml = search();
            } else
            {
                this.TableDiv.InnerHtml = ListSuppliers();
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
                    query = $"SELECT * FROM ProvidersTable WHERE ProviderCode='{SearchQuery}'";
                    break;
                case "name":
                    query = $"SELECT * FROM ProvidersTable WHERE ProviderName LIKE '{SearchQuery}%'";
                    break;
                case "address":
                    query = $"SELECT * FROM ProvidersTable WHERE ProviderAdress LIKE '{SearchQuery}%'";
                    break;
                case "phone":
                    query = $"SELECT * FROM ProvidersTable WHERE Phone='{SearchQuery}'";
                    break;
                case "mail":
                    query = $"SELECT * FROM ProvidersTable WHERE Mail LIKE '{SearchQuery}%'";
                    break;
            }
            return GetSuppliers(GetDataSet(query));
        }
    }
}