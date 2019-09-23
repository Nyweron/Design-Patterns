using DesignPatterns.notification;

namespace DesignPatterns.order
{
  public interface IObservable
  {
    void RegisterObserver(IObserver observer);
    void UnregisterObserver(IObserver observer);
    void NotifyObservers();
  }
}