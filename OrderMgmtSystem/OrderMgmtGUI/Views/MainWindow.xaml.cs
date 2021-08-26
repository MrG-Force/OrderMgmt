using OrderMgmtGUI.Navigation;
using OrderMgmtGUI.Views;
using System.Windows;
using System.Windows.Controls;

namespace OrderMgmtGUI
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
            Switcher.Switch(new OrdersView());
        }

        internal void Navigate(UserControl nextPage)
        {
            Content = nextPage;
        }
    }
}
