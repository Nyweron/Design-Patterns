using System;
using DesignPatterns.cars.bmw;
using DesignPatterns.cars.ford;
using DesignPatterns.implementedFactory;

namespace DesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {
      IFactory commonwealthFactory = new LeftSideFactory();
      IFactory continentalFactory = new RightSideFactory();

      CarAbstract bmw = commonwealthFactory.BuildBmw(BMWModelsEnum.E60);
      Console.WriteLine(bmw.Position);

      CarAbstract bmw2 = continentalFactory.BuildBmw(BMWModelsEnum.E60);
      Console.WriteLine(bmw2.Position);

      CarAbstract ford = commonwealthFactory.BuildFord(FordModelsEnum.CMAX);
      Console.WriteLine(ford.Position);

    }
  }
}

//output
/*
LEFT
RIGHT
LEFT
 */