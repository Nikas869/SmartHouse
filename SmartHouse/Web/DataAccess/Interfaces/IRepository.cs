using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Web.DataAccess.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IList<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        TEntity GetById(object id);

        Task<TEntity> GetByIdAsync(object id);

        int Count(Func<TEntity, bool> filter = null);

        Task<int> CountAsync();

        void Insert(TEntity entity);

        void Update(TEntity entityToUpdate);

        void Delete(object id);

        void Delete(TEntity entityToDelete);
    }
}