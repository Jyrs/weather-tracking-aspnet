using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.AppCore.Models
{
    public class InfoDisplay : ICloneable
    {
        public DateTime Date {  get; set; }
        public string Region { get; set; }
        public List<Tuple<string, string, string>> char_Values { get; set; }

        public InfoDisplay() {
            Date = DateTime.MinValue;
            Region = "";
            char_Values = new List<Tuple<string, string, string>>();
        }
        public InfoDisplay(DateTime dateTime, string reg, List<Tuple<string, string, string>> tuples) 
        {
            Date = dateTime;
            Region = reg;
            char_Values = tuples;
        }

        public object Clone()
        {
          return new InfoDisplay(Date, Region, char_Values);
        }
    }
}
