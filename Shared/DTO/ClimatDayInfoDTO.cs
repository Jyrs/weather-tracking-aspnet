

namespace WeatherApp.AppCore.DTO
{
    public class ClimatDayInfoDTO
    {
        public int ClimatDayInfoDTO_ID { get; private set; }
        public int RegionDTO_ID { get; private set; }
        public DateTime DayDTO_Date { get; private set; }


        public ClimatDayInfoDTO()
        {
            ClimatDayInfoDTO_ID = 0;
            RegionDTO_ID = 0;
            DayDTO_Date = DateTime.MinValue;
        }
    }
}
