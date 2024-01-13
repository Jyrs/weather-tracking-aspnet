
using WeatherApp.AppCore.Models;

namespace WeatherApp.AppCore.DTO
{
    public class RegionDTO : ICloneable
    {
        public Guid Reg_Id { get; private set; }
        public string Reg_name { get; private set; } = string.Empty;
        public int Reg_code { get; private set; }


        public RegionDTO(Guid Reg_Id, string Reg_name, int Reg_code)
        {
            this.Reg_Id = Reg_Id;
            this.Reg_name = Reg_name;
            this.Reg_code = Reg_code;
        }

        public object Clone()
        {
            return new RegionDTO(Reg_Id, Reg_name, Reg_code);
        }
    }


}
