using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static Nave_Project2.Utils.Database;

namespace Nave_Project2.Pages.shop
{
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ProductID = Request.QueryString["ProductId"];
            if (String.IsNullOrEmpty(ProductID))
            {
                ProductID = "1";
            }
            string q = "SELECT * FROM ProductsTable";
            DataSet ds = GetDataSet(q);
            DataRow row = ds.Tables[0].Select($"ProductCode='{ProductID}'").First();
            this.Pricee.InnerText = row["Price"].ToString();
            this.Description.InnerText = row["ProductDesc"].ToString();
            this.ProductImage.Src = row["src"].ToString();
            this.DepName.InnerText = row["DepName"].ToString();
            this.ProductorName.InnerText = row["ProductorName"].ToString();
        }
    }
}