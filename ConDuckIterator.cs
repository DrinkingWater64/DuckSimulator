using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    internal class ConDuckIterator: IDuckIterator
    {
        private ConDuckCollection ConDuckCollection;
        private int Current = 0;
        private int Step = 1;

        public ConDuckIterator(ConDuckCollection conDuckCollection)
        {
            ConDuckCollection = conDuckCollection;
        }

        public Quackable First()
        {
            Current = 0;
            return ConDuckCollection.GetDuck(Current);
        }

        public bool GetIsCompleted()
        {
            return Current >= ConDuckCollection.Count;
        }

        public Quackable Next()
        {
            Current += Step;
            if (!GetIsCompleted())
            {
                return ConDuckCollection.GetDuck(Current);
            }
            else
            {
                return null;
            }
        }
    }
}
