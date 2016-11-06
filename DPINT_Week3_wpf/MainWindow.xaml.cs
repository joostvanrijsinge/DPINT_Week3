using System.Windows;

namespace DPINT_Week3
{
    public partial class MainWindow : Window
    {
        SubjectModel subMod = new SubjectModel();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();

            Controller controller = new Controller(subMod, addWindow);
            addWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            subMod.addCounter();
            subMod.notify();
        }

    }
}
