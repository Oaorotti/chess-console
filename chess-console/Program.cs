using Board;
using Chess;
using chess_console.Board.Enums;
using Exceptions;

namespace chess_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Chess Game";

            ChessPosition position = new ChessPosition('A', 1);

            Console.WriteLine(position.ConvertToPosition());

            Console.WriteLine(position);
        }
    }
}