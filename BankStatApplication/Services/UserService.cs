using BankStatCore.Contracts.Repositories;
using BankStatCore.Contracts.Services;
using BankStatCore.Models;

namespace BankStatApplication.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public IEnumerable<UserModel> GetAll()
    {
        var users = _userRepository.GetAll();
        return users;
    }

    public UserModel GetById(string id)
    {
        var user = _userRepository.GetById(id);
        return user;
    }

    public void Create(UserModel model)
    {
        _userRepository.Create(model);
    }

    public void Update(UserModel model)
    {
        _userRepository.Update(model);
    }

    public void Delete(UserModel model)
    {
        _userRepository.Delete(model);
    }

    public void DeleteById(string id)
    {
        _userRepository.DeleteById(id);
    }

    public void Register(UserModel user)
    {
        throw new NotImplementedException();
    }

    public void Login(UserModel user)
    {
        throw new NotImplementedException();
    }

    public void Logout()
    {
        throw new NotImplementedException();
    }
}