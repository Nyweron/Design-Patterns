namespace DesignPatterns.BuilderApproach_2
{
  public interface IHouseBuilder
  {
    void BuildWalls();
    void BuildFloors();
    void BuildRooms();
    void BuildRoof();
    void BuildWindows();
    void BuildDoors();
    void BuildGarage();

    HouseTwo GetHouse();
  }
}