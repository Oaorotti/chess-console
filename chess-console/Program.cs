using Board;
using Chess;
using Exceptions;

namespace chess_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Chess Game";

            try
            {
                ChessBoard board = new ChessBoard(8, 8);
                board.SetPiece(new Tower(Color.Black, board), new Position(0, 0));
                board.SetPiece(new Tower(Color.Black, board), new Position(1, 4));
                board.SetPiece(new King(Color.White, board), new Position(2, 4));

                PrintChessBoard.PrintBoard(board);

                Console.WriteLine(board);
            } catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}