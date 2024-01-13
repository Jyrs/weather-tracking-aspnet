using AutoMapper;
using WeatherApp.AppCore.DTO;
using WeatherApp.AppCore.Models;

namespace WeatherApp.Infrastructure.Other.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Region, RegionDTO>().ReverseMap();
            CreateMap<ClimateDayInfo, ClimateDayInfoDTO>();
            CreateMap<CharacteristicsValue, CharacteristicsValueDTO>();
            CreateMap<CharacteristicType, CharacteristicTypeDTO>();
        }
    }
}
