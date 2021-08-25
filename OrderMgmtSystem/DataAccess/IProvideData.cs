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
        public List<Order> GetOrders();
        public List<StockItem> GetStockItems();

    }
}
