using System.Collections.Generic;

namespace Project.Data.Abstract
{
    public interface IRepository<TEntity>
    {
        TEntity GetById(int id);
        List<TEntity> GetAll();

        bool Create(TEntity entity);
        bool Edit(TEntity entity);
        bool Delete(TEntity entity);
    }
}
