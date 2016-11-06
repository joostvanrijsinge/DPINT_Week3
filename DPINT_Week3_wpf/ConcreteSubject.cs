using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week3
{
    public abstract class ConcreteSubject
    {
        protected List<IObserver> _observers;

        public ConcreteSubject()
        {
            _observers = new List<IObserver>();
        }

        public void AddNewObserver(IObserver newObserver)
        {
            _observers.Add(newObserver);
        }

        public abstract void Notify();
    }
}
