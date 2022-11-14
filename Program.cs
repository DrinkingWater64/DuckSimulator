using DuckSimulator.Composite;
using DuckSimulator.Ovserver;
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
            // Duck and Goose
            Console.WriteLine(".............................................................................................................");
            Console.WriteLine("Adapter Implementation");
            Console.WriteLine(".............................................................................................................");
            Duck duck = new Duck();
            Goose gooseee = new Goose();
            gooseee.Honk();
            Quackable goose = new AdaptToDuck(duck);
            goose.DoQuack();

            Console.WriteLine("\n\n\n");
            Console.WriteLine(".............................................................................................................");
            Console.WriteLine("ducks with counters");
            Console.WriteLine(".............................................................................................................");
            Quackable d2 = new DuckWithCounter(duck);
            Quackable duckDec = new DuckDecorator(new DuckWithCounter(new Duck()));
            duckDec.DoQuack();
            duckDec.DoQuack();
            duckDec.DoQuack();



            Console.WriteLine("\n\n\n");
            Console.WriteLine(".............................................................................................................");
            Console.WriteLine("Factory Implementation");
            Console.WriteLine(".............................................................................................................");
            Factory duckFac = new DuckFactory();
            duckFac.Create().DoQuack();
            Factory duckFac2= new CountingDuckFactory();
            duckFac2.Create().DoQuack();
            

            Console.WriteLine("\n\n\n");
            Console.WriteLine(".............................................................................................................");
            Console.WriteLine("Iterator Implementation");
            Console.WriteLine(".............................................................................................................");
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


            Console.WriteLine("\n\n\n");
            Console.WriteLine(".............................................................................................................");
            Console.WriteLine("Composite implementation");
            Console.WriteLine(".............................................................................................................");
            DuckGroup duckGroup = new DuckGroup();
            duckGroup.DoQuack();

            Console.WriteLine("Adding Children");
            duckGroup.Add((Component)duckFac.Create());
            duckGroup.Add((Component)duckFac.Create());
            duckGroup.Add((Component)duckFac.Create());
            duckGroup.Add((Component)duckFac.Create());
            duckGroup.Add(new Duck());

            Console.WriteLine("Executing Children");
            duckGroup.Display();




           
            Console.WriteLine("\n\n\n");
            Console.WriteLine(".............................................................................................................");
            Console.WriteLine("Observer implemetatuin.............................");
            Console.WriteLine(".............................................................................................................");
            //Observer and observable
            //....................................................
            Duck duck1 = new Duck();
            Duck duck2 = new Duck();
            Duck duck3 = new Duck();

            DuckObserver duckObserver = new DuckObserver();

            duck1.Attatch(duckObserver);
            duck2.Attatch(duckObserver);
            duck3.Attatch(duckObserver);

            duck1.DoQuack();
            duck2.DoQuack();
            duck3.DoQuack();
            duck3.DoQuack();

            duckObserver.Show();

            duck1.DoQuack();
            duck2.Detach(duckObserver);
            duck2.DoQuack();

            duckObserver.Show();

        }
    }
}
