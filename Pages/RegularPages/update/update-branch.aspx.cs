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
    public partial class update_branch : System.Web.UI.Page
    {
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
        private bool DoesExist(string name)
        {
            // name - branch name
            DataSet ds = GetDataSet($"SELECT * FROM BranchesTable WHERE BranchesName='{name}'");
            return ds.Tables[0].Rows.Count != 0;
        }

        // CREATE EVENT
        private void Create(string name, string code, string address, string phone)
        {
            this.goodFeedback.InnerText = "";
            this.badFeedback.InnerText = "";
            if (DoesExist(name))
            {
                this.badFeedback.InnerText = "סניף זה כבר קיים!";
                return;
            }
            string sql = "SELECT * FROM BranchesTable";
            try
            {
                DataSet ds = GetDataSet(sql);

                DataRow row = ds.Tables[0].NewRow();
                row["BranchesCode"] = code;
                row["BranchesName"] = name;
                row["BranchesAddress"] = address;
                row["BranchesPhone"] = phone;
                ds.Tables[0].Rows.Add(row);


                OleDbConnection conn = new OleDbConnection(GetConnectionString());
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.Update(ds);
                adapter.Fill(ds);

                this.goodFeedback.InnerText = "הסניף נשמר בהצלחה!";
            } catch
            {
                this.badFeedback.InnerText = "משהו השתבש";
            }
        }

        // UPDATE EVENT
        private void Update(string name, string code, string address, string phone)
        {
            if (!DoesExist(name))
            {
                this.badFeedback.InnerText = "סניף זו אינו קיים!";
                return;
            }
            string sql = "SELECT * FROM BranchesTable";
            DataSet ds = GetDataSet(sql);

            string where = $"BranchesName='{name}'";
            DataRow row = ds.Tables[0].Select(where).FirstOrDefault();

            // update
            row["BranchesCode"] = code;
            row["BranchesName"] = name;
            row["BranchesAddress"] = address;
            row["BranchesPhone"] = phone;

            // save
            OleDbConnection conn = new OleDbConnection(GetConnectionString());
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.Update(ds);
            this.goodFeedback.InnerText = "הנתונים נשמרו בהצלחה!";
        }

        // DELETE
        private void Delete(string name, string code, string addr, string phone)
        {
            if (!DoesExist(name))
            {
                this.badFeedback.InnerText = "סניף זה אינו קיים!";
                return;
            }
            string query = "SELECT * FROM BranchesTable";
            DataSet ds = GetDataSet(query);
            string where = $"BranchesName='{name}'";
            DataRow[] row = ds.Tables[0].Select(where);
            for (int i = 0; i < row.Length; i++)
            {
                row[i].Delete();
            }
            OleDbConnection conn = new OleDbConnection(GetConnectionString());
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.Update(ds);
            this.goodFeedback.InnerText = "הסניף נמחק בהצלחה!";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            DataSet ds = GetDataSet("SELECT * FROM BranchesTable");
            string str = "";
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                str += r["BranchesName"];
            }
            this.goodFeedback.InnerText = str; */
        }

        protected void Create_Button_Click(object sender, EventArgs e)
        {
            if (Request.ContentLength > 0)
            {
                string code = Request.Form["branchCode"];
                string name = Request.Form["branchName"];
                string addr = Request.Form["branchAddress"];
                string phone = Request.Form["branchPhone"];
                Create(name, code, addr, phone);
            }
        }

        protected void Delete_Button_Click(object sender, EventArgs e)
        {
            if (Request.ContentLength > 0)
            {
                string code = Request.Form["branchCode"];
                string name = Request.Form["branchName"];
                string addr = Request.Form["branchAddress"];
                string phone = Request.Form["branchPhone"];
                Delete(name, code, addr, phone);
            }
        }

        protected void Update_Button_Click(object sender, EventArgs e)
        {
            if (Request.ContentLength > 0)
            {
                string code = Request.Form["branchCode"];
                string name = Request.Form["branchName"];
                string addr = Request.Form["branchAddress"];
                string phone = Request.Form["branchPhone"];
                Update(name, code, addr, phone);
            }
        }
    }
}