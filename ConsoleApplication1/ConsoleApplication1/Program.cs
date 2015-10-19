using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Aircompany airCompany = new Aircompany();
            
            Airliner carrier = new Airliner() {Name="a1", range=20000, fuelConsumption=100, capacity=200};
            airCompany.Add(carrier);
            Freighter freighter = new Freighter() { Name = "a2", range = 1000, fuelConsumption = 80, carrying = 5000 };
            airCompany.Add(freighter);
            CombiAirplane combiAirplane = new CombiAirplane() { Name = "a3", range = 800, fuelConsumption = 70, carrying = 1000, capacity = 70 };
            airCompany.Add(combiAirplane);
            Console.WriteLine(airCompany.maxCapacity);

            ICollection<IAirplane> find = airCompany.Search(75,110).ToList<IAirplane>();
            foreach (var i in find) i.ShowElement();
            

           
        }
    }
}
