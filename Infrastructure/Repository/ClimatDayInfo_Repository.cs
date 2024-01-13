using Microsoft.EntityFrameworkCore;
using WeatherApp.AppCore.Models;
using WeatherApp.AppCore.DTO;
using WeatherApp.Infrastructure.Data;
using AutoMapper;

namespace WeatherApp.Infrastructure.Repository
{
    public class ClimatDayInfo_Repository : AbstractRepository<ClimateDayInfoDTO>
    {
        //Context _context;
        //IMapper _mapper;
        public ClimatDayInfo_Repository(Context context, IMapper mapper) : base(context, mapper) { }

        public override async Task<ClimateDayInfoDTO> GetInstanceAsync(Guid Id)
        {
            ClimateDayInfo instance = await _context.ClimateDayInfo.FirstOrDefaultAsync(e => e.ClimatDayInfo_ID == Id);
            ClimateDayInfoDTO dto = _mapper.Map<ClimateDayInfoDTO>(instance);
            return dto;
        }

        public async Task<ClimateDayInfoDTO> GetInstanceAsync(DateTime date)
        {
            ClimateDayInfo? instance = await _context.ClimateDayInfo.FirstOrDefaultAsync(e => e.day_date == date);
            ClimateDayInfoDTO dto = _mapper.Map<ClimateDayInfoDTO>(instance);
            return dto;
        }

        public override async Task<IEnumerable<ClimateDayInfoDTO>> GetListAsync()
        {

            List<ClimateDayInfo> climates = await _context.ClimateDayInfo.ToListAsync();
            List<ClimateDayInfoDTO> dto = _mapper.Map<List<ClimateDayInfoDTO>>(climates);
            return dto;
        }


    }
}
