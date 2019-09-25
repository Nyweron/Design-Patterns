using System;

namespace DesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {
      GuessGame game = GuessGame.GetInstance();

      game.Play();

      int score = game.GetScore();

      GuessGame anotherGameReference = GuessGame.GetInstance();

      if (game == anotherGameReference)
      {
        Console.WriteLine("Singleton!");
        if (score == anotherGameReference.GetScore())
        {
          Console.WriteLine("Points are the same!");
        }
      }
    }
  }
}