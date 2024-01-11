using Microsoft.EntityFrameworkCore;
using WeatherApp.AppCore.Models;
using WeatherApp.AppCore.DTO;
using WeatherApp.Infrastructure.Data;
using AutoMapper;

namespace WeatherApp.Infrastructure.Repository
{
    public class ClimatDayInfo_Repository : AbstractRepository<ClimatDayInfoDTO>
    {
        //Context _context;
        //IMapper _mapper;
        public ClimatDayInfo_Repository(Context context, IMapper mapper) : base(context, mapper) { }

        public override async Task<ClimatDayInfoDTO> GetInstanceAsync(Guid Id)
        {
            ClimateDayInfo instance = await _context.ClimateDayInfo.FirstOrDefaultAsync(e => e.ClimatDayInfo_ID == Id);
            ClimatDayInfoDTO dto = _mapper.Map<ClimatDayInfoDTO>(instance);
            return dto;
        }

        //public async override Task<ClimatDayInfoDTO> GetInstanceAsync(DateTime date)
        //{
        //    ClimatDayInfo? instance = await _context.ClimatDayInfo.FirstOrDefaultAsync(e => e.Day_Date == date);
        //    ClimatDayInfoDTO dto = _mapper.Map<ClimatDayInfoDTO>(instance);
        //    return dto;
        //}

        public override async Task<List<ClimatDayInfoDTO>> GetListAsync()
        {
            List<ClimateDayInfo> climates = await _context.ClimateDayInfo.ToListAsync();
            List<ClimatDayInfoDTO> dto = _mapper.Map<List<ClimatDayInfoDTO>>(climates);
            return dto.ToList();
        }


    }
}
