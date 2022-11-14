using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.Ovserver
{
    internal class DuckObserver : Observer
    {
        Dictionary<Observable, int> duckMaps = new Dictionary<Observable, int>();

        public void Update(Observable observable)
        {
            if (duckMaps.ContainsKey(observable))
            {
                int value = duckMaps[observable];
                value += 1;
                duckMaps[observable] = value;
            }
            else
            {
                duckMaps.Add(observable, 1);
            }
        }

        public void Show()
        {
            foreach (var observable in duckMaps.Keys)
            {

                Console.WriteLine(observable.GetHashCode()+ ": " + duckMaps[observable]);
                
            }
        }
    }
}
