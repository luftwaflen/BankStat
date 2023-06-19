using BankStatCore.Models;

namespace BankStatCore.Contracts.Services;

public interface IUserService : IService<UserModel>
{
    public void Register(UserModel user);
    public void Login(UserModel user);
    public void Logout();
}