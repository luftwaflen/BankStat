using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories
{
    public class AccountRepository : BaseRepository<AccountModel>, IAccountRepository
    {
        public AccountRepository(BankContext db)
            : base(db)
        {
        }

        public override IEnumerable<AccountModel> GetAll()
        {
            var accounts = _db.Accounts.ToList();
            return accounts;
        }
    }
}