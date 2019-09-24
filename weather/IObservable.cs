using DesignPatterns.notification;

namespace DesignPatterns.weather
{
  public interface IObservable
  {
    void RegisterObserver(IObserver observer);
    void UnregisterObserver(IObserver observer);
    void NotifyObservers();
  }
}