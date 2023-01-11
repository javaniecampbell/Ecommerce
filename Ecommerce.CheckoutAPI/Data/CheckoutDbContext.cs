using Ecommerce.CheckoutAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.CheckoutAPI.Data
{
    public class CheckoutDbContext : DbContext
    {

        public CheckoutDbContext(DbContextOptions<CheckoutDbContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
