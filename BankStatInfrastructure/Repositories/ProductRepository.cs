using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly BankContext _db;

        public ProductRepository(BankContext db)
        {
            _db = db;
        }

        public IEnumerable<ProductModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ProductModel GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductModel> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public void Create(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductModel> CreateAsync(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductModel> UpdateAsync(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByIdAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
