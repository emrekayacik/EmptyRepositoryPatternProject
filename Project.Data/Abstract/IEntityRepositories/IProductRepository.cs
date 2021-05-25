using Project.Entity.Product;
using System.Collections.Generic;

namespace Project.Data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetPopularProducts();
        Product GetMostExpensiveProduct();
    }
}
