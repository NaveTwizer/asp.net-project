using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Security;

namespace Nave_Project2.Pages.data.update
{
    public partial class update_users : System.Web.UI.Page
    {
        private bool DoesBranchExist(string code)
        {
            return GetDataSet($"SELECT * FROM BranchesTable WHERE BranchesCode='{code}'")
                .Tables[0].Rows.Count == 1;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
            this.feedback.InnerText = "";
            this.roles.DataBind();
            this.roles.Items.Clear();
            string val;
            string q = "SELECT * FROM RolesTable";
            foreach (DataRow row in GetDataSet(q).Tables[0].Rows)
            {
                val = row["RoleName"].ToString();
                this.roles.Items.Add(
                    new ListItem(val, val, true)
                );
            }
        }
        private (string, string, string, string, string, string, string, string, string) GetFormData()
        {
            string bday = Request.Form["birthday"].ToString();
            string start = Request.Form["start"].ToString();

            return (
                Request.Form["ID"],
                Request.Form["name"],
                //DateTime.ParseExact(bday, "dd/MM/yyyy", CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                DateTime.Parse(bday).ToString("dd/MM/yyyy"),
                this.gender.Value,
                //DateTime.ParseExact(start, "dd/MM/yyyy", CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                DateTime.Parse(start).ToString("dd/MM/yyyy"),
                Request.Form["addr"],
                Request.Form["phone"],
                Request.Form["code"],
                Request.Form["ctl00$ContentPlaceHolder1$roles"]
            );
        }
        private bool DoesWorkerExist(string id)
        {
            return GetDataSet($"SELECT * FROM WorkersTable WHERE WorkerID='{id}'")
                .Tables[0].Rows.Count == 1;
        }
        protected void CreateButton_Click(object sender, EventArgs e)
        {
            (string id, string name, string birthday, string sex, string start, string addr, string phone, string code, string role)
                = GetFormData();

            if (DoesWorkerExist(id))
            {
                this.feedback.InnerText = "עובד זה כבר קיים";
                return;
            }
            if (!DoesBranchExist(code))
            {
                this.feedback.InnerText = "קוד סניף זה אינו קיים";
                return;
            }
            string query = $"SELECT * FROM WorkersTable";
            DataSet ds = GetDataSet(query);
            DataRow row = ds.Tables[0].NewRow();

            row["WorkerID"] = id;
            row["WorkerName"] = name;
            row["WorkerBDate"] = birthday;
            row["WorkerGender"] = sex;
            row["WorkerStartDate"] = start;
            row["WorkerAddress"] = addr;
            row["WorkerPhoneNum"] = phone;
            row["BranchesCode"] = code;
            row["RoleName"] = role;

            ds.Tables[0].Rows.Add(row);
            SaveDatabase(query, ds);
            this.feedback.InnerText = "העובד נוסף בהצלחה";

        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            (string id, string name, string birthday, string sex, string start, string addr, string phone, string code, string role)
                = GetFormData();

            if (!DoesWorkerExist(id))
            {
                this.feedback.InnerText = "עובד זה אינו קיים";
                return;
            }
            if (!DoesBranchExist(code))
            {
                this.feedback.InnerText = "קוד סניף זה אינו קיים";
                return;
            }

            string query = $"SELECT * FROM WorkersTable";
            DataSet ds = GetDataSet(query);
            DataRow row = ds.Tables[0].Select($"WorkerID='{id}'").First();

            row["WorkerName"] = name;
            row["WorkerBDate"] = birthday;
            row["WorkerGender"] = sex;
            row["WorkerStartDate"] = start;
            row["WorkerAddress"] = addr;
            row["WorkerPhoneNum"] = phone;
            row["BranchesCode"] = code;
            row["RoleName"] = role;

            SaveDatabase(query, ds);
            this.feedback.InnerText = "העובד עודכן בהצלחה";
        }
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            string id = Request.Form["ID"];

            if (!DoesWorkerExist(id))
            {
                this.feedback.InnerText = "עובד זה אינו קיים";
                return;
            }
            string query = $"SELECT * FROM WorkersTable";
            DataSet ds = GetDataSet(query);
            DataRow row = ds.Tables[0].Select($"WorkerID='{id}'").First();

            row.Delete();
            SaveDatabase(query, ds);
            this.feedback.InnerText = "העובד נמחק בהצלחה";
        }
    }
}