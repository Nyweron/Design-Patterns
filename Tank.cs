using Design_Patterns.UnitStats;

namespace DesignPatterns
{
  public class Tank
  {
    private int x;
    private int y;
    private int hpLeft;
    private UnitStats stats;

    public Tank(int x, int y)
    {
      stats = UnitStatsRepository.GetTankStats();
      this.x = x;
      this.y = y;
      this.hpLeft = stats.Hp;
    }
  }
}