using System;
using DesignPatterns.House;

namespace DesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {

      var house1 = new House1("walls", "floors", "rooms", "windows", "doors", "garage");

      //var house2 = new House1();
      // What fields we should use now?
      // it is mess
      // what is correct order
      // we do not sure which fileds should be init...
      // Builder is solving this problem

      Console.WriteLine("Hello World!");
    }
  }
}