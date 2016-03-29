namespace Jellyfish.DataAccess.Contracts
{
    public interface IUnitOfWork
    {
        IRepository<TKey, TEntity> Repository<TKey, TEntity>();

        void SaveChanges();
    }
}