namespace DesignPatterns
{
  public class HouseProblem
  {
    private string walls;
    private string floor;
    private string rooms;
    private string roof;
    private string windows;
    private string doors;
    private string garage;

    public HouseProblem(string walls, string floor, string rooms)
    {
      this.walls = walls;
      this.floor = floor;
      this.rooms = rooms;
    }

    public HouseProblem(string walls, string floor, string rooms, string roof, string windows, string doors)
    {
      this.walls = walls;
      this.floor = floor;
      this.rooms = rooms;
      this.roof = roof;
      this.windows = windows;
      this.doors = doors;
    }

    public HouseProblem(string walls, string floor, string rooms, string roof, string windows, string doors, string garage)
    {
      this.walls = walls;
      this.floor = floor;
      this.rooms = rooms;
      this.roof = roof;
      this.windows = windows;
      this.doors = doors;
      this.garage = garage;
    }

    public override string ToString()
    {
      return string.Format("[{0}, {1}, {2}, {3}, {4}, {5}, {6}]", this.walls, this.floor, this.rooms, this.roof, this.windows, this.doors, this.garage);
    }
  }
}