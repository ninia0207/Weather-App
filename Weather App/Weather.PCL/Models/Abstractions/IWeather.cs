using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.PCL.Models.Implementations;

namespace Weather.PCL.Models.Abstractions
{
    public interface IWeather
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
        string Timezone { get; set; }
        Currently Currently { get; set; }
        Daily Daily { get; set; }
        Hourly Hourly { get; set; }

    }
}
