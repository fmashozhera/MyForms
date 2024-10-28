using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyForms.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyForms.Data.Repositories;

public class Repository<T> where T : class, IRepository<T>
{
    private MyFormsDbContext _context;
    private ILogger<Repository<T>> _logger;

    public Repository(MyFormsDbContext context,
        ILogger<Repository<T>> logger)
    {
        _context = context;
        _logger = logger;
    }
    public async Task Add(T t)
    {
        _logger.LogDebug($"Adding entity {t.GetType()}");
        await _context.Set<T>().AddAsync(t);
    }

    public async Task AddRange(IEnumerable<T> entities)
    {
        _logger.LogDebug($"Addinng multiple objects");
        await _context.AddRangeAsync(entities);
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
    {
        _logger.LogDebug("Finding entities using predicate");
        return _context.Set<T>().Where(predicate);
    }

    public async Task<T> Get(Guid id)
    {
        _logger.LogDebug("Finding entity with id {entityId}", id);
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>> List()
    {
        _logger.LogDebug("Getting all entities");
        return await _context.Set<T>().ToListAsync();
    }

    public async Task Remove(Guid id)
    {
        _logger.LogDebug("Removing entity with id {entityId}",id);
        var deletedEntity = await _context.Set<T>().FindAsync(id);
        _context.Set<T>().Remove(deletedEntity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _logger.LogDebug("Removing entities");
        _context.Set<T>().RemoveRange(entities);
    }
}
