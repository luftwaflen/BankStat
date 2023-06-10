using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankStatApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductModel>> GetAll()
        {
            return Ok(_productRepository.GetAll());
        }

        [HttpPost]
        public ActionResult Create(ProductModel product)
        {
            _productRepository.Create(product);
            return Ok();
        }

        [HttpPut]
        public ActionResult Update(ProductModel product)
        {
            _productRepository.Update(product);
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(string id)
        {
            var deletedProduct = _productRepository.GetById(id);
            _productRepository.DeleteById(id);
            return Ok(deletedProduct);
        }
    }
}