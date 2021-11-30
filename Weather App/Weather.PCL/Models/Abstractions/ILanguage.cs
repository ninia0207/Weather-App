using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.PCL.Models.Abstractions
{
    public interface ILanguage
    {
        string Code { get; set; }
        string Name { get; set; }
        string NativeName { get; set; }

    }
}
