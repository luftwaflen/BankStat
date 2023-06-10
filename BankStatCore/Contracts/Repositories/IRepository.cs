﻿namespace BankStatCore.Contracts.Repositories
{
    public interface IRepository<T>
    {
        public IEnumerable<T> GetAll();
        public Task<IEnumerable<T>> GetAllAsync();
        public T GetById(string id);
        public Task<T> GetByIdAsync(string id);
        public void Create(T model);
        public Task<T> CreateAsync(T model);
        public void Update(T model);
        public Task<T> UpdateAsync(T model);
        public void Delete(T model);
        public Task DeleteAsync(T model);
        public void DeleteById(string id);
        public void DeleteByIdAsync(string id);
    }
}
