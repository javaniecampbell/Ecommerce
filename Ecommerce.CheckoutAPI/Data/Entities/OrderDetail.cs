namespace Ecommerce.CheckoutAPI.Data.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        
        
        public decimal UnitPrice { get; set; }


        public OrderStatus Status { get; set; }
    }
}