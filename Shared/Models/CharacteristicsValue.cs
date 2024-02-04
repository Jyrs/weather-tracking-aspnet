using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherApp.AppCore.Models
{
    [Table("Characteristics_Value")]
    public class CharacteristicsValue
    {
        public Guid ID {  get; private set; }

        [ForeignKey("ID")]
        public Guid charaterisitcs_typeID {  get; private set; }

        [ForeignKey("ClimatDayInfo_ID")]
        public Guid climat_info_dayID {get; private set; }
        public string value { get; private set; } = string.Empty;
        public DateTime metaData_date { get; private set; } = DateTime.MinValue;

    }
}
