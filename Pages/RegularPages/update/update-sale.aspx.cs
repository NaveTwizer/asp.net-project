using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Nave_Project2.utils.Database;
using System.Data;

namespace Nave_Project2.Pages.RegularPages.update
{
    public partial class update_sale : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private bool DoesExist(string SaleCode)
        {
            return GetDataSet($"SELECT * FROM SalesTable WHERE SaleCode='{SaleCode}'")
                .Tables[0].Rows.Count != 0;
        }
        private bool DoesBranchExist(string BranchCode)
        {
            return GetDataSet($"SELECT * FROM BranchesTable WHERE BranchesCode='{BranchCode}'")
                .Tables[0].Rows.Count != 0;
        }
        private bool DoesWorkerExist(string WorkerID)
        {
            return GetDataSet($"SELECT * FROM WorkersTable WHERE WorkerID='{WorkerID}'")
                .Tables[0].Rows.Count != 0;
        }
        protected void Update_Button_Click(object sender, EventArgs e)
        {
            this.BadFeedback.InnerText = "";
            this.GoodFeedback.InnerText = "";
            string code = Request.Form["code"];
            if (!DoesExist(code))
            {
                this.BadFeedback.InnerText = "מכירה אינה קיימת";
                return;
            }
            string SaleDate = DateTime.Parse(Request.Form["date"].ToString()).ToShortDateString();
            string BranchCode = Request.Form["BranchCode"];
            string WorkerID = Request.Form["WorkerId"];
            string sql = "SELECT * FROM SalesTable";
            
            try
            {
                DataSet ds = GetDataSet(sql);

                string where = $"SaleCode='{code}'";
                DataRow row = ds.Tables[0].Select(where).FirstOrDefault();

                // update
                row["SaleCode"] = code;
                row["SaleDate"] = SaleDate;
                row["BranchCode"] = BranchCode;
                row["WorkerID"] = WorkerID;

                // save
                SaveDatabase(sql, ds);

                // output
                this.GoodFeedback.InnerText = "הנתונים נשמרו בהצלחה!";
            }
            catch (Exception ex)
            {
                this.BadFeedback.InnerText = "משהו השתבש";
            }
        }

        protected void Create_Button_Click(object sender, EventArgs e)
        {
            this.BadFeedback.InnerText = "";
            this.GoodFeedback.InnerText = "";
            string code = Request.Form["code"];
            if (DoesExist(code))
            {
                this.BadFeedback.InnerText = "מכירה עם קוד זה כבר נמצאת במערכת";
                return;
            }
            string SaleDate = DateTime.Parse(Request.Form["date"].ToString()).ToShortDateString();
            string BranchCode = Request.Form["BranchCode"];
            string WorkerID = Request.Form["WorkerId"];

            if (!DoesBranchExist(BranchCode))
            {
                this.BadFeedback.InnerText = "סניף זה אינו קיים!";
                return;
            }
            if (!DoesWorkerExist(WorkerID))
            {
                this.BadFeedback.InnerText = "עובד זה אינו קיים!";
                return;
            }

            string query = "SELECT * FROM SalesTable";
            DataSet ds = GetDataSet(query);

            DataRow row = ds.Tables[0].NewRow();
            row["SaleCode"] = code;
            row["SaleDate"] = SaleDate;
            row["BranchCode"] = BranchCode;
            row["WorkerID"] = WorkerID;

            ds.Tables[0].Rows.Add(row);
            SaveDatabase(query, ds);
            this.GoodFeedback.InnerText = "המכירה נוספה בהצלחה";
        }

        protected void Delete_Button_Click(object sender, EventArgs e)
        {
            this.BadFeedback.InnerText = "";
            this.GoodFeedback.InnerText = "";
            string code = Request.Form["code"];
            if (!DoesExist(code))
            {
                this.BadFeedback.InnerText = "המכירה אינה קיימת";
                return;
            }
            string query = "SELECT * FROM SalesTable";
            try
            {
                DataSet ds = GetDataSet(query);
                string where = $"SaleCode='{code}'";
                DataRow[] rows = ds.Tables[0].Select(where);

                // delete
                foreach (DataRow row in rows)
                    row.Delete();

                // save
                SaveDatabase(query, ds);
                this.GoodFeedback.InnerText = "המכירה נמחקה בהצלחה";
            }
            catch (Exception ex)
            {
                this.BadFeedback.InnerText = "משהו השתבש";
            }
        }
    }
}