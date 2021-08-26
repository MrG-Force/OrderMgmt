namespace Models
{
    public class OrderItem
    {
        public OrderItem()
        { }
        public OrderItem(int orderId, string itemId)
        {
            OrderHeaderId = orderId;
            StockItemId = itemId;
        }
        public OrderItem(int orderId, StockItem stockItem)
        {
            OrderHeaderId = orderId;
            StockItemId = stockItem.Sku;
            Price = stockItem.Price;
            Description = stockItem.Name;
        }
        public int OrderHeaderId { get; set; }
        public string StockItemId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
