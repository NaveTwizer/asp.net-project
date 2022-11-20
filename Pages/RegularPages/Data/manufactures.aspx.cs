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
    public partial class manufactures : System.Web.UI.Page
    {
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        public string ParseRow(DataRow r, string att)
        {
            return $"<td>{r[att]}</td>";
        }
        public string GetManufactures(DataSet ds)
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
            return all;
        }
        public string ListManufactures()
        {
            string query = "SELECT * FROM ProductorsTable\nORDER BY ProductorName ASC;";
            DataSet ds = GetDataSet(query);
            return GetManufactures(ds);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string html = search();
                if (html.Length == 54)
                {
                    this.TableDiv.InnerHtml = "<h1>Found nothing</h1>";
                } else
                {
                    this.TableDiv.InnerHtml = html;
                }
            } else
            {
                this.TableDiv.InnerHtml = ListManufactures();
            }
        }
        private string search()
        {
            string SearchQuery = Request.Form["searchQuery"];
            string ElementToSearch = Request.Form["search"];
            if (ElementToSearch == "name")
            {
                string query = $"SELECT * FROM ProductorsTable WHERE ProductorName LIKE '{SearchQuery}%'";
                return GetManufactures(GetDataSet(query));
            }
            if (ElementToSearch == "country")
            {
                string query = $"SELECT * FROM ProductorsTable WHERE CountryName LIKE '%{SearchQuery}%'";
                return GetManufactures(GetDataSet(query));
            }
            return "<h1>Found nothing</h1>";
        }
    }
}