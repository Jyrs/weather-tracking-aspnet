
namespace WeatherApp.AppCore.DTO
{
    public class RegionDTO
    {
        public int RegionDTO_ID {  get; private set; } 
        public string RegionDTO_Name { get; private set; }
        public string RegionDTO_Code { get; private set; }


        public RegionDTO() {
            RegionDTO_ID = 0;
            RegionDTO_Name = string.Empty;
            RegionDTO_Code = string.Empty;
        }

    }
}
