using System;

namespace DesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Unit tank = new Tank(200, 0, 20);
      Unit infantryman = new Rifleman(200, 0, 20);
    }
  }
}