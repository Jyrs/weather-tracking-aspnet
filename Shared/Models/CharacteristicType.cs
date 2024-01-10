

namespace WeatherApp.AppCore.Models
{
    public class CharacteristicType
    {
        public int CharacteristicType_ID { get; private set; }
        public string CharacteristicType_Name { get; private set; }
        public string CharacteristicType_UnitOfMessur { get; private set; }
        public CharacteristicType() { 
            
            CharacteristicType_ID = 0;
            CharacteristicType_Name = string.Empty;
            CharacteristicType_UnitOfMessur = string.Empty;
        
        }

    }
}
