

namespace WeatherApp.AppCore.DTO
{
    public class CharacteristicsValueDTO
    {
        public Guid ID { get; private set; }
        public Guid charateristics_typeID { get; private set; }
        public Guid climat_info_dayID { get; private set; }
        public string value { get; private set; } = string.Empty;
        public DateTime metaData_date { get; private set; } = DateTime.MinValue;

    }
}
