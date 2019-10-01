namespace DesignPatterns.units
{
  public abstract class Factory
  {
    public abstract Unit CreateUnit(UnitType unitType);
  }
}