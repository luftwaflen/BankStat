using BankStatAlphaBankIntegration.Models.Responses;
using BankStatAlphaBankIntegration.Services.Interfaces;
using BankStatApi.RequestModels;
using BankStatCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankStatApi.Controllers;

[ApiController]
[Route("{controller}")]
public class ExchangeController : ControllerBase
{
    private readonly IAccountService _accountService;
    private readonly IAlphaExchangeService _alphaExchangeService;

    public ExchangeController(IAccountService accountService, IAlphaExchangeService alphaExchangeService)
    {
        _accountService = accountService;
        _alphaExchangeService = alphaExchangeService;
    }

    [HttpGet]
    [Route("/exchange/rates")]
    public ActionResult<AlphaRatesListResponse> GetCurrencyRates(string curOne, string curTwo)
    {
        var currPair = curOne + '/' + curTwo;
        return Ok();
    }
}