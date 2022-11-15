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
    public partial class update_branch : System.Web.UI.Page
    {
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
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

                SaveDatabase(sql, ds);
                this.goodFeedback.InnerText = "הסניף נשמר בהצלחה!";
            } catch(Exception ex)
            {
                this.badFeedback.InnerText = "משהו השתבש, בדוק שקוד הסניף אינו כפיל";
                Alert(ex.Message);
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
            try
            {
                DataSet ds = GetDataSet(sql);

                string where = $"BranchesName='{name}'";
                DataRow row = ds.Tables[0].Select(where).FirstOrDefault();

                // update
                row["BranchesCode"] = code;
                row["BranchesName"] = name;
                row["BranchesAddress"] = address;
                row["BranchesPhone"] = phone;

                // save
                SaveDatabase(sql, ds);

                // output
                this.goodFeedback.InnerText = "הנתונים נשמרו בהצלחה!";
            } catch(Exception e)
            {
                this.badFeedback.InnerText = "משהו השתבש";
                Alert(e.Message);
            }
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
            try
            {
                DataSet ds = GetDataSet(query);
                string where = $"BranchesName='{name}'";
                DataRow[] row = ds.Tables[0].Select(where);

                // delete
                for (int i = 0; i < row.Length; i++)
                {
                    row[i].Delete();
                }

                // save
                SaveDatabase(query, ds);
                this.goodFeedback.InnerText = "הסניף נמחק בהצלחה!";
            } catch(Exception ex)
            {
                this.badFeedback.InnerText = "משהו השתבש";
                Alert(ex.Message);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Create_Button_Click(object sender, EventArgs e)
        {
            this.badFeedback.InnerText = "";
            this.goodFeedback.InnerText = "";
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
            this.badFeedback.InnerText = "";
            this.goodFeedback.InnerText = "";
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
            this.badFeedback.InnerText = "";
            this.goodFeedback.InnerText = "";
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