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
    public partial class purchase_complete : System.Web.UI.Page
    {
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("403.aspx", true);
                return;
            }
            
            string query = "SELECT * FROM [purchases]";
            DataSet ds = GetDataSet(query);
            DataRow row = ds.Tables[0].NewRow();
            string product = Base64Decode(Session["product"].ToString());
            DataRow ProductRow = GetDataSet($"SELECT * FROM ProductsTable")
                .Tables[0].Select($"ProductName='{product}'").FirstOrDefault();

            int amount = int.Parse(Session["amount"].ToString());
            var now = DateTime.Now;
            int price = int.Parse(ProductRow["Price"].ToString());
            int paid = price * amount;

            row["product"] = product;
            row["amount"] = amount.ToString();
            row["username"] = Session["username"].ToString();
            row["PurchaseTime"] = $"{now.Day}/{now.Month}/{now.Year}";
            row["paid"] = paid.ToString();

            ds.Tables[0].Rows.Add(row);
            SaveDatabase(query, ds);
        }
    }
}