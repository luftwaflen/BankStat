using BankStatCore.Models;

namespace BankStatCore.Contracts.Repositories;

public interface ICurrencyRepository : IRepository<CurrencyModel>
{
    CurrencyModel GetByIso(string iso);
}