

namespace WeatherApp.AppCore.DTO
{
    public class CharacteristicTypeDTO
    {
        public Guid ID { get; private set; }
        public string char_name { get; private set; } = string.Empty;
        public string char_unitOfMessure { get; private set; } = string.Empty;


    }
}
