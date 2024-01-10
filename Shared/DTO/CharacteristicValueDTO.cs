

namespace WeatherApp.AppCore.DTO
{
    public class CharacteristicsValueDTO
    {
        public int CharacteristicsValueDTO_ID {  get; private set; }
        public int CharacteristicsTypeDTO_ID {  get; private set; }
        public int ClimatDayInfoDTO_ID { get; private set; }
        public DateTime MetaDataDTO_Date { get; private set; }

        public CharacteristicsValueDTO()
        {
            CharacteristicsValueDTO_ID = 0;
            CharacteristicsTypeDTO_ID = 0;
            ClimatDayInfoDTO_ID = 0;
            MetaDataDTO_Date = DateTime.MinValue;
        }

    }
}
