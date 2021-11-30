using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.PCL.Models.Abstractions;
using Weather.PCL.Models.Enums;

namespace Weather.PCL.Abstractions
{
    public interface IDataBase
    {
        Task<IWeather> GetWeatherDataByLngAndLat(double lat, double lng, string lang);

        void ChoiceCorF(TempChoice F);
    }
}
