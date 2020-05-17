using System.Collections.Generic;

namespace ProcessController.Data.Contexts
{
    public interface IPersistenceContext<TEntity> where TEntity : class
    {
        void Save(IEnumerable<TEntity> collection);

        IEnumerable<TEntity> Load();
    }
}