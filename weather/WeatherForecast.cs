using System.Collections.Generic;
using DesignPatterns.notification;

namespace DesignPatterns.weather
{
  public class WeatherForecast : IObservable
  {

    public int temperature { get; set; }
    public int pressure { get; set; }
    public HashSet<IObserver> registeredObservers = new HashSet<IObserver>();

    public WeatherForecast(int _temperature, int _pressure)
    {
      temperature = _temperature;
      pressure = _pressure;
    }

    public void RegisterObserver(IObserver observer)
    {
      registeredObservers.Add(observer);
    }

    public void UnregisterObserver(IObserver observer)
    {
      registeredObservers.Remove(observer);
    }

    public void NotifyObservers()
    {
      foreach (var observer in registeredObservers)
      {
        observer.UpdateForecast(this);
      }
    }

    public void UpdateForecast(int _temperature, int _pressure)
    {
      temperature = _temperature;
      pressure = _pressure;
      NotifyObservers();
    }
  }
}