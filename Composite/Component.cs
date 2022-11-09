using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.Composite
{
    interface Component
    {
        void Add(Component component);
        void Remove(Component component);
        void Display();
    }
}
