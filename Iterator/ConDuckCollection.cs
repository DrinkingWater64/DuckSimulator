using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    internal class ConDuckCollection : IDuckCollection
    {
        private List<Quackable> _quacks = new List<Quackable>();

        public IDuckIterator CreateIterator()
        {
            return new ConDuckIterator(this);
        }

        internal Quackable GetDuck(int current)
        {
            return _quacks[current];
        }
        
        public int Count { get { return _quacks.Count; } }

        public void AddDuck(Quackable duck)
        {
            _quacks.Add(duck);
        }

        public void RemoveDuck(Quackable quackable)
        {
            this._quacks.Remove(quackable);
        }
    }
}
