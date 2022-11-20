using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using static Nave_Project2.utils.Database; // CUSTOM CLASS

namespace Nave_Project2.Pages.RegularPages.DataTables
{
    public partial class Products : System.Web.UI.Page
    {
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                this.TableDiv.InnerHtml = search();
            } else
            {
                this.TableDiv.InnerHtml = ListOfProducts();
            }
        }
        private string ParseRow(DataRow r, string att)
        {
            return $"<td>{r[att]}</td>";
        }
        private string GetProducts(DataSet ds)
        {
            string all = "<table border='1' align='center' id='table1' runat='server'>";
            all += "<tr><td>שם מוצר</td><td>קוד מוצר</td><td>שם מחלקה</td><td>שם יצרן</td><td>קוד ספק</td><td>תיאור מוצר</td><td>מחיר</td><td>כמות</td></tr>";
            foreach (DataRow row  in ds.Tables[0].Rows)
            {
                all += "<tr>";
                all += ParseRow(row, "ProductName");
                all += ParseRow(row, "ProductCode");
                all += ParseRow(row, "DepName");
                all += ParseRow(row, "ProductorName");
                all += ParseRow(row, "ProviderCode");
                all += ParseRow(row, "ProductDesc");
                all += ParseRow(row, "Price");
                all += ParseRow(row, "Amount");
                all += "<tr>";
            }
            all += "</table>";
            return all;
        }
        private string ListOfProducts()
        {
            string sql = "SELECT * FROM ProductsTable\nORDER BY ProductName ASC;";
            DataSet ds = GetDataSet(sql);
            string all = GetProducts(ds);
            return all;
        }
        private string search()
        {
            string SearchQuery = Request.Form["SearchQuery"];
            string ElementToSearch = Request.Form["search"];

            string query;
            switch (ElementToSearch)
            {
                case "code":
                    query = $"SELECT * FROM ProductsTable WHERE ProductCode LIKE '%{SearchQuery}%'";
                    break;
                case "name":
                    query = $"SELECT * FROM ProductsTable WHERE ProductName LIKE '%{SearchQuery}%'";
                    break;
                case "dep":
                    query = $"SELECT * FROM ProductsTable WHERE DepName LIKE '%{SearchQuery}%'";
                    break;
                case "productor":
                    query = $"SELECT * FROM ProductsTable WHERE ProductorName LIKE '%{SearchQuery}%'";
                    break;
                case "ProviderCode":
                    query = $"SELECT * FROM ProductsTable WHERE ProviderCode LIKE '%{SearchQuery}%'";
                    break;
                case "description":
                    query = $"SELECT * FROM ProductsTable WHERE ProductDesc LIKE '%{SearchQuery}%'";
                    break;
                case "price":
                    query = $"SELECT * FROM ProductsTable WHERE Price LIKE '%{SearchQuery}%'";
                    break;
                case "amount":
                    query = $"SELECT * FROM ProductsTable WHERE Amount LIKE '%{SearchQuery}%'";
                    break;
                default:
                    return "<h1>Found nothing</h1>";
            }
            return GetProducts(GetDataSet(query));
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            this.TableDiv.InnerHtml = ListOfProducts();
        }
    }
}