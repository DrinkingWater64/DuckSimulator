using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    internal class Duck : Quackable
    {
        public void DoQuack()
        {
            Console.WriteLine("Quack");
        }
    }
}
