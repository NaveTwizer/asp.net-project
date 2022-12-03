using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Nave_Project2.utils.Database;
using System.Data;

namespace Nave_Project2.Pages.RegularPages
{
    public partial class payment : System.Web.UI.Page
    {
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                //Response.Redirect("403.aspx", true);
                //return;
            }
            //var Total = Request.Cookies["total"].Value;
            int CurrentYear = DateTime.Now.Year;
            this.YearSelect.DataBind();
            string value;
            for (int year = CurrentYear; year < CurrentYear + 16; year++)
            {
                value = year.ToString();
                this.YearSelect.Items.Add(new ListItem(value, value));
            }
            if (IsPostBack)
            {
                string product = Base64Decode(Session["product"].ToString());
                string query = "SELECT * FROM ProductsTable";
                DataSet ds = GetDataSet(query);

                DataRow row = ds.Tables[0].Select($"ProductName='{product}'").FirstOrDefault();

                int ExistingAmount = int.Parse(row["Amount"].ToString());
                int amount = int.Parse(Session["amount"].ToString());
                int NewAmount = ExistingAmount - amount;

                row["Amount"] = NewAmount.ToString();
                SaveDatabase(query, ds);
                Response.Redirect("purchase-complete.aspx");
            }
        }
    }
}