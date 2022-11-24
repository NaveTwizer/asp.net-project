using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.utils.Database; // CUSTOM CLASS

namespace Nave_Project2.Pages.RegularPages.update
{
    public partial class update_manufactor : System.Web.UI.Page
    {
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool DoesExist(string name)
        {
            string query = $"SELECT * FROM ProductorsTable WHERE ProductorName='{name}'";
            return GetDataSet(query).Tables[0].Rows.Count != 0;
        }
        private bool DoesCountryExist(string name)
        {
            return GetDataSet($"SELECT * FROM CountriesTable WHERE CountryName='{name}'")
                .Tables[0].Rows.Count != 0;
        }
        protected void CreateButton_Click(object sender, EventArgs e)
        {
            this.BadFeedback.InnerText = "";
            this.GoodFeedback.InnerText = "";
            string name = Request.Form["name"];
            string country = Request.Form["country"];
            if (DoesExist(name))
            {
                this.BadFeedback.InnerText = "יצרן עם שם זה כבר קיים!";
                return;
            }
            if (!DoesCountryExist(country))
            {
                this.BadFeedback.InnerText = "מדינה זו אינה קיימת";
                return;
            }
            string query = "SELECT * FROM ProductorsTable";
            
            DataSet ds = GetDataSet(query);

            DataRow row = ds.Tables[0].NewRow();
            row["ProductorName"] = name;
            row["CountryName"] = country;
            ds.Tables[0].Rows.Add(row);

            SaveDatabase(query, ds);
            this.GoodFeedback.InnerText = "הסניף נשמר בהצלחה!";
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            this.BadFeedback.InnerText = "";
            this.GoodFeedback.InnerText = "";
            string name = Request.Form["name"];
            string country = Request.Form["country"];
            if (!DoesExist(name))
            {
                this.BadFeedback.InnerText = "יצרן זה אינו קיים";
                return;
            }
            if (!DoesCountryExist(country))
            {
                this.BadFeedback.InnerText = "מדינה זו אינה קיימת";
                return;
            }
            string sql = "SELECT * FROM ProductorsTable";
            try
            {
                DataSet ds = GetDataSet(sql);

                string where = $"ProductorName='{name}'";
                DataRow row = ds.Tables[0].Select(where).FirstOrDefault();

                row["ProductorName"] = name;
                row["CountryName"] = country;


                SaveDatabase(sql, ds);
                this.GoodFeedback.InnerText = "הנתונים נשמרו בהצלחה!";
            }
            catch (Exception ex)
            {
                this.BadFeedback.InnerText = "משהו השתבש";
            }
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            this.BadFeedback.InnerText = "";
            this.GoodFeedback.InnerText = "";
            string name = Request.Form["name"];
            string country = Request.Form["country"];
            if (!DoesExist(name))
            {
                this.BadFeedback.InnerText = "יצרן זה אינו קיים";
                return;
            }
            string query = "SELECT * FROM ProductorsTable";
            try
            {
                DataSet ds = GetDataSet(query);
                string where = $"ProductorName='{name}'";
                DataRow[] rows = ds.Tables[0].Select(where);
                foreach (DataRow row in rows)
                    row.Delete();

                SaveDatabase(query, ds);
                this.GoodFeedback.InnerText = "היצרן נמחק בהצלחה!";
            }
            catch (Exception ex)
            {
                this.BadFeedback.InnerText = "משהו השתבש";
            }
        }
    }
}