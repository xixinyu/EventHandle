using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learning.ClassLibrary
{
    public class CarInfoEventArgs: EventArgs
    {
        public CarInfoEventArgs(string car)
        {
            this.Car = car;
        }

        public string Car { get; private set; }
    }
}