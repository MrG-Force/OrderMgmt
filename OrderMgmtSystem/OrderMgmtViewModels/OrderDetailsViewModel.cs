using Models;

namespace OrderMgmt.ViewModels
{
    public class OrderDetailsViewModel
    {
        public OrderDetailsViewModel(Order order)
        {
            Order = order;
            WindowTitle = $"Order No. {order.Id}";
        }

        public Order Order { get; }
        public string WindowTitle { get; }
    }
}
