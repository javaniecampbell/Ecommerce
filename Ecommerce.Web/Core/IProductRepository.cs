using Ecommerce.Web.Data;

namespace Ecommerce.Web.Core
{
    public interface IProductRepository
    {
        Product GetOne(int id);
        IEnumerable<Product> GetAll();

        int AddProduct(Product product);

        int UpdateProduct(Product product);

    }
}
