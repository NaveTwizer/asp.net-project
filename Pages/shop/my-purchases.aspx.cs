using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using static Nave_Project2.Utils.Security;
using static Nave_Project2.Utils.Database;
namespace Nave_Project2.Pages
{
    public partial class my_purchases : System.Web.UI.Page
    {   // דף הרכישות שלי
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectUnloggedUser(System.Web.HttpContext.Current);

            string username = Session["username"].ToString();
            string query = $"SELECT DISTINCT invoice_number FROM InvoicesTable WHERE username='{username}'"; // מחפש רכישות של המשתמש
            DataSet ds = GetDataSet(query);
            string table = "<table><tr><td>מספר חשבונית</td><td>דף פירוט</td></tr>";
            string link;
            // יצירת טבלה עם כל הרכישות ודף פירוט על כל רכישה
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                table += "<tr>";
                string InvoiceId = row["invoice_number"].ToString();
                link = $"/Pages/shop/Invoices/{InvoiceId}";
                table += $"<td>{InvoiceId}</td>";
                table += $"<td><a href='{link}' class='links' target='_blank'>לחץ כאן</a></td>";
                table += "</tr>";
            }
            table += "</table>";
            this.TableDiv.InnerHtml = table;
        }
    }
}