using BankStatCore.Contracts.Repositories;
using BankStatCore.Contracts.Services;
using BankStatCore.Models;

namespace BankStatApplication.Services;

public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;

    public AccountService(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public IEnumerable<AccountModel> GetAll()
    {
        var accounts = _accountRepository.GetAll();
        return accounts;
    }

    public AccountModel GetById(string id)
    {
        var account = _accountRepository.GetById(id);
        return account;
    }

    public void Create(AccountModel model)
    {
        _accountRepository.Create(model);
    }

    public void Update(AccountModel model)
    {
        _accountRepository.Update(model);
    }

    public void Delete(AccountModel model)
    {
        _accountRepository.Delete(model);
    }

    public void DeleteById(string id)
    {
        _accountRepository.DeleteById(id);
    }
}