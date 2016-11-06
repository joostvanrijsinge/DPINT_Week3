using System.Windows;

namespace DPINT_Week3
{
    public partial class MainWindow : Window
    {
        private SubjectModel _subMod;

        public MainWindow()
        {
            InitializeComponent();
            _subMod = new SubjectModel();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ColorWindow newWindow = new ColorWindow();

            Controller controller = new Controller(_subMod, newWindow);
            newWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _subMod.IncreaseCounter();
            _subMod.Notify();
        }

    }
}
