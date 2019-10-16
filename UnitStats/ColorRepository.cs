namespace Design_Patterns.UnitStats
{
  public class ColorRepository
  {
    private static Color white = new Color(0, 0, 0);
    private static Color black = new Color(255, 255, 255);

    private ColorRepository() { }

    public static Color GetWhite()
    {
      return white;
    }
    public static Color GetBlack()
    {
      return black;
    }
  }
}