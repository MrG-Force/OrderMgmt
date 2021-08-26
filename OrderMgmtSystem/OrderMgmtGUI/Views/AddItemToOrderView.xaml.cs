using OrderMgmtGUI.Navigation;
using System.Windows;
using System.Windows.Controls;

namespace OrderMgmtGUI.Views
{
    /// <summary>
    /// Interaction logic for AddItemToOrderView.xaml
    /// </summary>
    public partial class AddItemToOrderView : UserControl
    {
        public AddItemToOrderView()
        {
            InitializeComponent();
        }

        private void BackToOrder_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AddOrderView());
        }
    }
}
