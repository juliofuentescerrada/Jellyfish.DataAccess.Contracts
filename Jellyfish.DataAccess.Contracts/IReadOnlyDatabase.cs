namespace Jellyfish.DataAccess.Contracts
{
    using System.Linq;

    public interface IReadOnlyDatabase
    {
        IQueryable<TEntity> Set<TEntity>() where TEntity : class;
    }
}