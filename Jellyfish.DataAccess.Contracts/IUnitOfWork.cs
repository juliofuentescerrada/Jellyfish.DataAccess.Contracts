namespace Jellyfish.DataAccess.Contracts
{
    using System.Threading.Tasks;

    public interface IUnitOfWork
    {
        IRepository<TKey, TEntity> Repository<TKey, TEntity>();

        Task SaveChanges();
    }
}