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
    }
}