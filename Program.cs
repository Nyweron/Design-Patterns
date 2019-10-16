using System;
using Design_Patterns;
using Design_Patterns.Pieces;

namespace DesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {
      ChessPiece whitePawn = new WhitePiece("White Pawn", 2, 'b');
      ChessPiece whiteQueen = new WhiteQueen("White Queen");

      ChessPiece blackPawn = new BlackPiece("Black Pawn", 2, 'e');
      ChessPiece blackQueen = new BlackQueen("Black Queen");

      Console.WriteLine(whitePawn.Color == whiteQueen.Color);
      Console.WriteLine(blackPawn.Color == blackQueen.Color);
    }
  }
}