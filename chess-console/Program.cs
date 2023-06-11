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
                ChessBoard chessBoard = new ChessBoard(8, 8);

                chessBoard.SetPiece(new Tower(Color.Black, chessBoard), new Position(1, 2));
                chessBoard.SetPiece(new King(Color.White, chessBoard), new Position(1, 5));
                chessBoard.SetPiece(new Tower(Color.Black, chessBoard), new Position(1, 6));

                PrintChessBoard.PrintBoard(chessBoard);

            } catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}