using Ecommerce.CheckoutAPI.Data.Entities;
using Ecommerce.CheckoutAPI.Domains;

namespace Ecommerce.Tests
{
    public class CartDomainUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_Be_Add_An_To_The_Cart()
        {
            // Arrange
           CartDomain sut = new CartDomain(new Cart());

            // Act
            var item = new CartItem
            {

                Id = 1,
                ProductId = 1,
                Quantity = 1,
                UnitPrice = 10
            };


            sut.AddToCart(item);
            // Assertions test case
            Assert.AreEqual(1, sut.Items.Count());
            
        }

        [Test]
        public void Increase_The_Quantity_For_A_Product_By_1()
        {
            var sut = new CartDomain(new Cart());

            var item = new CartItem
            {
                Id = 1,
                ProductId = 1,
                Quantity = 1,
                UnitPrice = 10
            };

            sut.AddToCart(item);
            sut.IncreaseQuantity(item.ProductId, 3);

            Assert.AreEqual(1, sut.Items.Count());
            Assert.AreEqual(4, sut.Items.First().Quantity);

        }
    }
}