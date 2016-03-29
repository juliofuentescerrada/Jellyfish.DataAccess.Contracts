namespace Jellyfish.DataAccess.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IRepository<in TKey, TEntity>
    {
        // Create
        TEntity Create(TEntity entity);

        // Read
        TEntity Read(TKey key);

        IEnumerable<TEntity> Read();

        IEnumerable<TEntity> Read(Expression<Func<TEntity, bool>> where);

        // Update
        void Update(TEntity entity);

        // Delete
        void Delete(TKey key);

        void Delete(TEntity entity);
    }
}