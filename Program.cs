using System;

namespace DesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {
      //var house1 = new HouseProblem("walls", "floors", "rooms", "windows", "doors", "garage");
      // var house2 = new HouseProblem();
      // What fields we should use now?
      // it is mess
      // what is correct order
      // we do not sure which fileds should be init...

      // Builder is solving this problem
      House house = new House.HouseBuilder()
        .Walls("Walls")
        .Doors("Door")
        .Floor("Floor")
        .Build();

      Console.WriteLine(house.ToString());
    }
  }
}