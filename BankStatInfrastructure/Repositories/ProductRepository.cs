using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories
{
    public class ProductRepository : BaseRepository<ProductModel>, IProductRepository
    {
        public ProductRepository(BankContext db)
            : base(db)
        {
        }

        public override IEnumerable<ProductModel> GetAll()
        {
            var products = _db.Products.ToList();
            return products;
        }
    }
}