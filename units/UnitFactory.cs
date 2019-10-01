namespace DesignPatterns.units
{
  public class UnitFactory : Factory
  {
    public override Unit CreateUnit(UnitType unitType)
    {
      switch (unitType)
      {
        case UnitType.TANK:
          return new Tank(200, 0, 20);
        case UnitType.RIFLEMAN:
          return new Rifleman(100, 0, 10);
        default:
          throw new System.Exception();

      }
    }
  }
}