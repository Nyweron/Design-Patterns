using System;

namespace DesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {

      // var house1 = new House("walls", "floors", "rooms", "windows", "doors", "garage");

      //var house2 = new House();
      // What fields we should use now?
      // it is mess
      // what is correct order
      // we do not sure which fileds should be init...
      // Builder is solving this problem

      Console.WriteLine("Hello World!");

      // Client client = new Client.Builder()
      //   .FirstName("Slawomir")
      //   .LastName("Kowalski")
      //   .ZipCode("34 174")
      //   .MyWallet(456.32)
      //   .HomeNumber(23)
      //   .Town("Cambridge")
      //   .Street("botolph lane")
      //   .build();

      // Console.WriteLine("Data client: " + "\nFirstName: " + client.FirstName +
      //   "\nKowalski: " + client.LastName +
      //   "\nZip code: " + client.ZipCode +
      //   "\nWallet: " + client.MyWallet +
      //   "\nHome number: " + client.HomeNumber +
      //   "\nTown: " + client.Town +
      //   "\nStreet: " + client.Street);

      House houses = new House.HouseBuilder()
        .Walls("Sciany")
        .Doors("Drzwi")
        .Floor("Podłoga")
        .Build();

      Console.WriteLine(houses.ToString());

      Console.ReadKey();
    }
  }

}