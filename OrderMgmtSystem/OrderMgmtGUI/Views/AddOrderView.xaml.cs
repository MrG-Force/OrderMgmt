using OrderMgmtGUI.Navigation;
using System.Windows.Controls;

namespace OrderMgmtGUI.Views
{
    /// <summary>
    /// Interaction logic for AddOrderView.xaml
    /// </summary>
    public partial class AddOrderView : UserControl
    {
        public AddOrderView()
        {
            InitializeComponent();
        }

        private void AddItem_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Switcher.Switch(new AddItemToOrderView());
        }
        private void SubmitOrder_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Switcher.Switch(new OrdersView());
        }

        private void CancelOrder_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Switcher.Switch(new OrdersView());
        }
    }
}
