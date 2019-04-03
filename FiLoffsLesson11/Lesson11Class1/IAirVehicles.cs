using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Class1
{
    interface IAirVehicles : IVehicle
    {
        int MaxHeight { get; set; }

    }
}
