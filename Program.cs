using System;

namespace DesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      GameEngine engine = GameEngine.GetInstance();
      GameEngine engine2 = GameEngine.GetInstance();

      if (engine == engine2)
      {
        Console.WriteLine("Takie same!");
      }
      else
      {
        Console.WriteLine("Różne");
      }

    }
  }
}