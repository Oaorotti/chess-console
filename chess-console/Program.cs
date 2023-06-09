using Board;

namespace chess_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChessBoard board = new ChessBoard(8, 8);

            PrintChessBoard.PrintBoard(board);

            Console.WriteLine(board);
        }
    }
}