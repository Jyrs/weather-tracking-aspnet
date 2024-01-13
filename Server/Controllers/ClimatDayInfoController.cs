using Microsoft.AspNetCore.Http;
using WeatherApp.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Infrastructure.Data;
using AutoMapper;
using WeatherApp.AppCore.DTO;

namespace WeatherApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClimatDayInfoController : ControllerBase
    {
        private readonly ClimatDayInfo_Repository _climatDayInfo_Repository;
        private readonly Region_Repository _region_Repository;

        public ClimatDayInfoController(Context context, IMapper mapper)
        {
            _climatDayInfo_Repository = new ClimatDayInfo_Repository(context, mapper);
            _region_Repository = new Region_Repository(context, mapper);
        }

        // GET api/ClimatDayInfo/climate_list
        [HttpGet("climate_list")]
        public async Task<IEnumerable<ClimateDayInfoDTO>> GetClimatList()
        {
            return await _climatDayInfo_Repository.GetListAsync();
        }

        // GET api/ClimatDayInfo/regions_list
        [HttpGet("regions_list")]
        public async Task<IEnumerable<RegionDTO>> GetRegionList()
        {
            return await _region_Repository.GetListAsync();
        }

        [HttpGet("climate/{id}")]
        public async Task<ClimateDayInfoDTO> GetInstanceClimat(Guid id)
        {
            return await _climatDayInfo_Repository.GetInstanceAsync(id);
        }

        [HttpGet("region/{id}")]
        public async Task<RegionDTO> GetInstanceRegions(Guid id)
        {
            return await _region_Repository.GetInstanceAsync(id);
        }


        [HttpDelete("{id}")]
        public async Task<ClimateDayInfoDTO> Delete(Guid id)
        {
            return await _climatDayInfo_Repository.GetInstanceAsync(id);
        }

    }
}
