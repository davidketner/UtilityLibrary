using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace UtilityLibrary
{
    public interface IGenericRepository<TEntity, in TK> where TEntity : IBaseEntity<TK>
    {
        TEntity FindById(TK id);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TK id);

        void Delete(TEntity entity);

        IQueryable<TEntity> Items { get; }
    }

    public class GenericRepository<TEntity, TC, TK> : IGenericRepository<TEntity, TK>
    where TC : DbContext where TEntity : class, IBaseEntity<TK>
    {
        private readonly TC context;

        public GenericRepository(TC context)
        {
            this.context = context;
        }

        public virtual IQueryable<TEntity> Items => context.Set<TEntity>().AsNoTracking();

        public TEntity FindById(TK id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
        }

        public void Delete(TK id)
        {
            var entity = FindById(id);
            context.Set<TEntity>().Remove(entity);
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }
    }
}
