using AutoMapper;
using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;
using BankStatInfrastructure.Entities;

namespace BankStatInfrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IMapper _mapper;
    private readonly BankContext _db;

    public UserRepository(BankContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public IEnumerable<UserModel> GetAll()
    {
        var userEntities = _db.Accounts.ToList();

        var users = new List<UserModel>();
        foreach (var userEntity in userEntities)
        {
            var user = _mapper.Map<UserModel>(userEntity);
            users.Add(user);
        }

        return users;
    }

    public UserModel GetById(string id)
    {
        var userEntity = _db.Users.FirstOrDefault(e => e.Id == id);
        var user = _mapper.Map<UserModel>(userEntity);
        return user;
    }

    public void Create(UserModel model)
    {
        var userEntity = _mapper.Map<UserEntity>(model);
        _db.Users.Add(userEntity);
        _db.SaveChanges();
    }

    public void Update(UserModel model)
    {
        var userEntity = _mapper.Map<UserEntity>(model);
        _db.Users.Update(userEntity);
        _db.SaveChanges();
    }

    public void Delete(UserModel model)
    {
        var userEntity = _mapper.Map<UserEntity>(model);
        _db.Users.Remove(userEntity);
        _db.SaveChanges();
    }

    public void DeleteById(string id)
    {
        var userEntity = _db.Users.FirstOrDefault(e => e.Id == id);
        _db.Users.Remove(userEntity);
        _db.SaveChanges();
    }
}