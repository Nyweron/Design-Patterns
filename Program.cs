using System;
using DesignPatterns.BuilderApproach_2;

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
      // removing many constructors
      // setters removing
      HouseOne house = new HouseOne.HouseBuilder()
        .Walls("Walls")
        .Doors("Door")
        .Floor("Floor")
        .Build();

      //Console.WriteLine(house.ToString());

      SmallHouseBuilder smallHouseBuilder = new SmallHouseBuilder();
      HouseDirector smallHouseDirector = new HouseDirector(smallHouseBuilder);
      smallHouseDirector.BuildHouse();
      HouseTwo smallHouse = smallHouseDirector.GetHouse();
      Console.WriteLine(smallHouse.ToString());

      BigHouseBuilder bigHouseBuilder = new BigHouseBuilder();
      HouseDirector bigHouseDirector = new HouseDirector(bigHouseBuilder);
      bigHouseDirector.BuildHouse();
      HouseTwo bigHouse = bigHouseDirector.GetHouse();
      Console.WriteLine(bigHouse.ToString());
    }
  }
}