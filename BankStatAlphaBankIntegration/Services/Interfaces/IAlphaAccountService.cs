using BankStatAlphaBankIntegration.Models.Responses;
using BankStatCore.Models;

namespace BankStatAlphaBankIntegration.Services.Interfaces;

public interface IAlphaAccountService
{
    Task<AlphaAccountsListResponse> GetAccounts(string authToken);
    Task<AlphaAccountDetails> GetAccountInfo(string authToken, string accountNumber);
    Task<AlphaStatementResponse> GetAccountOperations(string authToken, string accountNumber);
}