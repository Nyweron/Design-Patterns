namespace DesignPatterns
{
  public abstract class CarAbstract
  {
    private string _modelName;
    private PositionEnum _position;

    protected CarAbstract(string modelName, PositionEnum position)
    {
      _modelName = modelName;
      _position = position;
    }

    public PositionEnum Position { get => _position; set => _position = value; }
  }
}