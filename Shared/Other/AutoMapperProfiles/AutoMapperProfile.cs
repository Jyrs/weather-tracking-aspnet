using AutoMapper;
using WeatherApp.AppCore.DTO;
using WeatherApp.AppCore.Models;

namespace WeatherApp.Shared.Other.AutoMapperProfiles
{
    internal class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<Weather, WeatherDTO>();
            CreateMap<Region, RegionDTO>();
            CreateMap<ClimatDayInfo, ClimatDayInfoDTO>();
            CreateMap<CharacteristicsValue, CharacteristicsValueDTO>();
            CreateMap<CharacteristicType, CharacteristicTypeDTO>();
        }
    }
}
