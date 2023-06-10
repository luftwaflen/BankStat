using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories
{
    public class ProductInfoRepository : BaseRepository<ProductInfoModel>, IProductInfoRepository
    {
        public ProductInfoRepository(BankContext db)
            : base(db)
        {
        }

        public override IEnumerable<ProductInfoModel> GetAll()
        {
            var productInfos = _db.ProductInfos.ToList();
            return productInfos;
        }
    }
}