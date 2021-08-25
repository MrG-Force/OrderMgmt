using DataAccess;
using Models;
using System;
using System.Collections.Generic;

namespace DataAccessDummy
{
    public class RndmDataProvider : IProvideData
    {
        Random random = new Random();
        // Stock Items
        string[] names = new string[] { "Ergonomic chair", "Wooden desk", "Dinning table", "Plain chair", "Chaise lounge", "Leather loveseat", "Night table", "Large Bookcase", "Chinese cupboard", "Acapulco chair" };
        double[] prices = new double[] { 56.90, 34.80, 124.80, 69.99, 78.60, 210.80, 78.99, 46.79, 67.89, 54.40 };
        bool[] inStock = new bool[] { false, true, true, true, true, };

        // Orders


        //
        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public List<StockItem> GetStockItems()
        {
            throw new NotImplementedException();
        }
    }
}
