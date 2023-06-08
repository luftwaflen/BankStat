namespace BankStatCore.Contracts.Repositories
{
    public interface IRepository<T>
    {
        public IEnumerable<T> GetAll();
        public Task<IEnumerable<T>> GetAllAsync();
        public T GetById(int id);
        public Task<T> GetByIdAsync(int id);
        public void Create(T model);
        public Task<T> CreateAsync(T model);
        public void Update(T model);
        public Task<T> UpdateAsync(T model);
        public void Delete(T model);
        public Task DeleteAsync(T model);
        public void DeleteById(int id);
        public void DeleteByIdAsync(int id);
    }
}
