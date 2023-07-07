using AutoMapper;
using BankStatApi.RequestModels.Operations;
using BankStatApi.ResponseModels;
using BankStatCore.Contracts.Repositories;
using BankStatCore.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BankStatApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAccountService _accountService;
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;

        public AccountController(
            IAccountService accountService,
            IUserService userService,
            ICurrencyRepository currencyRepository,
            IMapper mapper
        )
        {
            _accountService = accountService;
            _userService = userService;
            _currencyRepository = currencyRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/account/")]
        [Authorize]
        public ActionResult<AccountResponce> Check(string id)
        {
            var accountModel = _accountService.Info(id);
            var account = _mapper.Map<AccountResponce>(accountModel);

            return Ok(accountModel);
        }

        [HttpPost]
        [Route("/account/deposit")]
        [Authorize]
        public ActionResult Deposit(DepositRequest req)
        {
            _accountService.ExecuteOperation(null, req.ReceiverId, req.Amount, req.CurIso, "deposit");
            return Ok("");
        }

        [HttpPost]
        [Route("/account/withdraw")]
        [Authorize]
        public ActionResult Withdraw(WithdrawRequest req)
        {
            _accountService.ExecuteOperation(null, req.ReceiverId, req.Amount, req.CurIso, "withdraw");
            return Ok("");
        }

        [HttpPost]
        [Route("/account/transaction")]
        [Authorize]
        public ActionResult Transaction(TransactionRequest req)
        {
            _accountService.ExecuteOperation(req.SenderId, req.ReceiverId, req.Amount, req.CurIso, "transaction");
            return Ok("");
        }

        [HttpGet]
        [Route("/user/history")]
        [Authorize]
        public ActionResult<IEnumerable<OperationResponse>> OperationsHistory(string accountId)
        {
            var operationModels = _accountService.OperationsHistory(accountId);
            var operations = _mapper.Map<List<OperationResponse>>(operationModels);

            return Ok(operations);
        }
    }
}