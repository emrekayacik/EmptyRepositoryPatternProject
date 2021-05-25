using Project.Data.Abstract;
using Project.Entity.Category;
using System;
using System.Collections.Generic;

namespace Project.Data.Concrete.SQL
{
    public class SQLCategoryRepository : ICategoryRepository
    {
        public bool Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Category entity)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetPopularCategories()
        {
            throw new NotImplementedException();
        }
    }
}
