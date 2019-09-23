using DesignPatterns.order;

namespace DesignPatterns.notification
{
  public class Email
  {
    public void UpdateOrderStatus(Order order)
    {
      System.Console.WriteLine($"Email - order number: {order.GetOrderNumber()} changed status to: {order.GetOrderStatus()}");
    }
  }
}