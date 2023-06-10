using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories
{
    public class AmountRepository : BaseRepository<AmountModel>, IAmountRepository
    {
        public AmountRepository(BankContext db)
            : base(db)
        {
        }

        public override IEnumerable<AmountModel> GetAll()
        {
            var amounts = _db.Amounts.ToList();
            return amounts;
        }
    }
}