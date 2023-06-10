using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankStatApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductInfoController : ControllerBase
    {
        private readonly IProductInfoRepository _productInfoRepository;

        public ProductInfoController(IProductInfoRepository productInfoRepository)
        {
            _productInfoRepository = productInfoRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductInfoModel>> GetAll()
        {
            return Ok(_productInfoRepository.GetAll());
        }

        [HttpPost]
        public ActionResult Create(ProductInfoModel productInfo)
        {
            _productInfoRepository.Create(productInfo);
            return Ok();
        }

        [HttpPut]
        public ActionResult Update(ProductInfoModel productInfo)
        {
            _productInfoRepository.Update(productInfo);
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(string id)
        {
            var deletedProductInfo = _productInfoRepository.GetById(id);
            _productInfoRepository.DeleteById(id);
            return Ok(deletedProductInfo);
        }
    }
}