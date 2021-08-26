using DataAccess;
using Models;
using System;
using System.Collections.Generic;

namespace DataAccessDummy
{
    public class RndmDataProvider : IProvideData
    {
        private List<StockItem> _stockItems;
        public RndmDataProvider()
        {
            _stockItems = GetStockItems();
        }

        Random random = new Random();
        // Stock Items
        string[] names = new string[] { "Ergonomic chair", "Wooden desk", "Dinning table", "Plain chair", "Chaise lounge", "Leather loveseat", "Night table", "Large Bookcase", "Chinese cupboard", "Acapulco chair" };
        double[] prices = new double[] { 56.90, 34.80, 124.80, 69.99, 78.60, 210.80, 78.99, 46.79, 67.89, 54.40 };
        bool[] inStock = new bool[] { false, true, true, true, true, };
        string[] skuLetters = new string[] { "A", "C", "K", "L", "Y", "U", "S", "X", "O", "P" };

        // Orders


        //
        private T GetRandomItem<T>(T[] data)
        {
            return data[random.Next(0, data.Length)];
        }
        public List<Order> GetOrders(int total = 10)
        {
            List<Order> orders = new List<Order>(total);
            for (int i = 0; i < total; i++)
            {
                orders.Add(GetOrder(i + 1000));
            }

            return orders;
        }

        private Order GetOrder(int orderId)
        {
            Order order = new Order(orderId);
            int itemsInOrder = random.Next(1, 11);
            int[] indxs = GetRandomNumbers(itemsInOrder, 10);
            for (int i = 0; i < itemsInOrder; i++)
            {
                OrderItem item = new OrderItem(orderId, _stockItems[indxs[i]]);
                item.Quantity = random.Next(1, 20);
                order.AddItem(item);  
            }
            return order;
        }

        public List<StockItem> GetStockItems()
        {
            List<StockItem> stockItems = new();
            for (int i = 0; i < 10; i++)
            {
                StockItem item = new()
                {
                    Sku = $"{GetRandomItem(skuLetters)}{GetRandomItem(skuLetters)}" +
                          $"{GetRandomItem(skuLetters)}-{random.Next(1000, 9999)}",
                    Name = names[i],
                    Price = GetRandomItem(prices),
                    InStock = GetRandomItem(inStock)
                };
                stockItems.Add(item);
            }
            return stockItems;
        }

        public int[] GetRandomNumbers(int howMany, int maxValue)
        {
            List<int> numbers = new();
            int num;
            for (int i = 0; i < howMany; i++)
            {
                do
                {
                    num = random.Next(maxValue);
                } while (numbers.Contains(num));
                numbers.Add(num);
            }
            return numbers.ToArray();
        }
    }
}
