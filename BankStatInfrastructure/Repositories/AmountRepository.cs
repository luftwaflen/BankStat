using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories
{
    public class AmountRepository : IAmountRepository
    {
        private readonly BankContext _db;

        public AmountRepository(BankContext db)
        {
            _db = db;
        }

        public IEnumerable<AmountModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AmountModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public AmountModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<AmountModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(AmountModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<AmountModel> CreateAsync(AmountModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(AmountModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<AmountModel> UpdateAsync(AmountModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(AmountModel model)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(AmountModel model)
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
