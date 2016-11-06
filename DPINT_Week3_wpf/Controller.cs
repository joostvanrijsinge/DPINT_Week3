namespace DPINT_Week3
{
    public class Controller
    {
        public Controller(ConcreteSubject subjectModel, IObserver window)
        {
            subjectModel.AddNewObserver(window);
        }
    }
}
