using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;


namespace Nave_Project2.Pages
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DateTime today = DateTime.Today;
                string _today = $"{today.Day}/{today.Month}/{today.Year}";
                string query = $"SELECT * FROM DiscountsTable WHERE TodayDate='{_today}'";
                DataSet ds = GetDataSet(query);
                try
                {
                    DataRow _row = ds.Tables[0].Rows[0];
                } catch(IndexOutOfRangeException)
                {
                    this.discount3.InnerText = "אין כרגע כלום";
                    return;
                }
                DataRow row = ds.Tables[0].Rows[0];
                this.discount1.InnerText = $@"{row["product1"]} {row["discount1"]} אחוז";
                this.discount2.InnerText = $@"{row["product2"]} {row["discount2"]} אחוז";
                this.discount3.InnerText = $@"{row["product3"]} {row["discount3"]} אחוז";
            }
        }
    }
}