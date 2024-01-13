

using System.Xml.Linq;
using System;

namespace WeatherApp.AppCore.DTO
{
    public class ClimateDayInfoDTO : ICloneable
    {
        public Guid ClimatDayInfo_ID { get; private set; }
        public Guid RegionID { get; private set; }
        public DateTime day_Date { get; private set; } = DateTime.MinValue;

        public ClimateDayInfoDTO(Guid climatDayInfo_ID, Guid regionID, DateTime day_Date)
        {
            ClimatDayInfo_ID = climatDayInfo_ID;
            RegionID = regionID;
            this.day_Date = day_Date;
        }

        public object Clone()
        {
            return new ClimateDayInfoDTO(ClimatDayInfo_ID, RegionID, day_Date);
        }
    }
}
