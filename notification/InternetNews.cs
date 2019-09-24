using System;
using DesignPatterns.weather;

namespace DesignPatterns.notification
{
  public class InternetNews : IObserver
  {
    public void UpdateForecast(WeatherForecast weatherForecast)
    {
      Console.WriteLine($"Internet weather, temperature: {weatherForecast.temperature}, pressure: {weatherForecast.pressure}");
    }
  }
}