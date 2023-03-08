using System;
using System.Diagnostics;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Components.ShoppingCart;
using static Nave_Project2.Utils.Security;
namespace Nave_Project2.Pages
{
    public partial class payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM InvoicesTable";
            DataSet ds = GetDataSet(query);

            DataRow row = ds.Tables[0].NewRow();
            var now = DateTime.Now;
            row["invoice_date"] = $"{now.Day}/{now.Month}/{now.Year}";
            row["product"] = "Nigger";
            row["quantity"] = "12";
            row["username"] = "Ahmed";
            row["invoice_number"] = 5;

            ds.Tables[0].Rows.Add(row);
            SaveDatabase(query, ds);


            if (!IsPostBack)
            {
                RedirectUnloggedUser(HttpContext.Current);
                var total = MyShoppingCart.GetSubTotal();
                this.PayButton.Text = $"לתשלום - {total}";
                this.YearSelect.DataBind();
                this.YearSelect.Items.Clear();

                int CurrentYear = DateTime.Now.Year;
                // הצג 16 שנים לתוקף הכרטיס
                for (int i = CurrentYear; i < CurrentYear + 16; ++i)
                    this.YearSelect.Items.Add(
                        new ListItem(i.ToString(), i.ToString(), true)
                    );
            }
        }
        protected void PayButton_Click(object sender, EventArgs e)
        {
            // כאן כביכול אנו אמורים לחייב את הכרטיס של המשתמש
            
        }

        protected void PayButton_Click1(object sender, EventArgs e)
        {
       
        }
    }
}