using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    internal class DuckFactory: Factory
    {
        public override Quackable Create()
        {
            return new Duck();
        }
    }
}
