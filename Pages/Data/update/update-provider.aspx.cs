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
    public partial class update_provider : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.feedback.InnerText = "";
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
        }
        private bool DoesProviderExist(string Code)
        {
            return GetDataSet($"SELECT * FROM ProvidersTable WHERE ProviderCode='{Code}'")
                .Tables[0].Rows.Count == 1;
        }

        private (string, string, string, string, string) GetFormData()
        {
            return (
                Request.Form["code"],
                Request.Form["name"],
                Request.Form["addr"],
                Request.Form["phone"],
                Request.Form["email"]
            );
        }
        protected void CreateButton_Click(object sender, EventArgs e)
        {
            (string code, string name, string addr, string phone, string email)
                = GetFormData();

            if (DoesProviderExist(code))
            {
                this.feedback.InnerText = "קוד ספק זה כבר קיים";
                return;
            }
            string query = "SELECT * FROM ProvidersTable";
            DataSet ds = GetDataSet(query);
            DataRow row = ds.Tables[0].NewRow();

            row["ProviderCode"] = code;
            row["ProviderName"] = name;
            row["ProviderAdress"] = addr;
            row["Phone"] = phone;
            row["Mail"] = email;

            ds.Tables[0].Rows.Add(row);
            SaveDatabase(query, ds);
            this.feedback.InnerText = "הספק נשמר בהצלחה";
        }
        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            (string code, string name, string addr, string phone, string email)
                = GetFormData();

            if (!DoesProviderExist(code))
            {
                this.feedback.InnerText = "קוד ספק זה אינו קיים";
                return;
            }
            string query = "SELECT * FROM ProvidersTable";
            DataSet ds = GetDataSet(query);
            DataRow row = ds.Tables[0].Select($"ProviderCode='{code}'").First();

            row["ProviderCode"] = code;
            row["ProviderName"] = name;
            row["ProviderAdress"] = addr;
            row["Phone"] = phone;
            row["Mail"] = email;
            SaveDatabase(query, ds);
            this.feedback.InnerText = "הספק עודכן בהצלחה";
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            (string code, string name, string addr, string phone, string email)
                = GetFormData();

            if (!DoesProviderExist(code))
            {
                this.feedback.InnerText = "קוד ספק זה אינו קיים";
                return;
            }

            // Delete all related products first
            string q = $"SELECT * FROM ProductsTable WHERE ProviderCode='{code}'";
            DataSet set = GetDataSet(q);
            foreach (DataRow r in set.Tables[0].Rows)
                r.Delete();
            SaveDatabase(q, set);


            string query = "SELECT * FROM ProvidersTable";
            DataSet ds = GetDataSet(query);
            DataRow row = ds.Tables[0].Select($"ProviderCode='{code}'").First();
            row.Delete();
            SaveDatabase(query, ds);
            this.feedback.InnerText = "הספק נמחק בהצלחה";
        }
    }
}