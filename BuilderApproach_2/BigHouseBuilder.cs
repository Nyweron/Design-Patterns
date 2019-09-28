namespace DesignPatterns.BuilderApproach_2
{
  public class BigHouseBuilder : IHouseBuilder
  {
    private HouseTwo house;

    public BigHouseBuilder()
    {
      this.house = new HouseTwo();
    }

    public void BuildDoors()
    {
      this.house.doors = "big doors";
    }

    public void BuildFloors()
    {
      this.house.floor = "big floors";
    }

    public void BuildGarage()
    {
      this.house.garage = "big gargage";
    }

    public void BuildRoof()
    {
      this.house.roof = "big roofs";
    }

    public void BuildRooms()
    {
      this.house.rooms = "big rooms";
    }

    public void BuildWalls()
    {
      this.house.walls = "big walls";
    }

    public void BuildWindows()
    {
      this.house.windows = "big windows";
    }

    public HouseTwo GetHouse()
    {
      return house;
    }
  }
}