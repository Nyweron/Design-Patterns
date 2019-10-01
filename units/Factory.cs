namespace DesignPatterns.units
{
  public abstract class Factory
  {
    public abstract InfantryUnit CreateInfantryUnit(UnitType unitType);
    public abstract MechanizedUnit CreateMechanizedUnit(UnitType unitType);
  }
}