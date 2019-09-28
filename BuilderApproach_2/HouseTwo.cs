namespace DesignPatterns.BuilderApproach_2
{
  public class HouseTwo
  {
    public string walls { get; set; }
    public string floor { get; set; }
    public string rooms { get; set; }
    public string roof { get; set; }
    public string windows { get; set; }
    public string doors { get; set; }
    public string garage { get; set; }

    public override string ToString()
    {
      return string.Format("[ {0}, {1}, {2}, {3}, {4}, {5}, {6}]", this.walls, this.floor, this.rooms, this.roof, this.windows, this.doors, this.garage);
    }

  }
}