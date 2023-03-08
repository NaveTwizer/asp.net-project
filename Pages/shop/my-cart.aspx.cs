using System;
using static Nave_Project2.Components.ShoppingCart;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Security;
using System.Web.UI;
using System.Data.OleDb;
using System.Diagnostics;
namespace Nave_Project2.Pages
{
    public partial class MyCart : System.Web.UI.Page
    {   // דף עגלת הקניות שלי
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        private string GetProductComponent(Components.Product product)
        {
            // מחזיר קלף מוצר המוצג על גבי המסך
            return $@"
            <div class='card'>
                {product.ImageTag}
                <h1>{product.Name}</h1>
                <span class='plus' data-input-id='Amount_{product.Id}'>+</span>
                <input type='text' class='AmountInputs' id='Amount_{product.Id}' value='{product.RequestedAmount}' />
                <span class='minus' data-input-id='Amount_{product.Id}'>-</span>
                <p class='price'>{product.PriceWithShekel}</p>
                <p>{product.Description}</p>
            </div>
            ";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectUnloggedUser(System.Web.HttpContext.Current);   
            if (!IsPostBack)
            {
                this.header.InnerText = $"הסל שלי - {MyShoppingCart.Items.Count} פריטים";
                foreach (Components.CartItem Item in MyShoppingCart.Items)
                {
                    this.CartDiv.InnerHtml += GetProductComponent(Item.Prod);
                }
                var total = MyShoppingCart.GetSubTotal();
                this.ToPay.InnerText = $"לתשלום: {total} שקלים";
            }
        }

        protected void PayButton_Click(object sender, EventArgs e)
        {
            //Response.Redirect("payment.aspx");
            string ProductName;
            int ProductAmount;
            string query;
            DataSet ds;

            // get latest invoice number
            OleDbConnection connection = new OleDbConnection(GetConnectionString());
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT MAX(invoice_number) FROM InvoicesTable", connection);
            int maxInvoiceNumber = (int)command.ExecuteScalar();
            connection.Close();
            maxInvoiceNumber += 1;
            foreach (var Item in MyShoppingCart.Items)
            {
                ProductName = Item.Prod.Name;
                ProductAmount = Item._RequestedAmount;
                query = "SELECT * FROM InvoicesTable";
                ds = GetDataSet(query);

                var now = DateTime.Now;
                DataRow row = ds.Tables[0].NewRow();

                row["invoice_date"] = $"{now.Day}/{now.Month}/{now.Year}";
                row["product"] = ProductName;
                row["quantity"] = ProductAmount;
                row["username"] = Session["username"].ToString();
                row["invoice_number"] = maxInvoiceNumber.ToString();


                ds.Tables[0].Rows.Add(row);
                SaveDatabase(query, ds);
            }

            string query2 = "SELECT * FROM ProductsTable";
            int NewAmount;
            DataSet ds2 = GetDataSet(query2);
            foreach (var Item in MyShoppingCart.Items)
            {
                foreach (DataRow row in ds2.Tables[0].Rows)
                    if (row["ProductName"].ToString().Equals(Item.Prod.Name))
                    {
                        int OldAmount = int.Parse(row["Amount"].ToString());
                        NewAmount = OldAmount - Item.Prod.RequestedAmount;
                        row["Amount"] = NewAmount;
                    }
            }
            SaveDatabase(query2, ds2);
            MyShoppingCart.Items.Clear();
            Response.Redirect("purchase-complete.aspx");
        }

        protected void ClearCartButton_Click(object sender, EventArgs e)
        {
            MyShoppingCart.Items.Clear();
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}