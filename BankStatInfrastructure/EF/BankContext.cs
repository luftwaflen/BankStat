using BankStatInfrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankStatInfrastructure.EF;

public class BankContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<AccountEntity> Accounts { get; set; }
    public DbSet<CurrencyEntity> Currencies { get; set; }
    public DbSet<OperationEntity> Operations { get; set; }
    public DbSet<ProductEntity> Products { get; set; }

    public BankContext(DbContextOptions<BankContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<UserEntity>().Property(e => e.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<AccountEntity>().Property(e => e.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<CurrencyEntity>().Property(e => e.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<OperationEntity>().Property(e => e.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<ProductEntity>().Property(e => e.Id).ValueGeneratedOnAdd();
        
        modelBuilder.Entity<ProductEntity>()
            .OwnsOne(e => e.ProductInfo);
        modelBuilder.Entity<AccountEntity>()
            .HasMany<OperationEntity>()
            .WithMany();
    }
}