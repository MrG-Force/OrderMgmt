using OrderMgmtGUI.Navigation;
using System.Windows.Controls;

namespace OrderMgmtGUI.Views
{
    /// <summary>
    /// Interaction logic for OrdersView.xaml
    /// </summary>
    public partial class OrdersView : UserControl
    {
        public OrdersView()
        {
            InitializeComponent();
        }

        private void NewOrderButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Switcher.Switch(new AddOrderView());
        }

        private void ExitApp_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Switcher.mainWindow.Close();
        }
    }
}
