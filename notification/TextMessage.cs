using DesignPatterns.order;

namespace DesignPatterns.notification
{
  public class TextMessage : IObserver
  {
    public void Update(Order order)
    {
      System.Console.WriteLine($"SMS - order number: {order._orderNumber} changed status to: {order._orderStatus}");
    }
  }
}