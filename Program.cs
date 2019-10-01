using System;
using DesignPatterns.units;

namespace DesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {
      Factory factory = new UnitFactory();

      Console.WriteLine("Hello World!");
      Unit tank = factory.CreateUnit(UnitType.TANK);
      Unit infantryman = factory.CreateUnit(UnitType.RIFLEMAN);

    }
  }
}