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
            try
            {
                ChessMatch match = new ChessMatch();

                while(!match.EndMatch)
                {
                    Console.Clear();
                    PrintChessBoard.PrintBoard(match.Board);

                    Console.WriteLine("Enter the origin: ");
                    Position origin = PrintChessBoard.ReadKeyboardInput().ConvertToPosition();

                    Console.WriteLine("Enter the destiny: ");
                    Position destiny = PrintChessBoard.ReadKeyboardInput().ConvertToPosition();

                    match.MakeMovement(origin, destiny);
                }

            } catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}