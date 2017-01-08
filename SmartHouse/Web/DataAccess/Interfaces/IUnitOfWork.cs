using System;
using System.Threading.Tasks;

namespace Web.DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        void Save();

        Task SaveAsync();
    }
}
