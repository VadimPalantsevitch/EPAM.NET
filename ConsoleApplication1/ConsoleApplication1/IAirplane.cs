using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface IAirplane
    {
         string Name { get;  }
         double range { get;  }
         double fuelConsumption { get;  }
         void ShowElement();

    }
}
