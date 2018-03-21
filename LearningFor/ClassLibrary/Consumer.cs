using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learning.ClassLibrary
{
    public class Consumer
    {
        private string name;

        public Consumer(string name)
        {
            this.name = name;
        }

        public void NewcarIsHere(object sender, CarInfoEventArgs e)
        {
            Console.WriteLine("{0}: car {1}:  is new ", name, e.Car);
        }

    }
}