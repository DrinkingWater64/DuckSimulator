using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    internal class AdaptToDuck : Quackable
    {
        Goose goose;

        public AdaptToDuck(Goose goose)
        {
            this.goose = goose;
        }

        public void DoQuack()
        {
            goose.Honk();
            Console.WriteLine("But as a duck");
        }
    }
}
