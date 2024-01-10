
namespace WeatherApp.AppCore.Models
{
    public class Region
    {
        public int Region_ID {  get; private set; } 
        public string Region_Name { get; private set; }
        public string Region_Code { get; private set; }


        public Region() { 
            Region_ID = 0;
            Region_Name = string.Empty;
            Region_Code = string.Empty;
        }

    }
}
