

using System.Collections.Generic;
using Weather.PCL.Models.Implementations;

namespace Weather.PCL.Models.Abstractions
{
    public interface IDaily
    {
        string Summary { get; set; }
        string Icon { get; set; }
        List<Datum> data { get; set; }
    }
}
