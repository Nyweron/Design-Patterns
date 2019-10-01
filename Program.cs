using System;
using DesignPatterns.units;

namespace DesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {
      Factory blueFactory = new BlueFactory();
      Factory redFactory = new RedFactory();

      MechanizedUnit redTank = redFactory.CreateMechanizedUnit(UnitType.TANK);
      InfantryUnit redInfantry = redFactory.CreateInfantryUnit(UnitType.RIFLEMAN);

      MechanizedUnit blueTank = redFactory.CreateMechanizedUnit(UnitType.TANK);
      InfantryUnit blueInfantry = redFactory.CreateInfantryUnit(UnitType.RIFLEMAN);

    }
  }
}