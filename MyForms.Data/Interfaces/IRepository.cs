using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyForms.Data.Interfaces;

public interface IRepository<T> where T : class
{
    Task Add(T t);
    Task<T> Get(Guid id);
    Task<IEnumerable<T>> List();
    Task Remove(Guid id);     
    IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    Task AddRange(IEnumerable<T> entities);
    void RemoveRange(IEnumerable<T> entities);
}
