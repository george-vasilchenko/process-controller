using System.Collections.Generic;

namespace ProcessController.Contract
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        void Add(TEntity entity);
    }
}