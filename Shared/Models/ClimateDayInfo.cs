

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherApp.AppCore.Models
{
    [Table("ClimateDayInfo")]
    public class ClimateDayInfo
    {
        [Key]
        public Guid ClimatDayInfo_ID { get; private set; }
        [ForeignKey("Reg_Id")]
        public Guid RegionID { get; private set; }
        public DateTime day_date { get; private set; } = DateTime.MinValue;

    }
}
