using System.Windows;
using System.Windows.Media;

namespace DPINT_Week3
{
    public partial class ColorWindow : Window, IObserver
    {
        private Brush[] _colors = { Brushes.Red, Brushes.Blue, Brushes.Black, Brushes.Purple, Brushes.Green };

        public ColorWindow()
        {
            InitializeComponent();
            text.Background = _colors[0];
        }

        public void Update(int number)
        {
            text.Background = _colors[number];
        }
    }
}
