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
            //List<Order> orders = dataProvider.GetOrders(15);
            List<Order> orders = dataProvider.Orders; // using a property that retrieves data from static field
            foreach (var order in orders)
            {
                Console.WriteLine();
                Console.WriteLine($"  ====================" +
                    $"\tOrder ID : {order.Id}\t====================\n\t" +
                    $"Products in this order: {order.ItemsCount}\n\t" +
                    $"Date of order: {order.DateTime.ToLongDateString()}\n\t" +
                    $"Order status: {order.OrderStatus}\n\t" +
                    $"Total: {order.Total:C}\n\t" +
                    $"In this order:\n\t\t");
                List<OrderItem> orderItems = order.OrderItems;
                foreach (var orderItem in orderItems)
                {
                    Console.WriteLine($"\tSKU: {orderItem.StockItemId}" +
                        $"\t| Product: {orderItem.Description}\n" +
                        $"\tPrice: {orderItem.Price:C}\t| Quantity: {orderItem.Quantity}\n" +
                        $"\t---------------------------------------------");
                }
            }
        }
    }
}
