using System;
using DesignPatterns.weather;

namespace DesignPatterns.notification
{
  public class TvNews : IObserver
  {
    public void UpdateForecast(WeatherForecast weatherForecast)
    {
      Console.WriteLine($"TV weather, temperature: {weatherForecast.temperature}, pressure: {weatherForecast.pressure}");
    }
  }
}