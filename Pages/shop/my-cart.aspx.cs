using System;
using static Nave_Project2.Components.ShoppingCart;


namespace Nave_Project2.Pages
{
    public partial class MyCart : System.Web.UI.Page
    {
        private string GetProductComponent(Components.Product product)
        {
            return $@"
            <div class='card'>
                {product.ImageTag}
                <h1>{product.Name}</h1>
                <span class='plus' data-input-id='Amount_{product.Id}'>+</span>
                <input type='text' class='AmountInputs' id='Amount_{product.Id}' value='{product.RequestedAmount}' />
                <span class='minus' data-input-id='Amount_{product.Id}'>-</span>
                <p class='price'>{product.PriceWithShekel}</p>
                <p>{product.Description}</p>
            </div>
            ";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.header.InnerText = $"הסל שלי - {MyShoppingCart.Items.Count} פריטים";
                foreach (Components.CartItem Item in MyShoppingCart.Items)
                {
                    this.CartDiv.InnerHtml += GetProductComponent(Item.Prod);
                }
                var total = MyShoppingCart.GetSubTotal();
                this.ToPay.InnerText = $"לתשלום: {total} שקלים";
            }
        }

        protected void PayButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("payment.aspx");
        }
    }
}