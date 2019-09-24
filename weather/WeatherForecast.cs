using System.Collections.Generic;
using DesignPatterns.notification;

namespace DesignPatterns.weather
{
  public class WeatherForecast : IObservable
  {
    public int temptemper { get; set; }
    public int pressure { get; set; }
    public HashSet<IObserver> RegisteredObservers = new HashSet<IObserver>();

    public void RegisterObserver(IObserver observer)
    {
      throw new System.NotImplementedException();
    }

    public void UnregisterObserver(IObserver observer)
    {
      throw new System.NotImplementedException();
    }

    public void NotifyObservers()
    {
      throw new System.NotImplementedException();
    }
  }
}