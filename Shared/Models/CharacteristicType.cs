using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherApp.AppCore.Models
{
    [Table("Characteristics_Type")]
    public class CharacteristicType
    {
       
        public Guid ID { get; private set; }
        public string char_name { get; private set; } = string.Empty;
        public string char_unitOfMessure { get; private set; } = string.Empty;

    }
}
