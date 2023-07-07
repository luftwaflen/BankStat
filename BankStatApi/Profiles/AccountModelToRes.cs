using AutoMapper;
using BankStatApi.ResponseModels;
using BankStatCore.Models;

namespace BankStatApi.Profiles;

public class AccountModelToRes : Profile
{
    public AccountModelToRes()
    {
        CreateMap<AccountModel, AccountResponce>()
            .ForMember("Id", opt => opt.MapFrom(o => o.Id))
            .ForMember("Name", opt => opt.MapFrom(o => o.Name))
            .ForMember("Amount", opt => opt.MapFrom(o => o.Amount))
            .ForMember("CurIso", opt => opt.MapFrom(o => o.Currency.Iso));
    }
}