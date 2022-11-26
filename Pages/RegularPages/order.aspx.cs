using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.utils.Database;

namespace Nave_Project2.Pages.RegularPages
{
    public partial class order : System.Web.UI.Page
    {
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.SelectProduct.DataBind();
            DataSet ds = GetDataSet("SELECT * FROM ProductsTable");
            int count = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string value = row["ProductName"].ToString();
                this.SelectProduct.Items.Insert(count, new ListItem(value, value, true));
                count++;
            }

            this.GoodFeedback.InnerText = "";
            this.BadFeedback.InnerText = "";
            // HANDLE POST REQUEST
            if (IsPostBack)
            {
                string product = this.SelectProduct.Value;
                int amount = int.Parse(Request.Form["amount"].ToString());
                DataRow row = ds.Tables[0].Select($"ProductName='{product}'").FirstOrDefault();
                int ProductAmount = int.Parse(row["Amount"].ToString());
                

                if (amount > ProductAmount)
                {
                    this.BadFeedback.InnerText = "אנו מצטערים, הזמנת יותר ממה שיש לנו במלאי";
                    return;
                }

                DataSet UserDataSet = GetDataSet("SELECT * FROM Users");
                string username = Session["username"].ToString();
                DataRow UserRow = UserDataSet.Tables[0].Select($"username='{username}'").FirstOrDefault();
                string address = UserRow["address"].ToString();

                int PricePerSingle = int.Parse(row["Price"].ToString()); // מחיר מוצר ליחידה אחת

                int PriceToPay = PricePerSingle * amount;
                //this.GoodFeedback.InnerText = "סך התשלום:" + " " + PriceToPay.ToString() + "\n" + "מיד תועבר לדף התשלום";
                //Response.AppendHeader("Refresh", $"10;url=payment.aspx?total={PriceToPay}");
                Response.Redirect($"payment.aspx?total={PriceToPay}");
                //this.GoodFeedback.InnerText = "שלחנו" + " " + amount.ToString() + " " + product + " " + "אל" + " " + address;
            }
        }
    }
}