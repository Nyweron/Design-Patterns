namespace DesignPatterns.units
{
  public abstract class InfantryUnit
  {
    private int hp;
    private int exp;
    private int dmgDone;

    protected InfantryUnit(int hp, int exp, int dmgDone)
    {
      this.hp = hp;
      this.exp = exp;
      this.dmgDone = dmgDone;
    }

    public int Hp { get => hp; set => hp = value; }
    public int Exp { get => exp; set => exp = value; }
    public int DmgDone { get => dmgDone; set => dmgDone = value; }
  }

}