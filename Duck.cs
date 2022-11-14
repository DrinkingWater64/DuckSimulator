using DuckSimulator.Composite;
using DuckSimulator.Ovserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    internal class Duck : Quackable, Component, Observable
    {
        

        List<Observer> observers = new List<Observer>();
        public string ID = "NaN";

        public void Add(Component component)
        {
            throw new NotImplementedException();
        }


        public void Attatch(Observer observer)
        {
            observers.Add(observer);
        }


        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void DoQuack()
        {
            Console.WriteLine("Quack");
            Notify();
        }

        public void Notify()
        {
            foreach (var o in observers)
            {
                o.Update((Observable)this);
            }
        }

        public void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
