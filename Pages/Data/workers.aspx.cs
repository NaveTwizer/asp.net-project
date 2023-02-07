using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Security;

namespace Nave_Project2.Pages.data
{
    public partial class workers : System.Web.UI.Page
    {
        private string ParseRow(DataRow row, string attr)
        {
            return $"<td>{row[attr]}</td>";
        }
        private string GetWorkersTable(DataSet ds)
        {
            string table = "<table><tr><td>תעודת זהות</td><td>שם עובד</td><td>תאריך לידה</td><td>מין</td><td>תאריך התחלת עבודה</td><td>כתובת</td><td>טלפון</td><td>קוד סניף</td><td>תפקיד</td></tr>";
            string[] values = { "WorkerID", "WorkerName", "WorkerBDate", "WorkerGender", "WorkerStartDate", "WorkerAddress", "WorkerPhoneNum", "BranchesCode", "RoleName" };
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                table += "<tr>";
                foreach (string value in values)
                    table += ParseRow(row, value);
                table += "</tr>";
            }
            table += "</table>";
            return table;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
            if (!IsPostBack)
                this.TableDiv.InnerHtml = GetWorkersTable(GetDataSet("SELECT * FROM WorkersTable"));
        }

        protected void SearchWorker_Click(object sender, EventArgs e)
        {
            string worker = Request.Form["worker"];
            string query = $"SELECT * FROM WorkersTable WHERE WorkerName LIKE '%{worker}%' OR WorkerID LIKE '%{worker}%'";
            this.TableDiv.InnerHtml = GetWorkersTable(GetDataSet(query));
        }
    }
}