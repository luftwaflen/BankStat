using BankStatAlphaBankIntegration.Models.Responses;

namespace BankStatAlphaBankIntegration.Services.Interfaces;

public interface IAlphaExchangeService
{
    AlphaRatesListResponse Rates(string token, string currPair);
}