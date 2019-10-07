using DesignPatterns.cars.bmw;
using DesignPatterns.cars.ford;

namespace DesignPatterns.implementedFactory
{
  public class RightSideFactory : IFactory
  {
    PositionEnum position = PositionEnum.RIGHT;

    public CarAbstract BuildBmw(BMWModelsEnum model)
    {
      switch (model)
      {
        case BMWModelsEnum.E60:
          return new BMW("xyz", position);
        case BMWModelsEnum.X5:
          return new BMW("abc", position);
        default:
          throw new System.Exception();
      }
    }

    public CarAbstract BuildFord(FordModelsEnum model)
    {
      switch (model)
      {
        case FordModelsEnum.CMAX:
          return new Ford("xyz", position);
        case FordModelsEnum.FOCUS:
          return new Ford("abc", position);
        default:
          throw new System.Exception();
      }
    }
  }
}