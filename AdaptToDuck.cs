using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    internal class AdaptToDuck : Quackable
    {
        Duck duck;

        public AdaptToDuck(Duck duck)
        {
            this.duck = duck;
        }

        public void DoQuack()
        {
            duck.DoQuack();
        }
    }
}
