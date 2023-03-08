using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Security;

namespace Nave_Project2.Pages
{
    public partial class statistics : System.Web.UI.Page
    {
        private DataTable GetChartData()
        {
            // פעולה המחזירה טבלה על כמות הגלישות באתר בשבעה ימים האחרונים
            DataSet ds = GetDataSet("SELECT TOP 7 * FROM ViewsTable ORDER BY count DESC");
            return ds.Tables[0];
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.SalesPerMonthResult.InnerText = String.Empty;

            RedirectLoggedUserFromAdminePages(HttpContext.Current);
            if (!IsPostBack)
            {
                DataSet ds1 = GetDataSet("SELECT * FROM Users");
                DataSet ds2 = GetDataSet("SELECT * FROM ProductsTable");
                DataSet ds3 = GetDataSet("SELECT * FROM SalesTable");
                DataSet ds4 = GetDataSet("SELECT * FROM BranchesTable");
                DataSet ds5 = GetDataSet("SELECT * FROM WorkersTable");
                this.UsersDiv.InnerText = ds1.Tables[0].Rows.Count.ToString();
                this.ProductsDiv.InnerText = ds2.Tables[0].Rows.Count.ToString();
                this.SalesDiv.InnerText = ds3.Tables[0].Rows.Count.ToString();
                this.BranchesDiv.InnerText = ds4.Tables[0].Rows.Count.ToString();
                this.WorkersDiv.InnerText = ds5.Tables[0].Rows.Count.ToString();

                // get total visits of all days
                DataSet ds7 = GetDataSet("SELECT * FROM ViewsTable");
                int sum = 0;
                foreach (DataRow row in ds7.Tables[0].Rows)
                    sum += int.Parse(row["views"].ToString());

                this.TotalVisitsDiv.InnerText = sum.ToString();
                DataTable dt = GetChartData();
                Chart1.DataSource = dt;
                Chart1.DataBind();
                Chart1.Series["Series1"].XValueMember = "day_date";
                Chart1.Series["Series1"].YValueMembers = "views";

                string query6 = "SELECT * FROM Feedbacks";
                DataSet ds6 = GetDataSet(query6);
                int OpinionSum = 0;
                int AccessSum = 0;
                int QualitySum = 0;
                int DesignSum = 0;
                foreach (DataRow row in ds6.Tables[0].Rows)
                {
                    OpinionSum += int.Parse(row["opinion"].ToString());
                    AccessSum += int.Parse(row["access"].ToString());
                    QualitySum += int.Parse(row["quality"].ToString());
                    DesignSum += int.Parse(row["design"].ToString());
                }
                int count = ds6.Tables[0].Rows.Count;

                double avg1 = (double)OpinionSum / (double)count;
                double avg2 = (double)AccessSum / (double)count;
                double avg3 = (double)QualitySum / (double)count;
                double avg4 = (double)DesignSum / (double)count;
                avg1 = Math.Round(avg1, 2);
                avg2 = Math.Round(avg2, 2);
                avg3 = Math.Round(avg3, 2);
                avg4 = Math.Round(avg4, 2);

                this.OpinionAverage.InnerText = $"ממוצע דעה כללית: {avg1}";
                this.AccessAverage.InnerText = $"ממוצע גישה באתר: {avg2}";
                this.QualityAverage.InnerText = $"ממוצע איכות המוצרים: {avg3}";
                this.DesignAverage.InnerText = $"ממוצע עיצוב האתר: {avg4}";
                this.Total.InnerText = $"סך משובים במאגר המידע: {count}";
            }
        }

        protected void SearchMonthlySalesButton_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM SalesTable";
            string RequestedMonth = Request.Form["month"];
            DataSet ds = GetDataSet(query);
            string val;
            int count = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                val = row["SaleDate"].ToString();
                string month = $"{val[3]}{val[4]}";

                if (month.Equals(RequestedMonth))
                    count++;
            }
            //this.SalesPerMonthResult.InnerText = $"סך מכירות לחודש זה: {count}";
        }
    }
}