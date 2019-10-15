namespace Design_Patterns.UnitStats
{
  public class UnitStatsRepository
  {
    private static UnitStats destroyerUnitStats = new UnitStats("Destroyer", 500, 250, 70, 10, 800);
    private static UnitStats riflemanUnitStats = new UnitStats("Rifleman", 25, 5, 50, 25, 800);
    private static UnitStats tankUnitStats = new UnitStats("Tank", 200, 100, 50, 25, 800);

    private UnitStatsRepository() { }

    public static UnitStats GetDestroyerStats()
    {
      return destroyerUnitStats;
    }

    public static UnitStats GetRiflemanStats()
    {
      return riflemanUnitStats;
    }
    public static UnitStats GetTankStats()
    {
      return tankUnitStats;
    }
  }
}