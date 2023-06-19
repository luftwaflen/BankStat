using AutoMapper;
using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;
using BankStatInfrastructure.Entities;

namespace BankStatInfrastructure.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IMapper _mapper;
        private readonly BankContext _db;

        public AccountRepository(BankContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public IEnumerable<AccountModel> GetAll()
        {
            var accountEntities = _db.Accounts.ToList();

            var accounts = new List<AccountModel>();
            foreach (var accountEntity in accountEntities)
            {
                var account = _mapper.Map<AccountModel>(accountEntity);
                accounts.Add(account);
            }

            return accounts;
        }

        public AccountModel GetById(string id)
        {
            var accountEntity = _db.Accounts.FirstOrDefault(e => e.Id == id);
            var account = _mapper.Map<AccountModel>(accountEntity);
            return account;
        }

        public void Create(AccountModel model)
        {
            var accountEntity = _mapper.Map<AccountEntity>(model);
            _db.Accounts.Add(accountEntity);
            _db.SaveChanges();
        }

        public void Update(AccountModel model)
        {
            var accountEntity = _mapper.Map<AccountEntity>(model);
            _db.Accounts.Update(accountEntity);
            _db.SaveChanges();
        }

        public void Delete(AccountModel model)
        {
            var accountEntity = _mapper.Map<AccountEntity>(model);
            _db.Accounts.Remove(accountEntity);
            _db.SaveChanges();
        }

        public void DeleteById(string id)
        {
            var account = _db.Accounts.FirstOrDefault(e => e.Id == id);
            _db.Accounts.Remove(account);
            _db.SaveChanges();
        }
    }
}