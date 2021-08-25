using System.Windows;
using System.Windows.Controls;

namespace OrderMgmtSystem.Views
{
    /// <summary>
    /// Interaction logic for OrdersMainView.xaml
    /// </summary>
    public partial class OrdersMainView : UserControl
    {
        public OrdersMainView()
        {
            InitializeComponent();
        }

        private void ExitApp_Click(object sender, RoutedEventArgs e)
        {
            Switcher.mainWindow.Close();
        }

        private void NewOrderButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AddOrderView());
        }
    }
}
