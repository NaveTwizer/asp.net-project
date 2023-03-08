using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Security;

namespace Nave_Project2.Pages.shop.Invoices
{
    public partial class invoice : System.Web.UI.Page
    {   // דף קבלה ספציפית
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectUnloggedUser(HttpContext.Current);

            string username = Session["username"].ToString();
            string RequestedInvoice = Page.RouteData.Values["invoice"].ToString();
            this.Title = $"קבלה מספר {RequestedInvoice}";
            this.title2.InnerText = $"קבלה מספר {RequestedInvoice}";
            
            string table = "<table><tr><td>קוד פריט</td><td>שם פריט</td><td>מחיר</td><td>כמות</td><td>סהכ</td></tr>";

            string query1 = $"SELECT * FROM InvoicesTable WHERE username='{username}' AND invoice_number={RequestedInvoice}";
            DataSet ds1 = GetDataSet(query1);
            try
            {
                string _d = ds1.Tables[0].Rows[0]["Invoice_date"].ToString();
            }
            catch (Exception)
            {
                this.PurchaseDate.InnerText = "קבלה זו אינה נמצאה במערכת או שהיא אינה שייכת לך";
                return;
            }
            string d = ds1.Tables[0].Rows[0]["Invoice_date"].ToString();
            string CustomerUsername = ds1.Tables[0].Rows[0]["username"].ToString();
            this.title.InnerText = $"לכבוד {CustomerUsername}";
            this.PurchaseDate.InnerText = $"תאריך רכישה: {d}";
            string query2 = "SELECT * FROM ProductsTable";
            DataSet ds2 = GetDataSet(query2);


            string ProductName;
            string quantity;

            string PricePerUnit;
            string ProductCode;
            Decimal TotalBill = 0;
            foreach (DataRow row in ds1.Tables[0].Rows)
            {
                ProductName = row["product"].ToString();
                quantity = row["quantity"].ToString();

                table += "<tr>";
                DataRow ProductRow = ds2.Tables[0].Select($"ProductName='{ProductName}'").First();

                PricePerUnit = ProductRow["Price"].ToString();
                ProductCode = ProductRow["ProductCode"].ToString();

                table += $"<td>{ProductCode}</td>";
                table += $"<td>{ProductName}</td>";
                table += $"<td>{PricePerUnit}</td>";
                table += $"<td>{quantity}</td>";
                Decimal total = Decimal.Parse(quantity) * Decimal.Parse(PricePerUnit);
                total = Math.Round(total, 2); // total - total for each product
                table += $"<td>{total}</td>";
                table += "</tr>";
                TotalBill += total;
            }
            table += "<tr class='second-last-row'><td class='no-border'>&nbsp;</td></tr>";
            table += "<tr class='final-row'><td class='no-border'>לתשלום</td><td class='no-border'>&nbsp;</td><td class='no-border'>&nbsp;</td><td class='no-border'>&nbsp;</td>";
            table += $"<td>{TotalBill}</td></tr>";
            table += "</table>";
            this.TableDiv.InnerHtml = table;
        }
    }
}