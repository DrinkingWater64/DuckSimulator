using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.Composite
{
    internal class DuckGroup : Component, Quackable
    {
        ConDuckCollection ConDuckCollection = new ConDuckCollection();
        IDuckIterator iterator;

        public DuckGroup()
        {
            iterator = this.ConDuckCollection.CreateIterator();
        }

        public void Add(Component component)
        {
            this.ConDuckCollection.AddDuck((Quackable)component);
        }

        public void Display()
        {
            for(Quackable it = this.iterator.First(); !this.iterator.GetIsCompleted(); it = this.iterator.Next())
            {
                it.DoQuack();
            }
        }

        public void DoQuack()
        {
            Console.WriteLine("Quack");
        }

        public void Remove(Component component)
        {
            this.ConDuckCollection.RemoveDuck((Quackable)component);
        }   
    }
}
