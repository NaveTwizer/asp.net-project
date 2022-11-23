using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using static Nave_Project2.utils.Database; // CUSTOM CLASS

namespace Nave_Project2.Pages.RegularPages.Data
{
    public partial class workers : System.Web.UI.Page
    {
        public string ParseRow(DataRow r, string att)
        {
            return $"<td>{r[att]}</td>";
        }
        public string GetWorkers(DataSet ds)
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
            return all;
        }
        public string ListWorkers()
        {
            string query = "SELECT * FROM WorkersTable";
            DataSet ds = GetDataSet(query);
            return GetWorkers(ds);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                this.TableDiv.InnerHtml = search();
            } else
            {
                this.TableDiv.InnerHtml = ListWorkers();
            }
        }
        private string search()
        {
            string SearchQuery = Request.Form["SearchQuery"];
            string search = Request.Form["search"];

            string query = "";

            switch (search)
            {
                case "id":
                    query = $"SELECT * FROM WorkersTable WHERE WorkerID='{SearchQuery}'";
                    break;
                case "name":
                    query = $"SELECT * FROM WorkersTable WHERE WorkerName='{SearchQuery}'";
                    break;
                case "bdate":
                    // TODO
                    break;
                case "gender":
                    query = $"SELECT * FROM WorkersTable WHERE WorkerGender='{SearchQuery}'";
                    break;
                case "StartDte":
                    // TODO
                    break;
                case "address":
                    query = $"SELECT * FROM WorkersTable WHERE WorkerAddress LIKE'{SearchQuery}%'";
                    break;
                case "phone":
                    query = $"SELECT * FROM WorkersTable WHERE WorkerPhoneNum LIKE '{SearchQuery}%'";
                    break;
                case "code":
                    query = $"SELECT * FROM WorkersTable WHERE BranchesCode LIKE '{SearchQuery}%'";
                    break;
                case "role":
                    query = $"SELECT * FROM WorkersTable WHERE RoleName LIKE '{SearchQuery}%'";
                    break;
            }
            return GetWorkers(GetDataSet(query));
        }
    }
}