namespace DesignPatterns.BuilderApproach_2
{
  public class HouseDirector
  {
    private IHouseBuilder houseBuilder;

    public HouseDirector(IHouseBuilder houseBuilder)
    {
      this.houseBuilder = houseBuilder;
    }

    public void BuildHouse()
    {
      houseBuilder.BuildWalls();
      houseBuilder.BuildFloors();
      houseBuilder.BuildRooms();
      houseBuilder.BuildRoof();
      houseBuilder.BuildWindows();
      houseBuilder.BuildDoors();
      houseBuilder.BuildGarage();
    }

    public HouseTwo GetHouse()
    {
      return this.houseBuilder.GetHouse();
    }
  }
}