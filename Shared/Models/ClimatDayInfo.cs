

namespace WeatherApp.AppCore.Models
{
    public class ClimatDayInfo
    {
        public int ClimatDayInfo_ID { get; private set; }
        public int Region_ID { get; private set; }
        public DateTime Day_Date { get; private set; }


        public ClimatDayInfo()
        {
            ClimatDayInfo_ID = 0;
            Region_ID = 0;
            Day_Date = DateTime.MinValue;
        }
    }
}
