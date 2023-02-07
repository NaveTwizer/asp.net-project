using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nave_Project2.Components
{
    public class ShoppingCart
    {
        public List<CartItem> Items { get; private set; }


        // Readonly properties can only be set in initialization or in a constructor
        public static readonly ShoppingCart MyShoppingCart;

        // The static constructor is called as soon as the class is loaded into memory
        static ShoppingCart()
        {
            // If the cart is not in the session, create one and put it there
            // Otherwise, get it from the session
            if (HttpContext.Current.Session["ASPNETShoppingCart"] == null)
            {
                MyShoppingCart = new ShoppingCart();
                MyShoppingCart.Items = new List<CartItem>();
                HttpContext.Current.Session["ASPNETShoppingCart"] = MyShoppingCart;
            }
            else
            {
                MyShoppingCart = (ShoppingCart)HttpContext.Current.Session["ASPNETShoppingCart"];
            }
        }

        // A protected constructor ensures that an object can't be created from outside
        protected ShoppingCart() { }

        /**
         * AddItem() - Adds an item to the shopping 
         */
        public void AddItem(int productId, int RequestedAmount)
        {
            // Create a new item to add to the cart
            CartItem newItem = new CartItem(productId, RequestedAmount);

            // If this item already exists in our list of items, increase the quantity
            // Otherwise, add the new item to the list
            if (Items.Contains(newItem))
                foreach (CartItem Item in Items)
                    if (Item.Equals(newItem))
                    {
                        Item._RequestedAmount += RequestedAmount;
                        return;
                    }


            Items.Add(newItem);
        }

        /**
         * SetItemQuantity() - Changes the quantity of an item in the cart
         */

        /**
         * RemoveItem() - Removes an item from the shopping cart
         */
        public void RemoveItem(int productId)
        {
            CartItem removedItem = new CartItem(productId, 0);
            Items.Remove(removedItem);
        }
        /**
         * GetSubTotal() - returns the total price of all of the items
         *                 before tax, shipping, etc.
         */
        public decimal GetSubTotal()
        {
            decimal subTotal = 0;
            foreach (CartItem item in Items)
                subTotal += decimal.Parse(item.TotalPrice.ToString());

            return subTotal;
        }
    }
}