using AutoMapper;
using BankStatCore.Models;
using BankStatInfrastructure.Entities;

namespace BankStatInfrastructure.Profiles;

public class UserEntityToModel : Profile
{
    public UserEntityToModel()
    {
        CreateMap<UserEntity, UserModel>().ReverseMap();
    }
}