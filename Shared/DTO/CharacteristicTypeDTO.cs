

namespace WeatherApp.AppCore.DTO
{
    public class CharacteristicTypeDTO
    {
        public int CharacteristicTypeDTO_ID { get; private set; }
        public string CharacteristicTypeDTO_Name { get; private set; }
        public string CharacteristicTypeDTO_UnitOfMessur { get; private set; }
        public CharacteristicTypeDTO() {

            CharacteristicTypeDTO_ID = 0;
            CharacteristicTypeDTO_Name = string.Empty;
            CharacteristicTypeDTO_UnitOfMessur = string.Empty;
        
        }

    }
}
