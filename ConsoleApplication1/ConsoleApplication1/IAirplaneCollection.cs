using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface IAircompany
    {
        void Add(IAirplane Airplane);
        double maxCarrying { get; }
        double maxCapacity { get; }
        void SortByFuelConsumption();
        IEnumerable<IAirplane> Search(double a, double b);
        void Show();  
    }
}
