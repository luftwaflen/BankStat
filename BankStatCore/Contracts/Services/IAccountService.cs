using BankStatCore.Models;

namespace BankStatCore.Contracts.Services;

public interface IAccountService
{
    AccountModel Info(string id);
    IEnumerable<OperationModel> OperationsHistory(string accountId);
    void ExecuteOperation(string senderId, string recieverId, decimal amount, string curIso, string type);
}