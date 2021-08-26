using System;
using System.Collections.Generic;

namespace Models
{
    /// <summary>
    /// A class that represents an order in the system.
    /// </summary>
    public class Order
    {
        //--- fields ---
        private List<OrderItem> _orderItems;

        //--- ctor ---
        
        /// <summary>
        /// Initializes the Order with the creation DateTime and sets the OrderState to New.
        /// </summary>
        public Order(int id)
        {
            _orderItems = new();
            DateTime = DateTime.Now;
            OrderStateId = 1;
            Id = id;
        }

        //--- props ---
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int OrderStateId { get; set; }
        public double Total
        {
            get
            {
                double total = 0;
                foreach (OrderItem item in _orderItems)
                {
                    total += item.Price * item.Quantity;
                }
                return total;
            }
        }
        public int ItemsCount => _orderItems.Count;
        //--- enum ---
        public enum OrderState { New = 1, Pending = 2, Rejected = 3, Complete = 4 };

        //--- methods ---
        /// <summary>
        /// Adds a new OrderItem to the Order
        /// </summary>
        /// <param name="item">An OrderItem to be added</param>
        public void AddItem(OrderItem item)
        {
            _orderItems.Add(item);
        }

        /// <summary>
        /// Removes the item with the given id from the order.
        /// </summary>
        /// <remarks>Note that this method removes the item regardless of the Quantity of the item</remarks>
        /// <param name="id">This is usually the SKU of the item</param>
        public void RemoveItem(int id)
        {
            OrderItem item = _orderItems.Find(i => i.StockItemId.Equals(id));
            _orderItems.Remove(item);
        }

        /// <summary>
        /// Provides a list with all the items currently in the order.
        /// </summary>
        /// <returns></returns>
        public List<OrderItem> GetItemsInOrder()
        {
            return _orderItems;
        }

        /// <summary>
        /// Commits the order and saves it to the database.
        /// </summary>
        public void Submit()
        {
            throw new NotImplementedException();
        }
    }
}
