using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Class1
{
    enum VesselType
    {
        general,
        container,
        passenger,
        tech
    }

    interface IWaterVehicles : IVehicle
    {
        int Draught { get; set; }
        VesselType Type { get; set; }
    }
}
