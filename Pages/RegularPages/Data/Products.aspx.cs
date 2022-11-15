using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using static Nave_Project2.Pages.MasterPages.Database; // CUSTOM CLASS

namespace Nave_Project2.Pages.RegularPages.DataTables
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string ParseRow(DataRow r, string att)
        {
            return $"<td>{r[att]}</td>";
        }
        public string GetProducts(DataSet ds)
        {
            string all = "<table border='1' align='center' id='table1' runat='server'>";
            all += "<tr><td>Product Name</td><td>Product Code</td><td>Department Name</td><td>Productor Name</td><td>Provider Code</td><td>Product Description</td><td>Price</td><td>Amount</td></tr>";
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
        public void ListOfProducts()
        {
            string sql = "SELECT * FROM ProductsTable\nORDER BY ProductName ASC;";
            DataSet ds = GetDataSet(sql);
            string all = GetProducts(ds);
            Response.Write(all);
        }
    }
}