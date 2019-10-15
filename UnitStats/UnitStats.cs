namespace Design_Patterns.UnitStats
{
  public class UnitStats
  {
    private string name;
    private int hp;
    private int armour;
    private int damageDealt;
    private int speed;
    private int resourceCost;

    public UnitStats(string name, int hp, int armour, int damageDealt, int speed, int resourceCost)
    {
      this.name = name;
      this.hp = hp;
      this.armour = armour;
      this.damageDealt = damageDealt;
      this.speed = speed;
      this.resourceCost = resourceCost;
    }

    public string Name { get => name; }
    public int Hp { get => hp; }
    public int Armour { get => armour; }
    public int DamageDealt { get => damageDealt; }
    public int Speed { get => speed; }
    public int ResourceCost { get => resourceCost; }
  }
}