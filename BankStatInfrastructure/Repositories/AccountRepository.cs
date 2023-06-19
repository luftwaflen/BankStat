using AutoMapper;
using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories
{
    public class AccountRepository : BaseRepository<AccountModel>, IAccountRepository
    {
        private readonly IMapper _mapper;

        public AccountRepository(BankContext db, IMapper mapper)
            : base(db)
        {
            _mapper = mapper;
        }

        public override IEnumerable<AccountModel> GetAll()
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
    }
}