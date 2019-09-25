using System;

namespace DesignPatterns
{
  public class GuessGame
  {
    private int points = 0;
    private static readonly GuessGame instance = new GuessGame();
    private Random random = new Random();
    private GuessGame()
    {

    }

    public void Play()
    {
      for (int i = 0; i < 10; i++)
      {
        var randomInt = random.Next(10);

        Console.WriteLine("Choose number from 0 to 9: ");
        var input = Console.ReadLine();

        if (randomInt == Convert.ToInt32(input))
        {
          Console.WriteLine("Good!");
          points++;
        }
        else
        {
          Console.WriteLine($"I thought about: {randomInt}");
        }
      }
    }

    public int GetScore()
    {
      return points;
    }

    public static GuessGame GetInstance()
    {
      return instance;
    }
  }
}