namespace DesignPatterns.order
{
  public class Order
  {
    public long _orderNumber { get; set; }
    public OrderStatus _orderStatus { get; set; }

    public Order(long orderNumber, OrderStatus orderStatus)
    {
      _orderNumber = orderNumber;
      _orderStatus = orderStatus;
    }
  }
}