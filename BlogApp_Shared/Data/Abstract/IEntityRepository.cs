using BlogApp_Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        Task<T> GetAsync(Expression<Func<T,bool>> predicate,params Expression<Func<T, object>>[] includeProperties);//var user=repository.GetAsync(k=>k.id==15) bana getir
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null
            , params Expression<Func<T, object>>[] includeProperties);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task Delete(T entity);
        Task<bool> Any(Expression<Func<T, bool>> predicate);
        Task<int> Count(Expression<Func<T, bool>> predicate);
    }
}
