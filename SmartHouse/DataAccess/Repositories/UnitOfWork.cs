using System;
using System.Threading.Tasks;
using DataAccess.Interfaces;

namespace DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext context;

        public UnitOfWork()
        {
            this.context = new DatabaseContext("DatabaseContext");
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

        private bool disposed = false;

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