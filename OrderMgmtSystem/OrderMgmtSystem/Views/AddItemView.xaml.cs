using System.Windows;
using System.Windows.Controls;

namespace OrderMgmtSystem.Views
{
    /// <summary>
    /// Interaction logic for AddItemView.xaml
    /// </summary>
    public partial class AddItemView : UserControl
    {
        public AddItemView()
        {
            InitializeComponent();
        }

        private void BackToOrder_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AddOrderView());
        }
    }
}
