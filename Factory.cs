using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    internal abstract class Factory
    {
        public abstract Quackable Create();
    }
}
