using System;
using DesignPatterns.weather;

namespace DesignPatterns.notification
{
  public class RadioNews : IObserver
  {
    public void UpdateForecast(WeatherForecast weatherForecast)
    {
      Console.WriteLine($"Radio weather, temperature: {weatherForecast.temperature}, pressure: {weatherForecast.pressure}");
    }
  }
}