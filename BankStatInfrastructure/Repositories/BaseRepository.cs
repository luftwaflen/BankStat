using BankStatCore.Contracts.Repositories;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T>
    {
        protected readonly BankContext _db;

        public BaseRepository(BankContext db)
        {
            _db = db;
        }

        public abstract IEnumerable<T> GetAll();

        public T GetById(string id)
        {
            var model = (T)_db.Find(typeof(T), id);
            return model;
        }

        public void Create(T model)
        {
            _db.Add(model);
            _db.SaveChanges();
        }

        public void Update(T model)
        {
            _db.Update(model);
            _db.SaveChanges();
        }

        public void Delete(T model)
        {
            _db.Remove(model);
            _db.SaveChanges();
        }

        public void DeleteById(string id)
        {
            var account = GetById(id);
            Delete(account);
        }
    }
}