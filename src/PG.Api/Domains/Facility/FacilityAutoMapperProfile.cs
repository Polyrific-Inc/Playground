using System.Data.Entity.Spatial;
using AutoMapper;

namespace PG.Api.Domains.Facility
{
    public class FacilityAutoMapperProfile : Profile
    {
        public FacilityAutoMapperProfile()
        {
            CreateMap<NewFacilityDto, Model.Facility>()
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => DbGeography.FromText(src.Location.AsText())));
            CreateMap<EditFacilityDto, Model.Facility>()
                .ForMember(dest => dest.Location,
                    opt => opt.MapFrom(src => DbGeography.FromText(src.Location.AsText())));
            CreateMap<FacilityDto, Model.Facility>().ReverseMap();
        }
    }
}