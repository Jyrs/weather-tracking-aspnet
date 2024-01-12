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

        //public async override Task<ClimatDayInfoDTO> GetInstanceAsync(DateTime date)
        //{
        //    ClimatDayInfo? instance = await _context.ClimatDayInfo.FirstOrDefaultAsync(e => e.Day_Date == date);
        //    ClimatDayInfoDTO dto = _mapper.Map<ClimatDayInfoDTO>(instance);
        //    return dto;
        //}

        public override async Task<IEnumerable<ClimateDayInfoDTO>> GetListAsync()
        {

            List<ClimateDayInfo> climates = await _context.ClimateDayInfo.ToListAsync();
            List<ClimateDayInfoDTO> dto = _mapper.Map<List<ClimateDayInfoDTO>>(climates);
            return dto;
        }


    }
}
