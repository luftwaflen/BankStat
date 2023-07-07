using BankStatCore.Models;

namespace BankStatCore.Contracts.Services;

public interface IOperationService
{
    IEnumerable<OperationModel> OperationsHistory(string accountId);
    void Deposit(AccountModel sender, AccountModel receiver, decimal amount, CurrencyModel cur);
    void Withdraw(AccountModel sender, AccountModel receiver, decimal amount, CurrencyModel cur);
    void Transaction(AccountModel sender, AccountModel receiver, decimal amount, CurrencyModel cur);
}