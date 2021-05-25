using Project.Data.Abstract;
using Project.Entity.Product;
using System.Collections.Generic;
using System.Linq;

namespace Project.Data.Concrete.EF
{
    public class EFProductRepository : EFRepository<Product, ShopContext>, IProductRepository
    {
        public Product GetMostExpensiveProduct()
        {
            using (var context = new ShopContext())
            {
                return context.Products.OrderByDescending(x => x.Price).First();
            }
        }

        public List<Product> GetPopularProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}
