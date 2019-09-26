namespace DesignPatterns
{
  /* Builder fluent interface  ('static class') */
  class House
  {
    private string walls;
    private string floor;
    private string rooms;
    private string roof;
    private string windows;
    private string doors;
    private string garage;

    public House(HouseBuilder houseBuilder)
    {
      walls = houseBuilder.walls;
      floor = houseBuilder.floor;
      rooms = houseBuilder.rooms;
      roof = houseBuilder.roof;
      windows = houseBuilder.windows;
      doors = houseBuilder.doors;
      garage = houseBuilder.garage;
    }

    public override string ToString()
    {
      return string.Format("[ {0}, {1}, {2}, {3}, {4}, {5}, {6}]", this.walls, this.floor, this.rooms, this.roof, this.windows, this.doors, this.garage);
    }

    public class HouseBuilder
    {
      public string walls;
      public string floor;
      public string rooms;
      public string roof;
      public string windows;
      public string doors;
      public string garage;

      public HouseBuilder Walls(string walls)
      {
        this.walls = walls;
        return this;
      }

      public HouseBuilder Floor(string floor)
      {
        this.floor = floor;
        return this;
      }

      public HouseBuilder Rooms(string rooms)
      {
        this.rooms = rooms;
        return this;
      }

      public HouseBuilder Roof(string roof)
      {
        this.roof = roof;
        return this;
      }

      public HouseBuilder Windows(string windows)
      {
        this.windows = windows;
        return this;
      }

      public HouseBuilder Doors(string doors)
      {
        this.doors = doors;
        return this;
      }

      public HouseBuilder Garage(string garage)
      {
        this.garage = garage;
        return this;
      }

      public House Build()
      {
        return new House(this);
      }
    }
  }
}