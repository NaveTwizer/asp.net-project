using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;


namespace Nave_Project2.Pages.shop.products
{
    public partial class product : System.Web.UI.Page
    {
        private static int ProductNumber = 1;
        private void SetupProductDetails(DataRow row)
        {   // פעולה המעדכנת את המוצר על גבי המסך לפי שורה בטבלה
            int AmountInStock = int.Parse(row["Amount"].ToString());
            if (AmountInStock == 0)
            {
                this.AmountInStock.InnerText = "אזל המלאי";
                this.AmountInStock.Style.Add("color", "red");
                return;
            }
            string ProductName = (string)row["ProductName"];
            this.Title = $"מוצרים | {ProductName}";
            this.title.InnerText = (string)row["ProductName"];
            this.ProductImg.Src = (string)row["src"];

            string Dep = (string)row["DepName"];
            this.ProductDep.InnerText = $"מחלקה: {Dep}";
            string ProductorName = (string)row["ProductorName"];
            this.ProductorName.InnerText = $"יצרן: {ProductorName}";
            this.ProductDesc.InnerText = (string)row["ProductDesc"];
            this.PricePerUnit.InnerText = "מחיר ליחידה: " + row["Price"].ToString() + "₪";

            this.AmountInStock.InnerText = $"כמות במלאי: {AmountInStock}";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.AmountInStock.Style.Add("color", "black");
            // URL-לדעת איזה מוצר ביקש הלקוח לפי כתובת ה
            string RequestedProduct = (string)Page.RouteData.Values["product"];
            this.AmountInStock.Style.Add("color", "black");
            if (String.IsNullOrEmpty(RequestedProduct))
                return;
            string query = $"SELECT * FROM ProductsTable WHERE ProductName='{RequestedProduct}' OR ProductName LIKE '%{RequestedProduct}%'";
            DataSet ds = GetDataSet(query);
            bool DoesProductExist = ds.Tables[0].Rows.Count > 0;
            this.title2.Visible = true;
            if (!DoesProductExist) // המוצר לא נמצא
            {
                this.title.InnerText = $"אנו מתנצלים, אך לא מצאנו את המוצר {RequestedProduct}";
                this.Title = "מוצרים | לא נמצא";
                this.title2.Visible = false;
                this.ProductImg.Src = "/images/products/NotFound.png";
                return;
            }
            DataRow row = ds.Tables[0].Rows[0];
            this.MultipleProductsTitle.InnerText = $"נמצאו {ds.Tables[0].Rows.Count} מוצרים";
            SetupProductDetails(row);
        }
        private void UpdateCurrentProduct(int overall)
        {
            this.CurrentProduct.InnerText = $"{ProductNumber + 1}/{overall}";
        }
        protected void GoBackButton_Click(object sender, EventArgs e)
        {
            // חזרה למוצר הנמצא הקודם
            if (ProductNumber == 0)
                return;
            string RequestedProduct = (string)Page.RouteData.Values["product"];

            string query = $"SELECT * FROM ProductsTable WHERE ProductName LIKE '%{RequestedProduct}%'";
            DataSet ds = GetDataSet(query);

            ProductNumber -= 1;
            try
            {
                SetupProductDetails(ds.Tables[0].Rows[ProductNumber]);
                UpdateCurrentProduct(ds.Tables[0].Rows.Count);
            } catch (Exception) { }
        }

        protected void GoForwardButton_Click(object sender, EventArgs e)
        {
            // להתקדם למוצר הנמצר הבא
            // לדוגמא
            // במבה -> במבה נוגט
            string RequestedProduct = (string)Page.RouteData.Values["product"];

            string query = $"SELECT * FROM ProductsTable WHERE ProductName LIKE '%{RequestedProduct}%'";
            DataSet ds = GetDataSet(query);
            if (ProductNumber == ds.Tables[0].Rows.Count - 1)
                return;
            ProductNumber += 1;
            try
            {
                SetupProductDetails(ds.Tables[0].Rows[ProductNumber]);
                UpdateCurrentProduct(ds.Tables[0].Rows.Count);
            } catch (Exception) { }
        }
    }
}