namespace Ecommerce.CheckoutAPI.Data.Entities
{
    public class Cart
    {
        public Cart()
        {
            Items= new List<CartItem>();
        }
        public int Id { get; set; }
        public List<CartItem> Items { get; set; }
        public decimal Total { get; set; }
    }
}
