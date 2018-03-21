using Learning.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningFor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var dealer = new CarDealer();

            var micheal = new Consumer("micheal");
            dealer.NewCarInfo += micheal.NewcarIsHere;
            dealer.NewCar("Ferrari");

            //var sebastian = new Consumer("sebastian");
            //dealer.NewCarInfo += sebastian.NewcarIsHere;
            //dealer.NewCar("Mercedes");
            //dealer.NewCarInfo += sebastian.NewcarIsHere;

            //dealer.NewCarInfo -= micheal.NewcarIsHere;
            //dealer.NewCar("Red Bull Racing");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
