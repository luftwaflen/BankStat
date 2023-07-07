using AutoMapper;
using BankStatApi.ResponseModels;
using BankStatCore.Models;

namespace BankStatApi.Profiles;

public class UserModelToRes : Profile
{
    public UserModelToRes()
    {
        CreateMap<UserModel, UserResponse>()
            .ForMember("Id", opt => opt.MapFrom(o => o.Id))
            .ForMember("Login", opt => opt.MapFrom(o => o.Login));
    }
}