namespace DesignPatterns.order
{
  public class Order
  {
    private long _orderNumber;
    private OrderStatus _orderStatus;
    public Order(long orderNumber, OrderStatus orderStatus)
    {
      _orderNumber = orderNumber;
      _orderStatus = orderStatus;
    }

    public long GetOrderNumber()
    {
      return _orderNumber;
    }

    public void SetOrderNumber(long orderNumber)
    {
      _orderNumber = orderNumber;
    }

    public OrderStatus GetOrderStatus()
    {
      return _orderStatus;
    }

    public void SetOrderStatus(OrderStatus orderStatus)
    {
      _orderStatus = orderStatus;
    }

  }
}