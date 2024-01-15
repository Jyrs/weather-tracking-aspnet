using Microsoft.AspNetCore.Http;
using WeatherApp.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Infrastructure.Data;
using AutoMapper;
using WeatherApp.AppCore.DTO;
using WeatherApp.AppCore.Models;

namespace WeatherApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class APIController : ControllerBase
    {
        private readonly ClimatDayInfo_Repository _climatDayInfo_Repository;
        private readonly Region_Repository _region_Repository;

        public APIController(Context context, IMapper mapper)
        {
            _climatDayInfo_Repository = new ClimatDayInfo_Repository(context, mapper);
            _region_Repository = new Region_Repository(context, mapper);
        }

        // GET api/API/climate_list
        [HttpGet("GetClimateList")]
        public async Task<IEnumerable<ClimateDayInfoDTO>> GetClimateList()
        {
            return await _climatDayInfo_Repository.GetListAsync();
        }

        // GET api/API/regions_list
        [HttpGet("GetRegionsList")]
        public async Task<ActionResult<IEnumerable<RegionDTO>>> GetRegionList()
        {
            try
            {
                var result = await _region_Repository.GetListAsync();
                if (result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }        
        }

        [HttpGet("GetClimate/{id}")]
        public async Task<ClimateDayInfoDTO> GetInstanceClimat(Guid id)
        {
            return await _climatDayInfo_Repository.GetInstanceAsync(id);
        }

        [HttpGet("GetRegion/{id}")]
        public async Task<RegionDTO> GetInstanceRegions(Guid id)
        {
            return await _region_Repository.GetInstanceAsync(id);
        }

        [HttpPost("PostRegion")]
        public async Task<ActionResult<RegionDTO>> PostInstanceRegion([FromBody] RegionDTO region)
        {
            try
            {
                if (region == null)
                    return BadRequest();
                var createdRegion = await _region_Repository.AddInstanceAsync(region);
                return CreatedAtAction(nameof(GetInstanceRegions),
                    new { id = createdRegion.Reg_Id}, createdRegion);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new region record");
            }
        }


        [HttpDelete("DeleteRegions")]
        public async Task<ActionResult<IEnumerable<RegionDTO>>> DeleteRegion([FromBody] List<RegionDTO> regions)
        {
            try
            {
                var result = await _region_Repository.Delete(regions);
                if (result == false)
                    return NotFound();
                return Ok(regions);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

    }
}
