namespace WeatherApp.AppCore.Models
{
    public class CharacteristicType
    {
        public Guid CharacteristicType_ID { get; private set; }
        public string CharacteristicType_Name { get; private set; } = string.Empty;
        public string CharacteristicType_UnitOfMessur { get; private set; } = string.Empty;

    }
}
