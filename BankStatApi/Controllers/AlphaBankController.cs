using BankStatAlphaBankIntegration.Models.Responses;
using BankStatAlphaBankIntegration.Services.Implementations;
using BankStatAlphaBankIntegration.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BankStatApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AlphaBankController : ControllerBase
{
    private readonly IAlphaAccountService _alphaAccountService;

    public AlphaBankController(IAlphaAccountService alphaAccountService)
    {
        _alphaAccountService = alphaAccountService;
    }

    [HttpGet]
    [Route("/alpha/accounts/")]
    public async Task<ActionResult<AlphaAccountsListResponse>> GetAccounts(string authToken)
    {
        var accounts = await _alphaAccountService.GetAccounts(authToken);
        return Ok(accounts);
    }

    [HttpGet]
    [Route("alpha/account/")]
    public async Task<ActionResult<AlphaAccountDetails>> GetAccountInfo(string authToken, string accountNumber)
    {
        var accountInfo = await _alphaAccountService.GetAccountInfo(authToken, accountNumber);
        return Ok(accountInfo);
    }

    [HttpGet]
    [Route("alpha/account/operations")]
    public async Task<ActionResult<AlphaStatementResponse>> GetAccountOperations(string authToken, string accountNumber)
    {
        var accountOperations = await _alphaAccountService.GetAccountOperations(authToken, accountNumber);
        return Ok(accountOperations);
    }
}