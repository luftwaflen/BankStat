using BankStatCore.Contracts.Repositories;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories;

public abstract class BaseRepository<T> : IRepository<T> where T : class
{
    protected readonly BankContext _db;

    public BaseRepository(BankContext context)
    {
        _db = context;
    }

    public IEnumerable<T> GetAll()
    {
        var models = _db.Set<T>().ToList();
        return models;
    }

    public T GetById(string id)
    {
        var model = _db.Set<T>().Find(id);
        return model;
    }

    public void Create(T model)
    {
        _db.Set<T>().Add(model);
        _db.SaveChanges();
    }

    public void Update(T model)
    {
        _db.Set<T>().Update(model);
        _db.SaveChanges();
    }

    public void Delete(T model)
    {
        _db.Set<T>().Remove(model);
        _db.SaveChanges();
    }

    public void DeleteById(string id)
    {
        var model = GetById(id);
        Delete(model);
    }
}