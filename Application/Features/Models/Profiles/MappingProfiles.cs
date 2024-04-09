using Application.Features.Models.Queries.GetList;
using Application.Features.Models.Queries.GetListByDynamic;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Models.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Model, GetListModelListItemDto>()
            .ForMember(m => m.BrandName, opt => opt.MapFrom(m => m.Brand.Name))
            .ForMember(m => m.FuelName, opt => opt.MapFrom(m => m.Fuel.Name))
            .ForMember(m => m.TransmissionName, opt => opt.MapFrom(m => m.Transmission.Name))
            .ReverseMap();
        CreateMap<IPaginate<Model>, GetListResponse<GetListModelListItemDto>>().ReverseMap();

        CreateMap<Model, GetListByDynamicModelListItemDto>()
            .ForMember(m => m.BrandName, opt => opt.MapFrom(m => m.Brand.Name))
            .ForMember(m => m.FuelName, opt => opt.MapFrom(m => m.Fuel.Name))
            .ForMember(m => m.TransmissionName, opt => opt.MapFrom(m => m.Transmission.Name))
            .ReverseMap();
        CreateMap<IPaginate<Model>, GetListResponse<GetListByDynamicModelListItemDto>>().ReverseMap();
    }
}
