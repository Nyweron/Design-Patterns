using System;
using System.Collections.Generic;

namespace DesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Object> tempList = new List<object>();

      for (int i = 0; i < 10000000; i++)
      {
        tempList.Add(new Tank(0, 0));
        tempList.Add(new Rifleman(0, 0));
        tempList.Add(new Destroyer(0, 0));
      }

      Console.WriteLine("Hello World!");
    }
    /*
    Description of problem:
    Build many objects many times with the same properties
    It takes a lot of memory


    Flyweight solving problem with memory
    */
  }
}