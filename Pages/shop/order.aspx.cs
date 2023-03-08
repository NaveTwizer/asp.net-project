using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Components.ShoppingCart;
using static Nave_Project2.Utils.Security;

namespace Nave_Project2.Pages
{
    public partial class order : System.Web.UI.Page
    {
        // טופס הזמנת מוצרים
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectUnloggedUser(HttpContext.Current);
            this.BadFeedback.InnerText = "";
            this.feedback.InnerText = "";
            if (!IsPostBack)
            {
                this.product.Items.Clear();
                DataSet ds = GetDataSet("SELECT * FROM ProductsTable ORDER BY ProductName ASC");
                string val;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    val = row["ProductName"].ToString();
                    this.product.Items.Add(
                        new ListItem(val, val, true)
                    );
                }
            }
            // POST בקשת 
            else
            {
                if (string.IsNullOrEmpty(Request.Form["Amount"]))
                {
                    this.BadFeedback.InnerText = "הכנס כמות מבוקשת";
                    return;
                }
                string prod = this.product.Value;
                string amount = Request.Form["amount"];
                DataSet ds = GetDataSet("SELECT * FROM ProductsTable");
                DataRow row = ds.Tables[0].Select($"ProductName='{prod}'").FirstOrDefault();
                int ExistingAmount = int.Parse(row["Amount"].ToString());
                if (int.Parse(amount) > ExistingAmount)
                {
                    this.BadFeedback.InnerText = "הזמנת יותר ממה שיש לנו במלאי";
                    return;
                }
                MyShoppingCart.AddItem(int.Parse(row["ProductCode"].ToString()), int.Parse(amount));
                this.feedback.InnerText = "המוצר נוסף בהצלחה";
            }
        }
    }
}