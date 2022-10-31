using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace Nave_Project2.Pages.RegularPages.Data
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string GetConnectionString()
        {
            //return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Nave_Project2\Nave_Project2\App_Data\Naves_Project_Ina_final.mdb;Persist Security Info=True";
            return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Naves_Project_Ina_final.mdb;Persist Security Info=True";
        }
        public DataSet GetDataSet(string query)
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = new OleDbConnection(GetConnectionString());
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            conn.Open();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }
        public void GetUsers(DataSet ds)
        {
            string all = "<table border='1' align='center'>";
            all += "<tr><td>Username</td><td>Password</td><td>First Name</td><td>Last Name</td><td>Address</td><td>Gender</td><td>Mail</td><td>Birthday</td></tr>";
            
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                all += "<tr>";
                all += "<td>" + row["username"] + "</td>";
                all += "<td>" + row["pswd"] + "</td>";
                all += "<td>" + row["firstname"] + "</td>";
                all += "<td>" + row["lastname"] + "</td>";
                all += "<td>" + row["address"] + "</td>";
                all += "<td>" + row["gender"] + "</td>";
                all += "<td>" + row["mail"] + "</td>";
                all += "<td>" + row["birthday"] + "</td>";
                all += "<tr>";
            }
            all += "</table>";
            Response.Write(all);
        }
        public void ListUsers()
        {
            string sql = "SELECT * FROM Users\nORDER BY username ASC;";
            DataSet ds = GetDataSet(sql);
            GetUsers(ds);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}