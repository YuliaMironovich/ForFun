using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TroposphericDelayApplication.Api
{
    public class Parameters
    
    {
        public double Latitude { get; set; }
        public double Elevation { get; set; }
        public double Longitude { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }

        public Parameters(XmlDocument xml)
        {
            var node = xml.SelectSingleNode("//display_location/elevation").InnerText.Replace(" ft", "");
            Elevation = Convert.ToDouble(ConvertSigns(node));
            node = xml.SelectSingleNode("//relative_humidity").InnerText.Replace("%", "");
            Humidity = Convert.ToDouble(node) / 100;
            Temperature = Convert.ToDouble(xml.SelectSingleNode("//temp_c").InnerText) + 273.15;
            Pressure = Convert.ToDouble(xml.SelectSingleNode("//pressure_mb").InnerText);
            Latitude = Convert.ToDouble(ConvertSigns(xml.SelectSingleNode("//display_location/latitude").InnerText));
            Longitude = Convert.ToDouble(ConvertSigns(xml.SelectSingleNode("//display_location/longitude").InnerText));
        }

        public string ConvertSigns(string value)
        {
             return value.Replace(".", ",");  
        }
    }
}
