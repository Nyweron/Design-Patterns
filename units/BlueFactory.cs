namespace DesignPatterns.units
{
  public class BlueFactory : Factory
  {
    public override AirUnit CreateAirUnit(UnitType type)
    {
      switch (type)
      {
        case UnitType.HELICOPTER:
          return new Helicopter(50, 0, 25);
        default:
          throw new System.Exception();
      }
    }

    public override InfantryUnit CreateInfantryUnit(UnitType type)
    {
      switch (type)
      {
        case UnitType.RIFLEMAN:
          return new Rifleman(25, 0, 5);
        default:
          throw new System.Exception();
      }
    }

    public override MechanizedUnit CreateMechanizedUnit(UnitType type)
    {
      switch (type)
      {
        case UnitType.TANK:
          return new Tank(100, 0, 25);
        default:
          throw new System.Exception();
      }
    }
  }
}