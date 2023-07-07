using System.Net.Http.Headers;
using BankStatAlphaBankIntegration.Models.Responses;
using BankStatAlphaBankIntegration.Services.Interfaces;

namespace BankStatAlphaBankIntegration.Services.Implementations;

public class AlphaAccountService : BaseAlphaService, IAlphaAccountService
{
    public async Task<AlphaAccountsListResponse> GetAccounts(string authToken)
    {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
        var res = await _client.GetAsync("");
        if (res.IsSuccessStatusCode)
        {
            var accounts = await res.Content.ReadAsAsync<AlphaAccountsListResponse>();
            return accounts;
        }

        throw new Exception($"{res.StatusCode}");
    }

    public async Task<AlphaAccountDetails> GetAccountInfo(string authToken, string accountNumber)
    {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
        var res = await _client.GetAsync($"{accountNumber}");
        if (res.IsSuccessStatusCode)
        {
            var accountInfo = await res.Content.ReadAsAsync<AlphaAccountDetails>();
            return accountInfo;
        }

        throw new Exception($"{res.StatusCode}");
    }

    public async Task<AlphaStatementResponse> GetAccountOperations(string authToken, string accountNumber)
    {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
        var res = await _client.GetAsync($"statement/?number={accountNumber}");
        if (res.IsSuccessStatusCode)
        {
            var accountOperations = await res.Content.ReadAsAsync<AlphaStatementResponse>();
            return accountOperations;
        }

        throw new Exception($"{res.StatusCode}");
    }
}