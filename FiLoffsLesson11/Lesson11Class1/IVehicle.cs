using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Class1
{
    interface IVehicle
    {
        string Title { get; set; }
        int MaxSpeed { get; set; }
        SpeedUnit SpeedUnit { get; set; }

        string ToString();
    }
}
