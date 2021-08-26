using DataAccessDummy;
using Models;
using System;
using System.Collections.Generic;

namespace DummyDataTester
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            RndmDataProvider dataProvider = new();
            List<Order> orders = dataProvider.GetOrders(15);
            foreach (var order in orders)
            {
                Console.WriteLine($"--------------------" +
                    $"\tOrder ID : {order.Id}\n\t" +
                    $"Products in this order: {order.ItemsCount}\n\t" +
                    $"Date of order: {order.DateTime.ToLongDateString()}\n\t" +
                    $"Total: {order.Total:C}\n\t" +
                    $"Items in this order:\n\t\t");
                List<OrderItem> orderItems = order.GetItemsInOrder();
                foreach (var orderItem in orderItems)
                {
                    Console.WriteLine($"\t\tSKU: {orderItem.StockItemId}" +
                        $"\t| Item: {orderItem.Description}\n" +
                        $"\t\tPrice: {orderItem.Price:C}\t|Quantity: {orderItem.Quantity}\n" +
                        $"===================\n\n");
                }
            }
        }
    }
}
