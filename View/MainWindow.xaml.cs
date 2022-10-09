using Fishing_Helper.ViewModel;
using System.Windows;

namespace Fishing_Helper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new FishViewModel();
        }
    }
}
