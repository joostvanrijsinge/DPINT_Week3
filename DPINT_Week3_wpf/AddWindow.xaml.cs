using System.Windows;
using System.Windows.Media;

namespace DPINT_Week3
{
    public partial class AddWindow : Window, IObserver
    {
        public Brush[] colors = { Brushes.Red, Brushes.Blue, Brushes.Black, Brushes.Purple, Brushes.Green };

        public AddWindow()
        {
            InitializeComponent();
            text.Background = colors[0];
        }

        public void update(int number)
        {
            text.Background = colors[number];
        }
    }
}
