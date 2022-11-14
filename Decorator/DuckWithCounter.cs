
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    internal class DuckWithCounter : DuckDecorator
    {
        

        public int counter = 0;

        public DuckWithCounter(Quackable duck) : base(duck)
        {
        }

        public void IncrementCounter()
        {
            counter++;
            Console.Write(counter.ToString());
            Console.WriteLine(" ");
        }

        public override void DoQuack()
        {
            duck.DoQuack();
            IncrementCounter();
        }
    }
}
