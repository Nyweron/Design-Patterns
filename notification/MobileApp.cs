using DesignPatterns.order;

namespace DesignPatterns.notification
{
  public class MobileApp : IObserver
  {
    public void Update(Order order)
    {
      System.Console.WriteLine($"Mobile app - order number: {order._orderNumber} changed status to: {order._orderStatus}");
    }
  }
}