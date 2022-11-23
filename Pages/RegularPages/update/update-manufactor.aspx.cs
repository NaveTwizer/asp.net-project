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
            string query = "SELECT * FROM ProductorsTable";
            
            DataSet ds = GetDataSet(query);

            DataRow row = ds.Tables[0].NewRow();
            row["ProductorName"] = name;
            row["CountryName"] = country;
            ds.Tables[0].Rows.Add(row);

            SaveDatabase(query, ds);
            this.GoodFeedback.InnerText = "הסניף נשמר בהצלחה!";
            // ERROR
            // You cannot add or change a record because a related
            // record is required in table 'CountriesTable'.
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}