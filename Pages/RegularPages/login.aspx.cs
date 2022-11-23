using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.utils.Database; // CUSTOM CLASS
using System.Data.OleDb;

namespace Nave_Project2.Pages.RegularPages
{
    public partial class LoginTEST : System.Web.UI.Page
    {
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        private string GetTime()
        {
            DateTime now = new DateTime();
            return $"{now.Day}-{now.Month}-{now.Year}_{now.Hour}-{now.Minute}-{now.Second}.txt";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GoodFeedback.InnerText = "";
            this.BadFeedback.InnerText = "";
            if (IsPostBack)
            {
                string username = Request.Form["username"];
                string pswd = Request.Form["pswd"];

                string query = $"SELECT * FROM Users WHERE username='{username}' AND pswd='{pswd}'";
                DataSet ds = GetDataSet(query);

                bool IsLoggedIn = ds.Tables[0].Rows.Count != 0;

                if (!IsLoggedIn)
                {
                    this.BadFeedback.InnerText = "המשתמש לא נמצא";
                    return;
                }
                if (username == "admin" && pswd == "admin")
                {
                    Session["username"] = "admin";
                    Response.Redirect("AdminHomePage.aspx");
                    Response.End();
                }
                else
                {
                    Session["username"] = username;
                    Response.Redirect("LoggedHomePage.aspx");
                    Response.End();
                }
            }
        }
    }
}