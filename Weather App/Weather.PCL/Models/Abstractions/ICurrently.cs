using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.PCL.Models.Abstractions
{
    public interface ICurrently
    {
        
        int Time { get; set; }
        string Summary { get; set; }
        string Icon { get; set; }
        double PrecipIntensity { get; set; }
        double PrecipProbability { get; set; }
        string PrecipType { get; set; }
        double Temperature { get; set; }
        double ApparentTemperature { get; set; }
        double DewPoint { get; set; }
        double Humidity { get; set; }
        double Pressure { get; set; }
        double WindSpeed { get; set; }
        double WindGust { get; set; }
        int WindBearing { get; set; }
        double CloudCover { get; set; }
        int UvIndex { get; set; }
        int Visibility { get; set; }
        double Ozone { get; set; }
    }
}
