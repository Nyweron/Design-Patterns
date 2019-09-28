using System;

namespace DesignPatterns
{
  /*
    Class FlightLeg  should have fileds:
    from - required, unchanged after being built by Builder
    to - required, unchanged after being built by Builder
    delayed - default false, can only be set via the setter
    price- required, can be changed after creating the object
   */
  class Program
  {
    static void Main(string[] args)
    {
      FlightLeg leg = new FlightLeg.FlightLegBuilder("Las Vegas", "Los Angeles").Price(50).Build();
      Console.WriteLine(leg);
      leg.SetDelayed(true);
      Console.WriteLine(leg);
      leg.SetPrice(10);
      Console.WriteLine(leg);

      leg = new FlightLeg.FlightLegBuilder("Las Vegas", "Los Angeles").Build();
      Console.WriteLine(leg);

    }
  }
}