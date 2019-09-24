using System;
using DesignPatterns.notification;
using DesignPatterns.weather;

namespace DesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {
      WeatherForecast weatherForecast = new WeatherForecast(25, 1003);
      RadioNews radioNews = new RadioNews();
      InternetNews internetNews = new InternetNews();
      TvNews tvNews = new TvNews();
      weatherForecast.RegisterObserver(radioNews);
      weatherForecast.RegisterObserver(internetNews);
      weatherForecast.RegisterObserver(tvNews);
      weatherForecast.NotifyObservers();
      weatherForecast.UnregisterObserver(tvNews);
      weatherForecast.UnregisterObserver(radioNews);
      Console.WriteLine("New weather - only for internet news:");
      weatherForecast.UpdateForecast(18, 1007);
    }
  }
}