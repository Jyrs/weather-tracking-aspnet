using AutoMapper;
using WeatherApp.AppCore.DTO;
using WeatherApp.AppCore.Models;

namespace WeatherApp.AppCore.Other.AutoMapperProfiles
{
    internal class WeatherForecastProfile : Profile
    {
        public WeatherForecastProfile() {
            CreateMap<WeatherForecast, WeatherDTO>();
        }
    }
}
