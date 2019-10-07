using DesignPatterns.cars.bmw;
using DesignPatterns.cars.ford;

namespace DesignPatterns
{
  public interface IFactory
  {
    CarAbstract BuildBmw(BMWModelsEnum model);
    CarAbstract BuildFord(FordModelsEnum model);
  }
}