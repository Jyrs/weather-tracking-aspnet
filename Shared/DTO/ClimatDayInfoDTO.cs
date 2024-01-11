

namespace WeatherApp.AppCore.DTO
{
    public class ClimatDayInfoDTO
    {
        public Guid ClimatDayInfo_ID { get; private set; }
        public Guid RegionID { get; private set; }
        public DateTime day_Date { get; private set; } = DateTime.MinValue;

    }
}
