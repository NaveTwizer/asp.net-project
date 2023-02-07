using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Security;

namespace Nave_Project2.Pages.data.update
{
    public partial class update_branch : System.Web.UI.Page
    {
        private bool DoesCodeExist(string code)
        {
            string q = $"SELECT * FROM BranchesTable WHERE BranchesCode='{code}'";
            return GetDataSet(q).Tables[0].Rows.Count == 1;
        }
        private (string, string, string, string) GetFormData()
        {
            // code, name, addr, phone
            return (
                Request.Form["code"].ToString(),
                Request.Form["name"].ToString(),
                Request.Form["address"].ToString(),
                Request.Form["phone"].ToString()
            );
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
            if (IsPostBack)
            {
                this.codeError.InnerText = "";
                this.feedback.InnerText = "";
            }
        }
        protected void CreateButton_Click(object sender, EventArgs e)
        {
            (string code, string name, string addr, string phone) = GetFormData();
            if (DoesCodeExist(code))
            {
                this.codeError.InnerText = "קוד סניף זה כבר קיים";
                return;
            }
            string query = "SELECT * FROM BranchesTable";
            DataSet ds = GetDataSet(query);
            DataRow NewRow = ds.Tables[0].NewRow();
            NewRow["BranchesCode"] = code;
            NewRow["BranchesName"] = name;
            NewRow["BranchesAddress"] = addr;
            NewRow["BranchesPhone"] = phone;

            ds.Tables[0].Rows.Add(NewRow);
            SaveDatabase(query, ds);
            this.feedback.InnerText = "הסניף נוצר בהצלחה!";
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            (string code, string name, string addr, string phone) = GetFormData();
            if (!DoesCodeExist(code))
            {
                this.codeError.InnerText = "קוד סניף זה אינו קיים";
                return;
            }

            string query = "SELECT * FROM BranchesTable";
            DataSet ds = GetDataSet(query);
            string where = $"BranchesCode='{code}'";
            DataRow row = ds.Tables[0].Select(where).FirstOrDefault();
            row["BranchesCode"] = code;
            row["BranchesName"] = name;
            row["BranchesAddress"] = addr;
            row["BranchesPhone"] = phone;
            SaveDatabase("SELECT * FROM BranchesTable", ds);
            this.feedback.InnerText = "הסניף עודכן בהצלחה!";
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            string code = Request.Form["code"];
            if (!DoesCodeExist(code))
            {
                this.codeError.InnerText = "קוד סניף זה אינו קיים";
                return;
            }
            string query = "SELECT * FROM BranchesTable";
            DataSet ds = GetDataSet(query);
            string where = $"BranchesCode='{code}'";
            DataRow row = ds.Tables[0].Select(where).FirstOrDefault();
            row.Delete();
            SaveDatabase(query, ds);
            this.feedback.InnerText = "הסניף נמחק בהצלחה!";
        }
    }
}