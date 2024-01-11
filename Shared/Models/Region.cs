
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherApp.AppCore.Models
{
    [Table("Region")]
    public class Region
    {
        [Key]
        public Guid Reg_Id {  get; private set; } 
        public string Reg_name { get; private set; } = string.Empty;
        public string Reg_code { get; private set; } = string.Empty;

    }
}
