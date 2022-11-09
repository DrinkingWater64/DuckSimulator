using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    internal class CountingDuckFactory : Factory
    {
        public override Quackable Create()
        {
            return new DuckDecorator(new DuckWithCounter(new Duck()));
        }
    }
}
