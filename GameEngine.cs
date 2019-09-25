using System;

namespace DesignPatterns
{
  public class GameEngine
  {
    private int hp = 100;
    private string characterName = "";
    //private static readonly Lazy<GameEngine> lazy = new Lazy<GameEngine>(() => new GameEngine());
    private static readonly GameEngine instance = new GameEngine();
    private GameEngine() { }

    public void Run()
    {
      while (true) { }
    }

    public static GameEngine GetInstance()
    {
      //return lazy.Value;
      return instance;
    }
  }
}