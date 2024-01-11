

namespace WeatherApp.AppCore.DTO
{
    public class CharacteristicsValueDTO
    {
        public Guid CharacteristicsValue_ID { get; private set; }
        public Guid CharacteristicsType_ID { get; private set; }
        public Guid ClimatDayInfo_ID { get; private set; }
        public DateTime MetaData_Date { get; private set; } = DateTime.MinValue;

    }
}
