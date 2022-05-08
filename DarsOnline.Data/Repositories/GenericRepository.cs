using DarsOnline.Data.Contexts;
using DarsOnline.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DarsOnline.Data.Repositories
{
    public class GenericRepository<TSource> : IGenericRepository<TSource> where TSource : class
    {
        protected AppDbContext appDbContext;
        internal DbSet<TSource> dbSet { get; set; }
        public GenericRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            this.dbSet = appDbContext.Set<TSource>();
        }
        public TSource Create(TSource entity)
        {
            TSource result = dbSet.Add(entity).Entity;

            appDbContext.SaveChanges();

            return entity;
        }

        public bool Delete(Expression<Func<TSource, bool>> predicate)
        {
            TSource entity = dbSet.FirstOrDefault(predicate);
            if (entity == null)
                return false;

            dbSet.Remove(entity);
            appDbContext.SaveChanges();

            return true;
        }

        public TSource Get(Expression<Func<TSource, bool>> predicate)
        {
            return dbSet.FirstOrDefault(predicate);
        }

        public IQueryable<TSource> GetAll(Expression<Func<TSource, bool>> predicate = null)
        {
            return predicate == null ? dbSet : dbSet.Where(predicate);
        }

        public TSource Update(int Id, TSource entity)
        {
            TSource result = dbSet.Update(entity).Entity;

            appDbContext.SaveChanges();

            return result;
        }
    }
}
