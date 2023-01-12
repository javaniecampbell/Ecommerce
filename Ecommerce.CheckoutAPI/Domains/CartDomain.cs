using Ecommerce.CheckoutAPI.Data.Entities;

namespace Ecommerce.CheckoutAPI.Domains
{
    public class CartDomain
    {
        private readonly Cart _cart;

        public CartDomain(Cart cart)
        {
            _cart = cart; 
        }


        public IEnumerable<CartItem> Items { 
            get
            {
                return _cart.Items;
            }
         }

        public void AddToCart(CartItem newItem)
        {
            _cart.Items.Add(newItem);
        }
        public void IncreaseQuantity (int productId, int quantity)
        {
            var item = _cart.Items.FirstOrDefault(c => c.ProductId == productId);
            if (item != null)
            {
                item.Quantity += quantity;
            }


        }
        public void DecreaseQuantity (int productId, int quantity)
        {
            var item = _cart.Items.FirstOrDefault(c => c.ProductId == productId);
            if (item != null)
            {
                item.Quantity -= quantity;
            }
        }
    }
}
