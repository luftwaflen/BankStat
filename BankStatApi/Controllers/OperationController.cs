using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankStatApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperationController : ControllerBase
    {
        private readonly IOperationRepository _operationRepository;

        public OperationController(IOperationRepository operationRepository)
        {
            _operationRepository = operationRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<OperationModel>> GetAll()
        {
            return Ok(_operationRepository.GetAll());
        }

        [HttpPost]
        public ActionResult Create(OperationModel operation)
        {
            _operationRepository.Create(operation);
            return Ok();
        }

        [HttpPut]
        public ActionResult Update(OperationModel operation)
        {
            _operationRepository.Update(operation);
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(string id)
        {
            var deletedOperation = _operationRepository.GetById(id);
            _operationRepository.DeleteById(id);
            return Ok(deletedOperation);
        }
    }
}