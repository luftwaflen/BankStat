using BankStatCore.Contracts.Repositories;
using BankStatCore.Contracts.Services;
using BankStatCore.Models;

namespace BankStatApplication.Services;

public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;
    private readonly IOperationService _operationService;
    private readonly ICurrencyRepository _currencyRepository;

    private readonly Dictionary<string, Action<AccountModel, AccountModel, decimal, CurrencyModel>>
        _operationsDictionary;

    public AccountService(
        IAccountRepository accountRepository,
        ICurrencyRepository currencyRepository,
        IOperationService operationService
    )
    {
        _accountRepository = accountRepository;
        _currencyRepository = currencyRepository;
        _operationService = operationService;
        _operationsDictionary = new Dictionary<string, Action<AccountModel, AccountModel, decimal, CurrencyModel>>
        {
            { "deposit", _operationService.Deposit },
            { "withdraw", _operationService.Withdraw }
        };
    }

    public AccountModel Info(string id)
    {
        return _accountRepository.GetById(id);
    }

    public IEnumerable<OperationModel> OperationsHistory(string accountId)
    {
        return _operationService.OperationsHistory(accountId);
    }

    public void ExecuteOperation(string senderId, string receiverId, decimal amount, string curIso,
        string type)
    {
        var sender = _accountRepository.GetById(senderId);
        var receiver = _accountRepository.GetById(receiverId);
        var currency = _currencyRepository.GetByIso(curIso);

        var operation = _operationsDictionary[type];
        operation.Invoke(sender, receiver, amount, currency);
    }
}