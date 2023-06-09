using Board;
using chess_console.Board.Enums;

namespace Chess
{
    internal class Tower : Piece
    {
        public Tower(Color color, ChessBoard board) : base(color, board)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}