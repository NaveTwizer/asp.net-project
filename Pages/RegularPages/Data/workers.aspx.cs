using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using static Nave_Project2.Pages.MasterPages.Database; // CUSTOM CLASS

namespace Nave_Project2.Pages.RegularPages.Data
{
    public partial class workers : System.Web.UI.Page
    {
        public string ParseRow(DataRow r, string att)
        {
            return $"<td>{r[att]}</td>";
        }
        public void GetWorkers(DataSet ds)
        {
            string all = "<table>";
            all += "<tr><td>תז עובד</td><td>שם עובד</td><td>תאריך לידה</td><td>מין</td><td>תאריך התחלת עבודה</td><td>כתובת</td><td>טלפון</td><td>קוד סניף</td><td>תפקיד</td></tr>";

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                all += "<tr>";
                all += ParseRow(row, "WorkerID");
                all += ParseRow(row, "WorkerName");
                all += ParseRow(row, "WorkerBDate");
                all += ParseRow(row, "WorkerGender");
                all += ParseRow(row, "WorkerStartDate");
                all += ParseRow(row, "WorkerAddress");
                all += ParseRow(row, "WorkerPhoneNum");
                all += ParseRow(row, "BranchesCode");
                all += ParseRow(row, "RoleName");
                all += "</tr>";
            }
            all += "</table>";
            Response.Write(all);
        }
        public void ListWorkers()
        {
            string query = "SELECT * FROM WorkersTable";
            DataSet ds = GetDataSet(query);
            GetWorkers(ds);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}