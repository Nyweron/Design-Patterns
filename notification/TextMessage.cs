using DesignPatterns.order;

namespace DesignPatterns.notification
{
  public class TextMessage
  {
    public void UpdateOrderStatus(Order order)
    {
      System.Console.WriteLine($"SMS - order number: {order.GetOrderNumber()} changed status to: {order.GetOrderStatus()}");
    }
  }
}