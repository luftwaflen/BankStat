using BankStatCore.Models;
using Microsoft.EntityFrameworkCore;

namespace BankStatInfrastructure.EF
{
    public class BankContext : DbContext
    {
        public DbSet<AccountModel> Accounts { get; set; }
        public DbSet<AmountModel> Amounts { get; set; }
        public DbSet<OperationModel> Operations { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<ProductInfoModel> ProductInfos { get; set; }

        public BankContext(DbContextOptions<BankContext> options)
            : base(options) { }
    }
}
