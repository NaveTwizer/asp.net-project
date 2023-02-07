using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;
using static Nave_Project2.Utils.Security;

namespace Nave_Project2.Pages.data.update
{
    public partial class update_products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RedirectLoggedUserFromAdminePages(HttpContext.Current);
            this.feedback.InnerText = "";
            this.provider.DataBind();
            this.provider.Items.Clear();

            string q = "SELECT * FROM ProvidersTable";
            string val;
            foreach (DataRow row in GetDataSet(q).Tables[0].Rows)
            {
                val = row["ProviderCode"].ToString();
                this.provider.Items.Add(
                    new ListItem(val, val, true)
                );
            }
            this.dep.DataBind();
            this.dep.Items.Clear();

            string q2 = "SELECT * FROM DepTable";
            string val2;
            foreach (DataRow row2 in GetDataSet(q2).Tables[0].Rows)
            {
                val2 = row2["DepName"].ToString();
                this.dep.Items.Add(
                    new ListItem(val2, val2, true)
                );
            }

            this.productor.DataBind();
            this.productor.Items.Clear();

            string q3 = "SELECT * FROM ProductorsTable";
            string val3;
            foreach (DataRow row3 in GetDataSet(q3).Tables[0].Rows)
            {
                val3 = row3["ProductorName"].ToString();
                this.productor.Items.Add(
                    new ListItem(val3, val3, true)
                );
            }
        }
        private bool DoesProductExist(string ProductName)
        {
            string q = $"SELECT * FROM ProductsTable WHERE ProductName='{ProductName}'";
            return GetDataSet(q).Tables[0].Rows.Count == 1;
        }
        private (string, string, string, string, string, string, string) GetFormData()
        {
            return (
                Request.Form["product"],
                Request.Form["dep"],
                Request.Form["productor"],
                Request.Form["provider"],
                Request.Form["desc"],
                Request.Form["price"],
                Request.Form["amount"]
            );
        }
        protected void CreateButton_Click(object sender, EventArgs e)
        {
            (string product, string _dep, string _productor, string _provider, string desc, string price, string amount)
                = GetFormData();

            if (DoesProductExist(product))
            {
                this.feedback.InnerText = "מוצר זה כבר קיים";
                return;
            }
            string query = "SELECT * FROM ProductsTable";
            DataSet ds = GetDataSet(query);
            int MaxCode = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (int.Parse(row["ProductCode"].ToString()) > MaxCode)
                    MaxCode = int.Parse(row["ProductCode"].ToString());
            }
            int NewCode = MaxCode + 1;
            HttpPostedFile File = this.FileUpload.PostedFile;
            DataRow NewRow = ds.Tables[0].NewRow();

            NewRow["ProductCode"] = NewCode;
            NewRow["ProductName"] = product;
            NewRow["DepName"] = this.dep.Value;
            NewRow["ProductorName"] = this.productor.Value;
            NewRow["ProviderCode"] = this.provider.Value;
            NewRow["ProductDesc"] = desc;
            NewRow["Price"] = price;
            NewRow["Amount"] = amount;
            NewRow["src"] = $"/images/products/{File.FileName}";
            ds.Tables[0].Rows.Add(NewRow);

            // Save image to products folder
            string SaveLocation = Server.MapPath("~/images/products/");
            SaveLocation += File.FileName;
            File.SaveAs(SaveLocation);
            SaveDatabase(query, ds);
            this.feedback.InnerText = "המוצר נשמר בהצלחה";
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            (string product, string _dep, string _productor, string _provider, string desc, string price, string amount)
                = GetFormData();

            if (!DoesProductExist(product))
            {
                this.feedback.InnerText = "מוצר זה אינו קיים";
                return;
            }
            string query = $"SELECT * FROM ProductsTable";
            DataSet ds = GetDataSet(query);
            DataRow row = ds.Tables[0].Select($"ProductName='{product}'").First();

            
            row["DepName"] = this.dep.Value;
            row["ProductorName"] = this.productor.Value;
            row["ProviderCode"] = this.provider.Value;
            row["ProductDesc"] = desc;
            row["Price"] = price;
            row["Amount"] = amount;
            SaveDatabase(query, ds);
            this.feedback.InnerText = "המוצר עודכן בהצלחה";
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            string product = Request.Form["product"];
            if (!DoesProductExist(product))
            {
                this.feedback.InnerText = "מוצר זה אינו קיים";
                return;
            }
            string q = $"SELECT * FROM ProductsTable";
            DataSet ds = GetDataSet(q);
            DataRow row = ds.Tables[0].Select($"ProductName='{product}'").First();
            row.Delete();
            SaveDatabase(q, ds);
            this.feedback.InnerText = "המוצר נמחק בהצלחה";
        }
    }
}