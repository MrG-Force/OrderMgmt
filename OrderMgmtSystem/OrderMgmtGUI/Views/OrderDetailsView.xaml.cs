using Models;
using OrderMgmt.ViewModels;
using System.Windows;

namespace OrderMgmtGUI.Views
{
    /// <summary>
    /// Interaction logic for OrderDetailsView.xaml
    /// </summary>
    public partial class OrderDetailsView : Window
    {
        private readonly OrderDetailsViewModel _orderDetailsViewModel;
        public OrderDetailsView(Order order)
        {
            InitializeComponent();
            _orderDetailsViewModel = new OrderDetailsViewModel(order);
            DataContext = _orderDetailsViewModel;
            this.Title = _orderDetailsViewModel.WindowTitle;
        }
    }
}
