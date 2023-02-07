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


        private static string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db.mdb;Persist Security Info=True";
        // Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Nave_Project2\Nave_Project2\App_Data\db.mdb;Persist Security Info=True
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
        /*
         private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
         */
        public static string EncryptMD5(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}