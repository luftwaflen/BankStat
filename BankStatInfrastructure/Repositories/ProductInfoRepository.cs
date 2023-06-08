using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories
{
    public class ProductInfoRepository : IProductInfoRepository
    {
        private readonly BankContext _db;

        public ProductInfoRepository(BankContext db)
        {
            _db = db;
        }

        public IEnumerable<ProductInfoModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductInfoModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ProductInfoModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductInfoModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(ProductInfoModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductInfoModel> CreateAsync(ProductInfoModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductInfoModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductInfoModel> UpdateAsync(ProductInfoModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductInfoModel model)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(ProductInfoModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
