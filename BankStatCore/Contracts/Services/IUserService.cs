using BankStatCore.Models;

namespace BankStatCore.Contracts.Services;

public interface IUserService
{
    UserModel FindByLogin(string login);
    UserModel Register(string login, string password);
    UserModel Login(string login, string password);
    bool CheckPassword(string login, string password);
    UserModel ChangePassword(string login, string oldPassword, string newPassword);
    void CreateAccount(string login, string accountName, decimal amount, string curIso);
    void DeleteAccount(string login, string accountId);
    IEnumerable<AccountModel> GetAccounts(string userLogin);
}