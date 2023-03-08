using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
namespace Nave_Project2.Utils
{
    public class Database
    {
        /* פונקציות המחלקה
         * GetConnectionString() - מחזירה מחרוזת התחברות לקובץ אקסס
         * GetDataSet() -  לפי השאילתה DataSet מחזיר עצם 
         * SaveDatabase() - שומר שינויים במסד נתונים
         * EncryptMD5() - MD5 מצפין טקסט, הצפנת 
         * 
         */

        public static string GetConnectionString() { return ConnectionString; }
        private static string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db.mdb;Persist Security Info=True";
        // Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Nave_Project2\Nave_Project2\App_Data\db.mdb;Persist Security Info=True
        public static DataSet GetDataSet(string query)
        {
            // מחזיר אוביקט דאטאסט ממחרוזת שמייצגת שאילתה
            DataSet ds = new DataSet();
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            conn.Open();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }
        public static void SaveDatabase(string SqlQuery, DataSet ds)
        {
            // שומר שינויים במאגר המידע
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(SqlQuery, conn);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.Update(ds);
            adapter.Fill(ds);
        }
        /*
         private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
         */
    }
}