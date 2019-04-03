using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson11Class1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // для консольного приложения
            ////Boat boat = new Boat();
            ////boat.Title = "Boat1";
            ////boat.MaxSpeed = 10;
            ////boat.Type = VesselType.general;
            ////boat.SpeedUnit = SpeedUnit.mH;
            ////boat.Draught = 1;

            //BoatShop boatShop = new BoatShop();
            //boatShop.Title = "Boat1";
            //boatShop.MaxSpeed = 10;
            //boatShop.Type = VesselType.general;
            //boatShop.SpeedUnit = SpeedUnit.mH;
            //boatShop.Draught = 1;
            //boatShop.Date = DateTime.Now;
            //boatShop.Price = 10000;
        }
    }
}
