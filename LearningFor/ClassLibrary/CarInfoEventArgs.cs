using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learning.ClassLibrary
{
    public class CarInfoEventArgs: EventArgs
    {
        CarDealer ch = new CarDealer();
        public CarInfoEventArgs(string car)
        {       
            this.Car = car;
        }

        public string Car { get; private set; }
        public string name { get; private set; }
    }
}