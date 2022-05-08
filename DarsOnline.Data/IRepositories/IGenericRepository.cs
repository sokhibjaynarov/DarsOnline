using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DarsOnline.Data.IRepositories
{
    public interface IGenericRepository<TSource> where TSource : class
    {
        TSource Create(TSource entity);
        TSource Get(Expression<Func<TSource, bool>> predicate);
       
        IQueryable<TSource> GetAll(Expression<Func<TSource, bool>> predicate = null);
        bool Delete(Expression<Func<TSource, bool>> predicate);
        TSource Update(int Id, TSource entity);

    }
}
