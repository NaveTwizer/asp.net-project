using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using static Nave_Project2.Utils.Database;


namespace Nave_Project2.Components
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public int RequestedAmount { get; set; }
        public string DepName { get; set; }
        public string ProductorName { get; set; }
        public string ProviderCode { get; set; }
        public int CurrentAmount { get; set; }
        private string src;
        public string PriceWithShekel { get; set; }
        public string ImageTag { get; set; }
        private string ParseRow(DataRow r, string attr)
        {
            return r[attr].ToString();
        }
        public Product(int id, int RequestedAmount)
        {
            string query = $"SELECT * FROM ProductsTable WHERE ProductCode='{id}'";
            DataSet ds = GetDataSet(query);
            DataRow row = ds.Tables[0].Rows[0];
            this.Id = int.Parse(ParseRow(row, "ProductCode"));
            this.Price = ParseRow(row, "Price");
            this.Description = ParseRow(row, "ProductDesc");
            this.RequestedAmount = RequestedAmount;
            this.DepName = ParseRow(row, "DepName");
            this.ProductorName = ParseRow(row, "ProductorName");
            this.ProviderCode = ParseRow(row, "ProviderCode");
            this.CurrentAmount = int.Parse(ParseRow(row, "Amount"));
            this.Name = ParseRow(row, "ProductName");
            this.src = ParseRow(row, "src");
            this.ImageTag = $"<img alt='product' src='{this.src}' style='width:100%' />";
            this.PriceWithShekel = this.Price + "₪";
        }
    }
}