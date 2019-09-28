namespace DesignPatterns.BuilderApproach_2
{
  public class SmallHouseBuilder : IHouseBuilder
  {
    private HouseTwo house;

    public SmallHouseBuilder()
    {
      this.house = new HouseTwo();
    }

    public void BuildDoors()
    {
      this.house.doors = "small doors";
    }

    public void BuildFloors()
    {
      this.house.floor = "small floors";
    }

    public void BuildGarage()
    {
      this.house.garage = "small gargage";
    }

    public void BuildRoof()
    {
      this.house.roof = "small roofs";
    }

    public void BuildRooms()
    {
      this.house.rooms = "small rooms";
    }

    public void BuildWalls()
    {
      this.house.walls = "small walls";
    }

    public void BuildWindows()
    {
      this.house.windows = "small windows";
    }

    public HouseTwo GetHouse()
    {
      return house;
    }
  }
}