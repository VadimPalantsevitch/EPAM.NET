using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Airplane : IAirplane
    {

        public string Name { get; set; }
        public double range {get;set;}
        public double fuelConsumption {get;set;}
        public void ShowElement() { Console.WriteLine("Name: {0}\t range: {1}\t Fuel Consumption {2}\t", this.Name, this.range, this.fuelConsumption); }


    }
}
