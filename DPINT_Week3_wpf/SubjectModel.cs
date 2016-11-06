using System.Collections.Generic;


namespace DPINT_Week3
{
    public class SubjectModel: ConcreteSubject
    {
        private int _counter;

        public SubjectModel()
        {
            _counter = 0;
        }

        public void IncreaseCounter()
        {
            _counter++;
            if (_counter == 5)
            {
                _counter = 0;
            }
        }

        public override void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_counter);
            }
        }
    }
}
