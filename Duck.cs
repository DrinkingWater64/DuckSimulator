using DuckSimulator.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    internal class Duck : Quackable, Component
    {
        public void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void DoQuack()
        {
            Console.WriteLine("Quack");
        }

        public void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
