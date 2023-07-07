using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories;

public class CurrencyRepository : BaseRepository<CurrencyModel>, ICurrencyRepository
{
    public CurrencyRepository(BankContext db)
        : base(db)
    {
    }

    public CurrencyModel GetByIso(string iso)
    {
        var currency = _db.Currencies.FirstOrDefault(c => c.Iso == iso);

        return currency;
    }
}