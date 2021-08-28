using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IProvideData
    {
        private static List<Order> _orders;
        public List<Order> Orders => _orders;
        public List<Order> GetOrders(int total);
        public List<StockItem> GetStockItems();

    }
}
