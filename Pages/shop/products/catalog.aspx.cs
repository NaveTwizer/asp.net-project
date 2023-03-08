using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;

namespace Nave_Project2.Pages.shop
{
    public partial class catalog : System.Web.UI.Page
    {   // דף קטלוג המוצרים
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = GetDataSet("SELECT * FROM ProductsTable ORDER BY ProductName ASC");
            // יצירת טבלת המוצרים
            if (!IsPostBack)
            {
                string table = "<table><tr><td>שם המוצר</td><td>דף פרטים</td></tr>";
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    table += "<tr>";

                    string ProductName = (string)row["ProductName"];
                    table += $"<td>{ProductName}</td>";
                    string link = $"<a target='_blank' class='links' href='/Pages/shop/products/{ProductName}'>לחץ כאן</a>";
                    table += "<td>" + link + "</td>";
                    table += "</tr>";
                }
                this.CatalogTableDiv.InnerHtml = table;
            }
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {   // חיפוש מוצר לפי שם והעברת הלקוח לדף המתאים
            string SearchedProduct = Request.Form["product"];
            Response.Redirect($"/Pages/shop/products/{SearchedProduct}");
        }
    }
}