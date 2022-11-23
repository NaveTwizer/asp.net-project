using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.utils.Database;
namespace Nave_Project2.Pages.RegularPages.update
{
    public partial class update_product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (!IsPostBack)
            {
                string query = "SELECT * FROM DepTable";
                DataSet ds = GetDataSet(query);
                this.DepSelect.DataBind();
                int count = 0;
                string value = "";
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    value = row["DepName"].ToString();
                    this.DepSelect.Items.Insert(count, new ListItem(value, value));
                    count++;
                }
            }*/
        }
        private void Alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", $"alert('{message}')", true);
        }
        private bool DoesExist(string ProductCode)
        {
            string query = $"SELECT * FROM ProductsTable WHERE ProductCode='{ProductCode}'";
            return GetDataSet(query).Tables[0].Rows.Count != 0;
        }
        private bool DoesDepExist(string DepName)
        {
            return GetDataSet($"SELECT * FROM DepTable WHERE DepName='{DepName}'")
                .Tables[0].Rows.Count != 0;
        }
        private bool DoesProductorExist(string name)
        {
            return GetDataSet($"SELECT * FROM ProductorsTable WHERE ProductorName='{name}'")
                .Tables[0].Rows.Count != 0;
        }
        private bool DoesProviderExist(string ProviderCode)
        {
            return GetDataSet($"SELECT * FROM ProvidersTable WHERE ProviderCode='{ProviderCode}'")
                .Tables[0].Rows.Count != 0;
        }
        protected void CreateButton_Click(object sender, EventArgs e)
        {
            this.BadFeedback.InnerText = "";
            this.GoodFeedback.InnerText = "";
            string code = Request.Form["code"];
            string name = Request.Form["name"];
            string dep = Request.Form["dep"];
            string productor = Request.Form["productor"];
            string desc = Request.Form["desc"];
            string provider = Request.Form["ProviderCode"];
            string price = Request.Form["price"];
            string amount = Request.Form["amount"];

            
            if (DoesExist(code))
            {
                this.BadFeedback.InnerText = "מוצר עם קוד זה כבר קיים";
                return;
            }
            if (!DoesDepExist(dep))
            {
                this.BadFeedback.InnerText = "מחלקה זו אינה קיימת, צור אותה";
                return;
            }
            if (!DoesProductorExist(productor))
            {
                this.BadFeedback.InnerText = "יצרן זה אינו קיים, צור אותו.";
                return;
            }
            if (!DoesProviderExist(provider))
            {
                this.BadFeedback.InnerText = "ספק זה אינו קיים, צור אותו.";
                return;
            }
            
            string query = "SELECT * FROM ProductsTable";
            DataSet ds = GetDataSet(query);
            DataRow row = ds.Tables[0].NewRow();
            row["ProductCode"] = code;
            row["ProductName"] = name;
            row["DepName"] = dep;
            row["ProductorName"] = productor;
            row["ProviderCode"] = provider;
            row["ProductDesc"] = desc;
            row["Price"] = price;
            row["Amount"] = amount;
            ds.Tables[0].Rows.Add(row);
            SaveDatabase(query, ds);
            this.GoodFeedback.InnerText = "המוצר נשמר בהצלחה";
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            this.BadFeedback.InnerText = "";
            this.GoodFeedback.InnerText = "";
            string code = Request.Form["code"];
            string name = Request.Form["name"];
            string dep = Request.Form["dep"];
            string productor = Request.Form["productor"];
            string desc = Request.Form["desc"];
            string provider = Request.Form["ProviderCode"];
            string price = Request.Form["price"];
            string amount = Request.Form["amount"];
            if (!DoesExist(code))
            {
                this.BadFeedback.InnerText = "מוצר זה אינו קיים!";
                return;
            }
            if (!DoesDepExist(dep))
            {
                this.BadFeedback.InnerText = "מחלקה זו אינה קיימת, צור אותה";
                return;
            }
            if (!DoesProductorExist(productor))
            {
                this.BadFeedback.InnerText = "יצרן זה אינו קיים, צור אותו.";
                return;
            }
            if (!DoesProviderExist(provider))
            {
                this.BadFeedback.InnerText = "ספק זה אינו קיים, צור אותו.";
                return;
            }
            string sql = "SELECT * FROM ProductsTable";
            DataSet ds = GetDataSet(sql);

            string where = $"ProductCode='{code}'";
            DataRow row = ds.Tables[0].Select(where).FirstOrDefault();

            row["ProductCode"] = code;
            row["ProductName"] = name;
            row["DepName"] = dep;
            row["ProductorName"] = productor;
            row["ProviderCode"] = provider;
            row["ProductDesc"] = desc;
            row["Price"] = price;
            row["Amount"] = amount;

            SaveDatabase(sql, ds);
            this.GoodFeedback.InnerText = "הנתונים נשמרו בהצלחה!";

        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            this.BadFeedback.InnerText = "";
            this.GoodFeedback.InnerText = "";
            string code = Request.Form["code"];

            if (!DoesExist(code))
            {
                this.BadFeedback.InnerText = "מוצר זה אינו קיים!";
                return;
            }
            // Delete record from SalesDetails table
            string query2 = "SELECT * FROM SalesDetailsTable";
            DataSet ds2 = GetDataSet(query2);
            string where2 = $"ProductCode='{code}'";
            DataRow[] rows2 = ds2.Tables[0].Select(where2);
            foreach (DataRow row2 in rows2)
                row2.Delete();
            SaveDatabase(query2, ds2);


            // Delete product
            string query = "SELECT * FROM ProductsTable";
            DataSet ds = GetDataSet(query);
            string where = $"ProductCode='{code}'";
            DataRow[] rows = ds.Tables[0].Select(where);
            foreach (DataRow row in rows)
                row.Delete();
            SaveDatabase(query, ds);
            this.GoodFeedback.InnerText = "המוצר נמחק בהצלחה!";
        }
    }
}