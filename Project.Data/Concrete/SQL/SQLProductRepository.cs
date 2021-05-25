using Project.Data.Abstract;
using Project.Entity.Product;
using System.Collections.Generic;

namespace Project.Data.Concrete.SQL
{
    public class SQLProductRepository : IProductRepository
    {
        public bool Create(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Edit(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product GetMostExpensiveProduct()
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetPopularProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}
