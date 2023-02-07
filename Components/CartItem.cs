using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nave_Project2.Components
{
    public class CartItem : IEquatable<CartItem>
    {
        public int Quantity { get; set; }

        private int _productId;
        public int _RequestedAmount;
        public int ProductId
        {
            get { return _productId; }
            set
            {
                // To ensure that the Prod object will be re-created
                _product = null;
                _productId = value;
            }
        }

        private Product _product = null;
        public Product Prod
        {
            get
            {
                // Lazy initialization - the object won't be created until it is needed
                if (_product == null)
                {
                    _product = new Product(ProductId, _RequestedAmount);
                }
                return _product;
            }
        }

        public string Description
        {
            get { return Prod.Description; }
        }

        public string UnitPrice
        {
            get { return Prod.Price; }
        }

        public decimal TotalPrice
        {
            get { return decimal.Parse(UnitPrice) * _RequestedAmount; }
        }

        // CartItem constructor just needs a productId
        public CartItem(int productId, int RequestedAmount)
        {
            this.ProductId = productId;
            this._RequestedAmount = RequestedAmount;
        }

        /**
         * Equals() - Needed to implement the IEquatable interface
         *    Tests whether or not this item is equal to the parameter
         *    This method is called by the Contains() method in the List class
         *    We used this Contains() method in the ShoppingCart AddItem() method
         */
        public bool Equals(CartItem item)
        {
            return item.ProductId == this.ProductId;
        }
    }
}