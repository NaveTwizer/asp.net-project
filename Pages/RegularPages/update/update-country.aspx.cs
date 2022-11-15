using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using static Nave_Project2.Pages.MasterPages.Database; // CUSTOM CLASS

namespace Nave_Project2.Pages.RegularPages.update
{
    public partial class update_country_new : System.Web.UI.Page
    {
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        private bool DoesExist(string Country)
        {
            string sql = $"SELECT * FROM CountriesTable WHERE CountryName='{Country}'";
            DataSet ds = GetDataSet(sql);
            return (ds.Tables[0].Rows.Count != 0);
        }
        // CREATE EVENT
        private void Create(string country, string branchesNum)
        {
            if (DoesExist(country))
            {
                this.badFeedback.InnerText = "מדינה זו כבר קיימת!";
                return;
            }
            string sql = "SELECT * FROM CountriesTable";
            try
            {
                DataSet ds = GetDataSet(sql);

                DataRow row = ds.Tables[0].NewRow();
                row["CountryName"] = country;
                row["BranchesNum"] = branchesNum;
                ds.Tables[0].Rows.Add(row);

                SaveDatabase(sql, ds);
                this.goodFeedback.InnerText = "המדינה נשמרה בהצלחה!";
            } catch(Exception e)
            {
                this.badFeedback.InnerText = "משהו השתבש";
                Alert(e.Message);
            }
        }



        // UPDATE EVENT
        private void Update(string country, string branchesNum)
        {
            if (!DoesExist(country))
            {
                this.badFeedback.InnerText = "מדינה זו אינה קיימת!";
                return;
            }
            string sql = "SELECT * FROM CountriesTable";
            try
            {
                DataSet ds = GetDataSet(sql);

                string where = $"CountryName='{country}'";
                DataRow row = ds.Tables[0].Select(where).FirstOrDefault();

                row["CountryName"] = country;
                row["BranchesNum"] = branchesNum;


                SaveDatabase(sql, ds);
                this.goodFeedback.InnerText = "הנתונים נשמרו בהצלחה!";
            } catch(Exception e)
            {
                this.badFeedback.InnerText = "משהו השתבש";
                Alert(e.Message);
            }
        }

        // DELETE EVENT

        private void Delete(string country)
        {
            if (!DoesExist(country))
            {
                this.badFeedback.InnerText = "מדינה זו אינה קיימת!";
                return;
            }
            string query = "SELECT * FROM CountriesTable";
            try
            {
                DataSet ds = GetDataSet(query);
                string where = $"CountryName='{country}'";
                DataRow[] row = ds.Tables[0].Select(where);
                for (int i = 0; i < row.Length; i++)
                {
                    row[i].Delete();
                }
                SaveDatabase(query, ds);
                this.goodFeedback.InnerText = "המדינה נמחקה בהצלחה!";
            } catch(Exception e)
            {
                this.badFeedback.InnerText = "משהו השתבש";
                Alert(e.Message);
            }
        }
        protected void Update_Button_Click(object sender, EventArgs e)
        {
            this.badFeedback.InnerText = "";
            this.goodFeedback.InnerText = "";
            string country = Request.Form["countryName"];
            string num = Request.Form["branchesNum"];
            Update(country, num);
        }

        protected void Create_Button_Click(object sender, EventArgs e)
        {
            this.badFeedback.InnerText = "";
            this.goodFeedback.InnerText = "";
            string country = Request.Form["countryName"];
            string num = Request.Form["branchesNum"];

            Create(country, num);
        }

        protected void Delete_Button_Click(object sender, EventArgs e)
        {
            this.badFeedback.InnerText = "";
            this.goodFeedback.InnerText = "";
            string country = Request.Form["countryName"];

            Delete(country);
        }
    }
}