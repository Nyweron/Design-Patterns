using DesignPatterns.order;

namespace DesignPatterns.notification
{
  public interface IObserver
  {
    void Update(Order order);
  }
}