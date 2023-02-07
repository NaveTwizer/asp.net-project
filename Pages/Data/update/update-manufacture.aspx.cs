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
    public partial class update_manufacture : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
            this.feedback.InnerText = "";
        }
        private bool DoesManuExist(string name)
        {
            return GetDataSet($"SELECT * FROM ProductorsTable WHERE ProductorName='{name}'")
                .Tables[0].Rows.Count == 1;
        }
        private bool DoesCountryExist(string country)
        {
            return GetDataSet($"SELECT * FROM CountriesTable WHERE CountryName='{country}'")
                .Tables[0].Rows.Count == 1;
        }

        private (string, string) GetFormData()
        {
            return (
                this.Request.Form["name"].ToString(),
                this.Request.Form["country"].ToString()
            );
        }
        protected void CreateButton_Click(object sender, EventArgs e)
        {
            (string name, string country) = GetFormData();
            if (DoesManuExist(name))
            {
                this.feedback.InnerText = "יצרן זה כבר קיים!";
                return;
            }
            if (!DoesCountryExist(country))
            {
                this.feedback.InnerText = "מדינה זו אינה קיימת";
                return;
            }
            string query = "SELECT * FROM ProductorsTable";
            DataSet ds = GetDataSet(query);
            DataRow row = ds.Tables[0].NewRow();
            row["ProductorName"] = name;
            row["CountryName"] = country;
            ds.Tables[0].Rows.Add(row);
            SaveDatabase(query, ds);
            this.feedback.InnerText = "היצרן נוסף בהצלחה";
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            (string name, string country) = GetFormData();
            if (!DoesManuExist(name))
            {
                this.feedback.InnerText = "יצרן זה אינו קיים";
                return;
            }
            if (!DoesCountryExist(country))
            {
                this.feedback.InnerText = "מדינה זו אינה קיימת";
                return;
            }
            string query = "SELECT * FROM ProductorsTable";
            DataSet ds = GetDataSet(query);
            DataRow row = ds.Tables[0].Select($"ProductorName='{name}'").First();
            row["CountryName"] = country;
            SaveDatabase(query, ds);
            this.feedback.InnerText = "היצרן עודכן בהצלחה";
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            (string name, string _country) = GetFormData();
            if (!DoesManuExist(name))
            {
                this.feedback.InnerText = "יצרן זה אינו קיים";
                return;
            }
            // delete products related to manu
            string q = $"SELECT * FROM ProductsTable WHERE ProductorName='{name}'";
            DataSet set = GetDataSet(q);
            foreach (DataRow r in set.Tables[0].Rows)
            {
                r.Delete();
            }
            SaveDatabase(q, set);
            string query = "SELECT * FROM ProductorsTable";
            DataSet ds = GetDataSet(query);
            DataRow row = ds.Tables[0].Select($"ProductorName='{name}'").First();
            row.Delete();
            SaveDatabase(query, ds);
            this.feedback.InnerText = "היצרן ומוצריו נמחקו בהצלחה";
        }
    }
}