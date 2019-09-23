using DesignPatterns.order;

namespace DesignPatterns.notification
{
  public interface IObserver
  {
    void update(Order order);
  }
}