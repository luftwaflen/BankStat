using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankStatApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AmountController : ControllerBase
    {
        private readonly IAmountRepository _amountRepository;

        public AmountController(IAmountRepository amountRepository)
        {
            _amountRepository = amountRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AmountModel>> GetAll()
        {
            return Ok(_amountRepository.GetAll());
        }

        [HttpPost]
        public ActionResult Create(AmountModel amount)
        {
            _amountRepository.Create(amount);
            return Ok();
        }

        [HttpPut]
        public ActionResult Update(AmountModel amount)
        {
            _amountRepository.Update(amount);
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(string id)
        {
            var deletedAmount = _amountRepository.GetById(id);
            _amountRepository.DeleteById(id);
            return Ok(deletedAmount);
        }
    }
}