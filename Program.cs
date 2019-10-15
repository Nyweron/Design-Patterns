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
        tempList.Add(new Tank("Tank", 200, 100, 50, 25, 0, 0, 50));
        tempList.Add(new Rifleman("Rifleman", 200, 100, 50, 25, 0, 0, 50));
        tempList.Add(new Destroyer("Destroyer", 200, 100, 50, 25, 0, 0, 50));
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