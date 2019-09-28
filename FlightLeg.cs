using System.ComponentModel.DataAnnotations;

namespace DesignPatterns
{
  /* fluent interface */
  public class FlightLeg
  {
    private string _from;
    private string _to;
    private bool _delayed;
    private int _price;

    private FlightLeg(FlightLegBuilder flightLegBuilder)
    {
      _from = flightLegBuilder.from;
      _to = flightLegBuilder.to;
      _price = flightLegBuilder.price;
      _delayed = flightLegBuilder.delayed;
    }

    public void SetDelayed(bool delayed)
    {
      _delayed = delayed;
    }

    public void SetPrice(int price)
    {
      _price = price;
    }

    public override string ToString()
    {
      return $"from: {_from}\nto: {_to}\nprice: {_price}\ndelayed: {_delayed}\n";
    }

    public class FlightLegBuilder
    {
      public string from;
      public string to;
      public bool delayed;
      public int price;

      public FlightLegBuilder(string from, string to)
      {
        this.from = from;
        this.to = to;
      }

      public FlightLegBuilder Price(int price)
      {
        this.price = price;
        return this;
      }

      public FlightLeg Build()
      {
        if (this.price == 0)
        {
          throw new ValidationException("Required field is empty- price");
        }

        return new FlightLeg(this);
      }
    }
  }
}