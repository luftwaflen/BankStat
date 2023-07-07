using BankStatCore.Contracts.Repositories;
using BankStatCore.Contracts.Services;
using BankStatCore.Models;

namespace BankStatApplication.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IAccountRepository _accountRepository;
    private readonly ICurrencyRepository _currencyRepository;

    public UserService(
        IUserRepository userRepository,
        IAccountRepository accountRepository,
        ICurrencyRepository currencyRepository
    )
    {
        _userRepository = userRepository;
        _accountRepository = accountRepository;
        _currencyRepository = currencyRepository;
    }

    public UserModel FindByLogin(string login)
    {
        var user = _userRepository.GetByLogin(login);
        if (user is null) throw new InvalidDataException("User with this login does not exist");
        return user;
    }

    public UserModel Register(string login, string password)
    {
        try
        {
            var user = FindByLogin(login);
        }
        catch (Exception e)
        {
            var passwordHash = HashPassword(password);

            var newUser = new UserModel
            {
                Login = login,
                Password = passwordHash,
                Accounts = new List<AccountModel>()
            };

            _userRepository.Create(newUser);
            var logginedUser = Login(login, passwordHash);
            return logginedUser;
        }
        
        throw new InvalidDataException("User with same lorin already exists");
    }

    public UserModel Login(string login, string password)
    {
        if (CheckPassword(login, password))
        {
            var user = FindByLogin(login);
            return user;
        }

        throw new InvalidDataException("Wrong Login or Password");
    }

    public UserModel ChangePassword(string login, string oldPassword, string newPassword)
    {
        if (!CheckPassword(login, oldPassword)) throw new InvalidDataException("Wrong login or password");
        var user = FindByLogin(login);
        if (user is null) throw new InvalidDataException("Wrong login");

        var newPasswordHash = HashPassword(newPassword);
        user.Password = newPasswordHash;
        _userRepository.Update(user);

        return user;
    }

    public bool CheckPassword(string login, string password)
    {
        var user = FindByLogin(login);
        if (BCrypt.Net.BCrypt.Verify(password, user.Password)) return true;

        return false;
    }

    private string HashPassword(string password)
    {
        var passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
        return passwordHash;
    }

    public void CreateAccount(string login, string accountName, decimal amount, string curIso)
    {
        var user = FindByLogin(login);
        var currency = _currencyRepository.GetByIso(curIso);

        var accountModel = new AccountModel
        {
            Name = accountName,
            Amount = amount,
            Currency = currency,
            User = user
        };
        _accountRepository.Create(accountModel);
    }

    public void DeleteAccount(string login, string accountId)
    {
        var user = FindByLogin(login);
        var account = _accountRepository.GetById(accountId);
        if (user.Accounts.Contains(account))
        {
            _accountRepository.Delete(account);
        }

        throw new InvalidDataException();
    }

    public IEnumerable<AccountModel> GetAccounts(string userLogin)
    {
        var user = FindByLogin(userLogin);
        if (user is null) throw new InvalidDataException("");
        var accounts = user.Accounts;

        return accounts;
    }
}