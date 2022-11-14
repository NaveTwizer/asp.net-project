using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;


namespace Nave_Project2.Pages.RegularPages.update
{
    public partial class update_country : System.Web.UI.Page
    {
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        private string GetConnectionString()
        {
            //return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Nave_Project2\Nave_Project2\App_Data\Naves_Project_Ina_final.mdb;Persist Security Info=True";
            return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Naves_Project_Ina_final.mdb;Persist Security Info=True";
        }
        private DataSet GetDataSet(string query)
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = new OleDbConnection(GetConnectionString());
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            conn.Open();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }
        private string ParseRow(DataRow r, string att)
        {
            return $"<td>{r[att]}</td>";
        }
        private bool IsExists(string Country, string Num)
        {
            string sql = $"SELECT * FROM CountriesTable WHERE CountryName='{Country}'";
            DataSet ds = GetDataSet(sql);
            return (ds.Tables[0].Rows.Count != 0);
        }
        private void Update(string country, string NewNum)
        {
            string sql = "SELECT * FROM CountriesTable";
            DataSet ds = GetDataSet(sql);

            string where = $"CountryName='{country}'";
            DataRow row = ds.Tables[0].Select(where).FirstOrDefault();

            row["CountryName"] = country;
            row["BranchesNum"] = NewNum;


            OleDbConnection conn = new OleDbConnection(GetConnectionString());
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.Update(ds);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (Request.ContentLength != 0)
            {
                string CountryName = Request.Form["countryName"];
                string BranchesNum = Request.Form["branchesNum"];

                if (IsExists(CountryName, BranchesNum))
                {
                    Update(CountryName, BranchesNum);
                } else
                {
                    feedback.InnerText = "היצרן אינו קיים!";
                }
            }*/
        }

        private void Create(string country, string num)
        {
            string sql = "SELECT * FROM CountriesTable";
            DataSet ds = GetDataSet(sql);

            DataRow row = ds.Tables[0].NewRow();
            row["CountryName"] = country;
            row["BranchesNum"] = num;
            ds.Tables[0].Rows.Add(row);


            OleDbConnection conn = new OleDbConnection(GetConnectionString());
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.Update(ds);
            adapter.Fill(ds);
        }
        protected void Create_Button_Click(object sender, EventArgs e)
        {
            feedback.InnerText = "";
            string country = Request.Form["countryName"];
            string num = Request.Form["branchesNum"];

            if (IsExists(country, num))
            {
                feedback.InnerText = "המדינה כבר קיימת!";
            } else
            {
                Create(country, num);
                feedback.InnerText = "נשמר בהצלחה!";
            }
        }
    }
}