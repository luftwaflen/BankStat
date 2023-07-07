using BankStatCore.Models;
using Microsoft.EntityFrameworkCore;

namespace BankStatInfrastructure.EF;

public class BankContext : DbContext
{
    public DbSet<UserModel> Users { get; set; }
    public DbSet<AccountModel> Accounts { get; set; }
    public DbSet<CurrencyModel> Currencies { get; set; }
    public DbSet<OperationModel> Operations { get; set; }

    public BankContext(DbContextOptions<BankContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<UserModel>().Property(e => e.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<AccountModel>().Property(e => e.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<CurrencyModel>().Property(e => e.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<OperationModel>().Property(e => e.Id).ValueGeneratedOnAdd();

        modelBuilder.Entity<AccountModel>()
            .HasMany<OperationModel>()
            .WithMany();
    }
}