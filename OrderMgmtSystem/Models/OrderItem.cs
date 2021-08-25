namespace Models
{
    public class OrderItem
    {
        public OrderItem(int OrderId, int ItemId)
        {
            OrderHeaderId = OrderId;
            StockItemId = ItemId;
        }
        public int OrderHeaderId { get; set; }
        public int StockItemId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
