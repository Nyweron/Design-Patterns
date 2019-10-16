using Design_Patterns.UnitStats;

namespace Design_Patterns
{
  public abstract class ChessPiece
  {
    private string name;
    private int numberPosition;
    private char letterPosition;
    private Color color;

    public ChessPiece(string name, int numberPosition, char letterPosition, string color)
    {
      this.name = name;
      this.numberPosition = numberPosition;
      this.letterPosition = letterPosition;
      switch (color)
      {
        case "black":
          this.color = ColorRepository.GetBlack();
          break;
        default:
          this.color = ColorRepository.GetWhite();
          break;
      }
    }

    public Color Color { get => color; }
  }
}