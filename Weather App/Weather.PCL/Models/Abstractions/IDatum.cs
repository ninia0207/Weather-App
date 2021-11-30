using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.PCL.Models.Abstractions
{
    public interface IDatum
    {
            int time { get; set; }
            string summary { get; set; }
            string icon { get; set; }
            double precipIntensity { get; set; }
            double precipProbability { get; set; }
            double temperature { get; set; }
            double apparentTemperature { get; set; }
            double dewPoint { get; set; }
            double humidity { get; set; }
            double pressure { get; set; }
            double windSpeed { get; set; }
            double windGust { get; set; }
            int windBearing { get; set; }
            double cloudCover { get; set; }
            int uvIndex { get; set; }
            double visibility { get; set; }
            double ozone { get; set; }
            string precipType { get; set; }
            int sunriseTime { get; set; }
            int sunsetTime { get; set; }
            double moonPhase { get; set; }
            double precipIntensityMax { get; set; }
            int precipIntensityMaxTime { get; set; }
            double temperatureHigh { get; set; }
            int temperatureHighTime { get; set; }
            double temperatureLow { get; set; }
            int temperatureLowTime { get; set; }
            double apparentTemperatureHigh { get; set; }
            int apparentTemperatureHighTime { get; set; }
            double apparentTemperatureLow { get; set; }
            int apparentTemperatureLowTime { get; set; }
            int windGustTime { get; set; }
            int uvIndexTime { get; set; }
            double temperatureMin { get; set; }
            int temperatureMinTime { get; set; }
            double temperatureMax { get; set; }
            int temperatureMaxTime { get; set; }
            double apparentTemperatureMin { get; set; }
            int apparentTemperatureMinTime { get; set; }
            double apparentTemperatureMax { get; set; }
            int apparentTemperatureMaxTime { get; set; }
        
    }
}
