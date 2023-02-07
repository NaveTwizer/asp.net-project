using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Components.ShoppingCart;
namespace Nave_Project2.Pages
{
    public partial class payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var total = MyShoppingCart.GetSubTotal();
                this.Pay_Button.Text = $"לתשלום - {total}";
                this.YearSelect.DataBind();
                this.YearSelect.Items.Clear();

                int CurrentYear = DateTime.Now.Year;
                for (int i = CurrentYear; i < CurrentYear + 16; ++i)
                {
                    this.YearSelect.Items.Add(
                        new ListItem(i.ToString(), i.ToString(), true)
                    );
                }
            }
        }
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }

        protected void Pay_Button_Click(object sender, EventArgs e)
        {
            string q1 = "SELECT * FROM PurchaseTable";
            DataSet ds1 = GetDataSet(q1);
            string Products = "";
            foreach (var Item in MyShoppingCart.Items)
            {
                Products += $"{Item.Prod.RequestedAmount} {Item.Prod.Name}";
                Products += "\n";
            }
            DataRow row = ds1.Tables[0].NewRow();
            row["username"] = Session["username"];
            var now = DateTime.Now;
            row["PurchaseDate"] = $"{now.Day}/{now.Month}/{now.Year}";
            row["Products"] = Products;
            row["Total"] = MyShoppingCart.GetSubTotal().ToString();

            ds1.Tables[0].Rows.Add(row);
            SaveDatabase(q1, ds1);
            Response.Redirect("purchase-complete.aspx");
        }
    }
}