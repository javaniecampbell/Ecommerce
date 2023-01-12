namespace Ecommerce.CheckoutAPI.Data.Entities
{
    public class CartItem
    {
        public CartItem()
        {
            Cart = new Cart();
        }
        public int Id { get; set; }
        public int CartId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }

        public Cart Cart { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
