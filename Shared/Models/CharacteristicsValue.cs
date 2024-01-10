

namespace WeatherApp.AppCore.Models
{
    public class CharacteristicsValue
    {
        public int CharacteristicsValue_ID {  get; private set; }
        public int CharacteristicsType_ID {  get; private set; }
        public int ClimatDayInfo_ID {get; private set; }
        public DateTime MetaData_Date { get; private set; }

        public CharacteristicsValue()
        {
            CharacteristicsValue_ID = 0;
            CharacteristicsType_ID = 0;
            ClimatDayInfo_ID = 0;
            MetaData_Date = DateTime.MinValue;
        }

    }
}
