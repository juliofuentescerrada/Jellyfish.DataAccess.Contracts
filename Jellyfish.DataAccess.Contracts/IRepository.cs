namespace Jellyfish.DataAccess.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IRepository<in TKey, TEntity>
    {
        // Create
        Task<TEntity> Create(TEntity entity);

        // Read
        Task<TEntity> Read(TKey key);

        Task<IEnumerable<TEntity>> Read();

        Task<IEnumerable<TEntity>> Read(Expression<Func<TEntity, bool>> where);

        // Update
        Task Update(TEntity entity);

        // Delete
        Task Delete(TKey key);

        Task Delete(TEntity entity);
    }
}