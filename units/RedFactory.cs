namespace DesignPatterns.units
{
  public class RedFactory : Factory
  {
    public override AirUnit CreateAirUnit(UnitType type)
    {
      switch (type)
      {
        case UnitType.HELICOPTER:
          return new Helicopter(20, 0, 30);
        default:
          throw new System.Exception();
      }
    }

    public override InfantryUnit CreateInfantryUnit(UnitType type)
    {
      switch (type)
      {
        case UnitType.RIFLEMAN:
          return new Rifleman(20, 0, 6);
        default:
          throw new System.Exception();
      }
    }

    public override MechanizedUnit CreateMechanizedUnit(UnitType type)
    {
      switch (type)
      {
        case UnitType.TANK:
          return new Tank(75, 0, 35);
        default:
          throw new System.Exception();
      }
    }
  }
}