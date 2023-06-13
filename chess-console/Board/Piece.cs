using chess_console.Board.Enums;

namespace Board
{
    internal class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MovementQuantity { get; protected set; }
        public ChessBoard Board { get; protected set; }

        public Piece(Color color, ChessBoard board)
        {
            Position = null;
            Color = color;
            Board = board;
            MovementQuantity = 0; 
        }

        public void IncreaseMovement()
        {
            MovementQuantity++;
        }
    }
}
