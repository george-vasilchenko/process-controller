using System.Collections.Generic;

namespace ProcessController.Data.Repositories
{
    public interface IRepository<TEntity, TIdentity>
        where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(TIdentity id);

        void Add(TEntity entity);
    }
}