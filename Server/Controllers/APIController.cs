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
        private readonly CharacteristicsType_Repository _char_type_Repository;

        public APIController(Context context, IMapper mapper)
        {
            _climatDayInfo_Repository = new ClimatDayInfo_Repository(context, mapper);
            _region_Repository = new Region_Repository(context, mapper);
        }

        // GET api/API/climate_list
        [HttpGet("GetClimateList")]
        public async Task<ActionResult<IEnumerable<ClimateDayInfoDTO>>> GetClimateList()
        {
            try
            {
                var result = await _climatDayInfo_Repository.GetListAsync();
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
        public async Task<ActionResult<ClimateDayInfoDTO>> GetInstanceClimate(Guid id)
        {
            try
            {
                if (id == null)
                    return BadRequest();
                return await _climatDayInfo_Repository.GetInstanceAsync(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error getting Climat instance");
            }
        }

        [HttpGet("GetRegion/{id}")]
        public async Task<ActionResult<RegionDTO>> GetInstanceRegion(Guid id)
        {
            try
            {
                if (id == null)
                        return BadRequest();
                return await _region_Repository.GetInstanceAsync(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error getting Region instance");
            }
        }

        [HttpPost("PostRegion")]
        public async Task<ActionResult<RegionDTO>> PostInstanceRegion([FromBody] RegionDTO region)
        {
            try
            {
                if (region == null)
                    return BadRequest();
                var createdRegion = await _region_Repository.AddInstanceAsync(region);
                return CreatedAtAction(nameof(GetInstanceRegion),
                    new { id = createdRegion.Reg_Id}, createdRegion);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new region record");
            }
        }

        [HttpGet("GetCharList")]
        public async Task<ActionResult<IEnumerable<CharacteristicTypeDTO>>> GetCharList()
        {
            try
            {
                var result = await _char_type_Repository.GetListAsync();
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

        [HttpGet("GetDay/{regName}/{day}")]
        public async Task<ActionResult<IEnumerable<InfoDisplay>>> GetDay(string regName, DateTime day)
        {
            try
            {
                var result = await _climatDayInfo_Repository.GetInstanceAsync(regName, day);
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
