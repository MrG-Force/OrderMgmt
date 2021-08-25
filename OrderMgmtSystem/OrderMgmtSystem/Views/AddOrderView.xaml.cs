using System.Windows;
using System.Windows.Controls;

namespace OrderMgmtSystem.Views
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

        private void SubmitOrder_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new OrdersMainView());
        }

        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new OrdersMainView());
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AddItemView());
            
            
        }
    }
}
