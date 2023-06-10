using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankContext _db;

        public AccountRepository(BankContext db)
        {
            _db = db;
        }

        public IEnumerable<AccountModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AccountModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public AccountModel GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<AccountModel> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public void Create(AccountModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<AccountModel> CreateAsync(AccountModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(AccountModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<AccountModel> UpdateAsync(AccountModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(AccountModel model)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(AccountModel model)
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
