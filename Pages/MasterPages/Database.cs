using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;


namespace Nave_Project2.Pages.MasterPages
{
    public class Database
    {
        /* פונקציות המחלקה
         * GetConnectionString() - מחזירה מחרוזת התחברות לקובץ אקסס
         * GetDataSet() -  לפי השאילתה DataSet מחזיר עצם 
         * SaveDatabase() - שומר שינויים במסד נתונים
         * 
         * 
         */


        private static string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Naves_Project_Ina_final.mdb;Persist Security Info=True";

        public static string GetConnectionString()
        {
            //return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Nave_Project2\Nave_Project2\App_Data\Naves_Project_Ina_final.mdb;Persist Security Info=True";
            return ConnectionString;
        }
        public static DataSet GetDataSet(string query)
        {
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
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(SqlQuery, conn);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.Update(ds);
            adapter.Fill(ds);
        }
    }
}