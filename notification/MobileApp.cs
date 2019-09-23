using DesignPatterns.order;

namespace DesignPatterns.notification
{
  public class MobileApp
  {
    public void UpdateOrderStatus(Order order)
    {
      System.Console.WriteLine($"Mobile app - order number: {order._orderNumber} changed status to: {order._orderStatus}");
    }
  }
}