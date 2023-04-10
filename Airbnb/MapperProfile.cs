using AutoMapper;
using Airbnb.Models;
using Airbnb.Models.DTO;

namespace Airbnb
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Location, LocationDTO>().
                ForMember(dest => dest.ImageURL, opt => opt.
                MapFrom(src => src.Images.FirstOrDefault(img => img.IsCover).URL));
            CreateMap<Location, Location2DTO>().
                ForMember(dest => dest.ImageURL, opt => opt.
                MapFrom(src => src.Images.FirstOrDefault(img => img.IsCover).URL)).
                ForMember(dest => dest.Price, opt => opt.
                MapFrom(src => src.PricePerDay));
            CreateMap<Location, PriceDTO>().
                ForMember(dest => dest.Price, opt => opt.
                MapFrom(src => src.PricePerDay));
            //CreateMap<Location, DetailsDTO>()
            //    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => (int)src.Type))
            //    .ForMember(dest => dest.Features, opt => opt.MapFrom(src => (int)src.Features))
            //    .ForMember(dest => dest.Landlord, opt => opt.Ignore())
            //    .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images));
        }
    }
}
