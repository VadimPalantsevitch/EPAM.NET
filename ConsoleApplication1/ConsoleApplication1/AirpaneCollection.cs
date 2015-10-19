using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    public class Aircompany : IAircompany,ICollection<IAirplane>
    {
        private ICollection<IAirplane> airplaneCollections = new List<IAirplane>();


        public void Add(IAirplane airplane)
        {
            airplaneCollections.Add(airplane);
        }

        public double maxCarrying
        {
            get
            {
                double carryiing = 0;
                foreach (var i in airplaneCollections)
                {
                    if (i is IFreighter)
                    {
                        IFreighter air = (IFreighter)i;
                        carryiing += air.carrying;
                    }
                }
                return carryiing;
            }
        }


       public double maxCapacity
        {
            get
            {
                double capacity = 0;
                foreach (var i in airplaneCollections)
                {
                    if (i is IAirliner)
                    {
                        IAirliner air = (IAirliner)i;
                        capacity += air.capacity;
                    }
                }
                return capacity;
            }
        }

       public void SortByFuelConsumption()
       {
           var collection = airplaneCollections.ToList();
           collection.Sort((a, b) => a.fuelConsumption.CompareTo(b.Name));
           airplaneCollections = collection;
       }


       public void CopyTo(IAirplane[] items, int index)
       {
           airplaneCollections.CopyTo(items, index);
       }

       public void Clear()
       {
           airplaneCollections.Clear();
       }

       
       public int Count
       {
           get { return airplaneCollections.Count; }
       }

       
       public bool IsReadOnly
       {
           get { return airplaneCollections.IsReadOnly; }
       }

     
       public bool Contains(IAirplane item)
       {
           return airplaneCollections.Contains(item);
       }

     
       public bool Remove(IAirplane item)
       {
           return airplaneCollections.Remove(item);
       }



        



       public IEnumerator<IAirplane> GetEnumerator()
       {
           return airplaneCollections.GetEnumerator();
       }

       IEnumerator IEnumerable.GetEnumerator()
       {
           return this.GetEnumerator();
       }

      
       public IEnumerable<IAirplane> Search(double a, double b)
       {
           foreach (var i in airplaneCollections)
           {
               if (i is IAirplane)
               {
                   IAirplane FuelConsumption = (IAirplane)i;
                   if (FuelConsumption.fuelConsumption >= a && FuelConsumption.fuelConsumption <= b)
                   {
                       yield return i;
                   }
               }
           }
       }

       public void Show()
       {
           foreach (var i in airplaneCollections)
           {
               Console.WriteLine("Name: {0}\t Range: {1}\t Fuel Consumption\t", i.Name, i.range, i.fuelConsumption);
           }
       }


    }
}
