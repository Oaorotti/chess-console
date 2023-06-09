using Board;

namespace chess_console
{
    internal class PrintChessBoard
    {
        public static void PrintBoard(ChessBoard board)
        {
            for (int i = 0; i < board.Rows; i++)
            {
                for (int j = 0; j < board.Columns; j++)
                {

                    if (board.ReturnPiece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.ReturnPiece(i, j) + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
