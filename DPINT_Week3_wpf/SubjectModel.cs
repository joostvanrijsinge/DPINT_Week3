using System.Collections.Generic;


namespace DPINT_Week3
{
    class SubjectModel: ConcreteSubject
    {
        
        public int counter = 0;

        public override void NewWindow(IObserver Add) {
            windows.Add(Add);
        }

        internal void addCounter()
        {
            counter++;
            if (counter == 5)
            {
                counter = 0;
            }
        }

        public override void notify()
        {

            foreach (IObserver c in windows)
            {
                c.update(counter);
            }
        }
    }
}
