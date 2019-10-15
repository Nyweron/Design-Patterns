using Design_Patterns.UnitStats;

namespace DesignPatterns
{
  public class Destroyer
  {
    private int x;
    private int y;
    private int hpLeft;
    private UnitStats stats;

    public Destroyer(int x, int y)
    {
      /*  UnitStatsRepository.GetDestroyerStats() - Returns only one object which was loaded on compilation mode, only once (static) */
      stats = UnitStatsRepository.GetDestroyerStats();
      this.x = x;
      this.y = y;
      this.hpLeft = stats.Hp;
    }
  }
}