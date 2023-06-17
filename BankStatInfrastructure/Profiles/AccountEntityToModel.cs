using AutoMapper;
using BankStatCore.Models;
using BankStatInfrastructure.Entities;

namespace BankStatInfrastructure.Profiles;

public class AccountEntityToModel : Profile
{
    public AccountEntityToModel()
    {
        CreateMap<AccountEntity, AccountModel>().ReverseMap();
    }
}