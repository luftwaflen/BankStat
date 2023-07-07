using AutoMapper;
using BankStatApi.ResponseModels;
using BankStatCore.Models;

namespace BankStatApi.Profiles;

public class OperationModelToRes : Profile
{
    public OperationModelToRes()
    {
        CreateMap<OperationModel, OperationResponse>()
            .ForMember("Id", opt => opt.MapFrom(o => o.Id))
            .ForMember("Amount", opt => opt.MapFrom(o => o.Amount))
            .ForMember("SenderId", opt => opt.MapFrom(o => o.Sender.Id))
            .ForMember("ReceiverId", opt => opt.MapFrom(o => o.Receiver.Id))
            .ForMember("Type", opt => opt.MapFrom(o => o.Type))
            .ForMember("CurIso", opt => opt.MapFrom(o => o.Currency.Iso));
    }
}