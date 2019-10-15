using Design_Patterns.UnitStats;

namespace DesignPatterns
{
  public class Rifleman
  {
    private int x;
    private int y;
    private int hpLeft;
    private UnitStats stats;

    public Rifleman(int x, int y)
    {
      stats = UnitStatsRepository.GetRiflemanStats();
      this.x = x;
      this.y = y;
      this.hpLeft = stats.Hp;
    }
  }
}