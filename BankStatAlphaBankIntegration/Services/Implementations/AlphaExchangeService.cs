using BankStatAlphaBankIntegration.Models.Responses;
using BankStatAlphaBankIntegration.Services.Interfaces;

namespace BankStatAlphaBankIntegration.Services.Implementations;

public class AlphaExchangeService : BaseAlphaService, IAlphaExchangeService
{
    public AlphaExchangeService()
        : base()
    {
    }

    public AlphaRatesListResponse Rates(string token, string currPair)
    {
        throw new NotImplementedException();
    }
}