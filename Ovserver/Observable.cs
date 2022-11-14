using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.Ovserver
{
    interface Observable
    {
        void Attatch( Observer observer);
        void Detach( Observer observer);
        void Notify();
    }
}
