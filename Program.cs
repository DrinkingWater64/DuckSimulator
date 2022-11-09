using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Duck duck = new Duck();
            Goose gooseee = new Goose();
            gooseee.Honk();
            Quackable goose = new AdaptToDuck(duck);
            goose.DoQuack();

            Console.WriteLine("ducks with counters");
            Quackable d2 = new DuckWithCounter(duck);
            Quackable duckDec = new DuckDecorator(new DuckWithCounter(new Duck()));
            duckDec.DoQuack();
            duckDec.DoQuack();
            duckDec.DoQuack();

            Factory duckFac = new DuckFactory();
            duckFac.Create().DoQuack();
            Factory duckFac2= new CountingDuckFactory();
            duckFac2.Create().DoQuack();
            
            ConDuckCollection conDuckCollection = new ConDuckCollection();
            conDuckCollection.AddDuck(duckFac.Create());
            conDuckCollection.AddDuck(duckFac.Create());
            conDuckCollection.AddDuck(duckFac.Create());
            conDuckCollection.AddDuck(duckFac.Create());

            ConDuckIterator iterator = (ConDuckIterator)conDuckCollection.CreateIterator();

            for( Quackable it  = iterator.First(); !iterator.GetIsCompleted(); it = iterator.Next())
            {
                it.DoQuack();
            }

            
        }
    }
}
