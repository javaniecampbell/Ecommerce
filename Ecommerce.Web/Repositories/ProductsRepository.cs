using Ecommerce.Web.Core;
using Ecommerce.Web.Data;

namespace Ecommerce.Web.Repositories
{
    public class ProductsRepository : IProductRepository
    {
        readonly static List<Product> products = new List<Product>();
        public ProductsRepository() { }

        public int AddProduct(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return product.Id;
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product GetOne(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public int UpdateProduct(Product product)
        {
            // find the product by id then update the values
            var temp = GetOne(product.Id);
            temp.Id = product.Id;
            temp.Name = product.Name;
            temp.UnitPrice = product.UnitPrice;
            temp.Description = product.Description;

           int index = products.IndexOf(product);
            products.RemoveAt(index);
            products.Insert(index, temp);
            return temp.Id;
        }
    }
}
