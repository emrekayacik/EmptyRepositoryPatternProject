using Project.Entity.Category;

namespace Project.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetPopularCategories();
    }
}
