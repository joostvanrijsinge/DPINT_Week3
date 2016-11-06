namespace DPINT_Week3
{
    class Controller
    {
        public Controller(ConcreteSubject SubjectModel, IObserver window)
        {
            SubjectModel.NewWindow(window);
        }
    }
}
