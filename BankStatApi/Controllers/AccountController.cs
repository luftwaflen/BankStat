using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankStatApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AccountModel>> GetAll()
        {
            return Ok(_accountRepository.GetAll());
        }

        [HttpPost]
        public ActionResult Create(AccountModel account)
        {
            _accountRepository.Create(account);
            return Ok();
        }

        [HttpPut]
        public ActionResult Update(AccountModel account)
        {
            _accountRepository.Update(account);
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(string id)
        {
            var deletedAccount = _accountRepository.GetById(id);
            _accountRepository.DeleteById(id);
            return Ok(deletedAccount);
        }
    }
}