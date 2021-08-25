using OrderMgmtSystem.Views;
using System.Windows;
using System.Windows.Controls;

namespace OrderMgmtSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Switcher.mainWindow = this;
            Switcher.Switch(new OrdersMainView());
        }

        internal void Navigate(UserControl nextPage)
        {
            Content = nextPage;
        }
    }
}
