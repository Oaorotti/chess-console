using Board;
using Chess;

namespace chess_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Chess Game";

            ChessBoard board = new ChessBoard(8, 8);
            board.SetPiece(new Tower(Color.Black, board), new Position(0, 0));
            board.SetPiece(new Tower(Color.Black, board), new Position(1, 4));
            board.SetPiece(new King(Color.White, board), new Position(1, 3));

            PrintChessBoard.PrintBoard(board);

            Console.WriteLine(board);
        }
    }
}