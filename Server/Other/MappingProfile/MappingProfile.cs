using AutoMapper;
using WeatherApp.AppCore.DTO;
using WeatherApp.AppCore.Models;

namespace WeatherApp.Shared.Other.MappingProfile
{
    internal class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Weather, WeatherDTO>();
            CreateMap<Region, RegionDTO>();
            CreateMap<ClimatDayInfo, ClimatDayInfoDTO>();
            CreateMap<CharacteristicsValue, CharacteristicsValueDTO>();
            CreateMap<CharacteristicType, CharacteristicTypeDTO>();
        }
    }
}
