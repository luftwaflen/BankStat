using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories;

public class UserRepository : BaseRepository<UserModel>, IUserRepository
{
    public UserRepository(BankContext db)
        : base(db)
    {
    }

    public UserModel GetByLogin(string login)
    {
        var user = _db.Users.FirstOrDefault(u => u.Login == login);

        return user;
    }
}