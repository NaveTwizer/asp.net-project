using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Security;

namespace Nave_Project2.Pages.admin
{
    public partial class add_discounts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
            if (!IsPostBack)
            {
                string query = "SELECT * FROM ProductsTable";
                DataSet ds = GetDataSet(query:query);
                string val;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    val = row["ProductName"].ToString();
                    this.product1.Items.Add(new ListItem(val, val, true));
                    this.product2.Items.Add(new ListItem(val, val, true));
                    this.product3.Items.Add(new ListItem(val, val, true));
                }
            }
        }

        protected void ConfirmButton_Click(object sender, EventArgs e)
        {
            string product1 = this.product1.Value;
            string product2 = this.product2.Value;
            string product3 = this.product3.Value;
            string discount1 = Request.Form["discount1"];
            string discount2 = Request.Form["discount2"];
            string discount3 = Request.Form["discount3"];

            string query = $"SELECT * FROM DiscountsTable";
            DataSet ds = GetDataSet(query);
            DataRow row = ds.Tables[0].NewRow();
            var today = DateTime.Today;
            row["TodayDate"] = $"{today.Day}/{today.Month}/{today.Year}";
            row["product1"] = product1;
            row["product2"] = product2;
            row["product3"] = product3;
            row["discount1"] = discount1;
            row["discount2"] = discount2;
            row["discount3"] = discount3;
            ds.Tables[0].Rows.Add(row);
            SaveDatabase(query, ds);
            this.feedback.InnerText = "ההנחות נשמרו בהצלחה!";
        }
    }
}