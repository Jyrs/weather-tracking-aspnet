
namespace WeatherApp.AppCore.DTO
{
    public class RegionDTO
    {
        public Guid Reg_ID { get; private set; }
        public string Region_Name { get; private set; } = string.Empty;
        public string Region_Code { get; private set; } = string.Empty;

    }
}
