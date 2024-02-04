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

        public override Task AddInstanceAsync(ClimateDayInfoDTO obj)
        {
            throw new NotImplementedException();
        }

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

        public async Task<InfoDisplay?> GetInstanceAsync(string reg, DateTime date)
        {
            Region? searchRegID = await _context.Region.FirstOrDefaultAsync(e => e.Reg_name == reg);
            ClimateDayInfo? searchDayID = await _context.ClimateDayInfo.FirstOrDefaultAsync(e => e.day_date == date
                                                                                && e.RegionID == searchRegID.Reg_Id);
            if (searchRegID != null && searchDayID != null)
            {

                InfoDisplay display = new InfoDisplay();
                display.Region = searchRegID.Reg_name;
                display.Date = date;

                var infos = from charVal in _context.CharacteristicsValue
                            where searchDayID.ClimatDayInfo_ID == charVal.climat_info_dayID
                            join charType in _context.CharacteristicType on charVal.charaterisitcs_typeID equals charType.ID
                            select new
                            {
                                Date = searchDayID.day_date,
                                Reg = reg,
                                char_Type = charType.char_name,
                                char_Value = charVal.value,
                                char_Meassure = charType.char_unitOfMessure
                            };
                Tuple<string, string, string> characteristic_Tulpe;
                foreach (var info in infos)
                {
                    characteristic_Tulpe =
                        new Tuple<string, string, string>(info.char_Type, info.char_Value, info.char_Meassure);
                    display.char_Values.Add(characteristic_Tulpe);
                }
                return display;
            }
            else return new InfoDisplay();
        }

        public override async Task<IEnumerable<ClimateDayInfoDTO>> GetIEnumerableAsync()
        {

            List<ClimateDayInfo> climates = await _context.ClimateDayInfo.ToListAsync();
            List<ClimateDayInfoDTO> dto = _mapper.Map<List<ClimateDayInfoDTO>>(climates);
            return dto;
        }

        public override async Task<List<ClimateDayInfoDTO>> GetListAsync()
        {
            List<ClimateDayInfo> climates = await _context.ClimateDayInfo.ToListAsync();
            List<ClimateDayInfoDTO> dto = _mapper.Map<List<ClimateDayInfoDTO>>(climates);
            return dto;
        }

        public override Task<bool> Delete(List<ClimateDayInfoDTO> obj)
        {
            throw new NotImplementedException();
        }
    }
}
