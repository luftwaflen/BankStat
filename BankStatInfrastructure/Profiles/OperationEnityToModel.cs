using AutoMapper;
using BankStatCore.Models;
using BankStatInfrastructure.Entities;

namespace BankStatInfrastructure.Profiles;

public class OperationEnityToModel : Profile
{
    public OperationEnityToModel()
    {
        CreateMap<OperationEntity, OperationModel>().ReverseMap();
    }
}