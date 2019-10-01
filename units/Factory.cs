namespace DesignPatterns.units
{
  public abstract class Factory
  {
    public abstract InfantryUnit CreateInfantryUnit(UnitType type);
    public abstract MechanizedUnit CreateMechanizedUnit(UnitType type);
    public abstract AirUnit CreateAirUnit(UnitType type);
  }
}