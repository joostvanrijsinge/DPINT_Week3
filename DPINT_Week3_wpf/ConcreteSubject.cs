using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week3
{
    abstract class ConcreteSubject
    {
        public List<IObserver> windows;

        public ConcreteSubject()
        {
            windows = new List<IObserver>();
        }

        public virtual void NewWindow(IObserver toAdd) { }

        public virtual void notify() { }
    }
}
