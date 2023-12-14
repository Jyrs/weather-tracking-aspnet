using AutoMapper;
using WeatherApp.Shared.DTO;

namespace WeatherApp.Shared.Other.AutoMapperProfiles
{
    internal class WeatherForecastProfile : Profile
    {
        public WeatherForecastProfile() {
            CreateMap<WeatherForecast, WeatherForecastDTO>();
        }
    }
}
