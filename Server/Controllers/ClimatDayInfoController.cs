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

        public ClimatDayInfoController(Context context, IMapper mapper)
        {
            _climatDayInfo_Repository = new ClimatDayInfo_Repository(context, mapper);
        }

        // GET
        [HttpGet]
        public async Task<IEnumerable<ClimateDayInfoDTO>> Get()
        {
            return await _climatDayInfo_Repository.GetListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ClimateDayInfoDTO> Get(Guid id)
        {
            return await _climatDayInfo_Repository.GetInstanceAsync(id);
        }

        [HttpPost("{id}")]
        public async Task<ClimateDayInfoDTO> Post(Guid id)
        {
            return await _climatDayInfo_Repository.GetInstanceAsync(id);
        }

        [HttpDelete("{id}")]
        public async Task<ClimateDayInfoDTO> Delete(Guid id)
        {
            return await _climatDayInfo_Repository.GetInstanceAsync(id);
        }

    }
}
