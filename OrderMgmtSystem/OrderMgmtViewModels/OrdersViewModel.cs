using DataAccess;
using DataAccessDummy;
using Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OrderMgmt.ViewModels
{
    public class OrdersViewModel : INotifyPropertyChanged
    {
        private readonly IProvideData _ordersData;
        public event PropertyChangedEventHandler PropertyChanged; // May be not needed here


        public OrdersViewModel()
        {
            _ordersData = new RndmDataProvider();
            //Orders = _ordersData.GetOrders(15);
            Orders = _ordersData.Orders;
        }

        public List<Order> Orders { get; }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
