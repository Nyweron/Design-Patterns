using DesignPatterns.weather;

namespace DesignPatterns.notification
{
  public interface IObserver
  {
    void UpdateForecast(WeatherForecast weatherForecast);
  }
}