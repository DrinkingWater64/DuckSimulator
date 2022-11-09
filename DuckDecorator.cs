using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    internal class DuckDecorator : Quackable
    {
        public Quackable duck;

        public DuckDecorator(Quackable duck)
        {
            this.duck = duck;
        }

        protected Quackable Duck { get => duck; set => duck = value; }

        public virtual void DoQuack()
        {
            if (this.duck != null)
            {
                this.duck.DoQuack();
            }
            else
            {
                Console.WriteLine("No duck");
            }
        }
        
    }
}
