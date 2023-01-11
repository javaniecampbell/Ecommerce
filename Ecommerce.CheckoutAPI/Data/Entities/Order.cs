namespace Ecommerce.CheckoutAPI.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime? PlaceOn { get; set; }
        public DateTime? FulfilledOn { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
