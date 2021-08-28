using Models;
using OrderMgmt.ViewModels;
using OrderMgmtGUI.Views;
using System.Windows.Controls;

namespace OrderMgmtGUI.Wpf.Controls
{
    /// <summary>
    /// Interaction logic for OrdersViewDataGrid.xaml
    /// </summary>
    public partial class OrdersViewDataGrid : UserControl
    {
        private readonly OrdersViewModel _ordersData;
        public OrdersViewDataGrid()
        {
            InitializeComponent();
            _ordersData = new OrdersViewModel();
            DataContext = _ordersData;
        }

        private void BtnOrderDetails_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Order selectedOrder = (Order)button.DataContext;
            OrderDetailsView orderDetailsView = new OrderDetailsView(selectedOrder);
            orderDetailsView.Show();
        }
    }
}
