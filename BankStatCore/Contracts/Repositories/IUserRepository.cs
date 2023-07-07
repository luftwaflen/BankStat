using BankStatCore.Models;

namespace BankStatCore.Contracts.Repositories;

public interface IUserRepository : IRepository<UserModel>
{
    UserModel GetByLogin(string login);
}