using System;
using System.Threading.Tasks;
using Web.DataAccess.Interfaces;

namespace Web.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext context;
        private bool disposed = false;

        public UnitOfWork()
        {
            this.context = new DatabaseContext();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new Repository<TEntity>(this.context);
        }

        public void Save()
        {
            this.context.SaveChanges();
        }

        public Task SaveAsync()
        {
            return this.context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }
    }
}