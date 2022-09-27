using PI.Domain.Interfaces;
using PI.Infra.Data.Context;

namespace PI.Infra.Data.Repositories;

public class BaseRepository<T> : IBaseRepository<T>  where T : class
{
    private readonly ApplicationContext _context;

    public BaseRepository(ApplicationContext applicationContext)
    {
        _context = applicationContext;
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
        _context.SaveChanges();
    }

    public void RemoveById(int entityId)
    {
        _context.Set<T>().Remove(GetById(entityId));
        _context.SaveChanges();
    }

    public T GetById(int entityId)
    {
        return _context.Set<T>().Find(entityId);
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().AsEnumerable();
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
        _context.SaveChanges();
    }
}