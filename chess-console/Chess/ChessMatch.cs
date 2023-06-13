using System;
using Board;
using chess_console.Board.Enums;

namespace Chess
{
    internal class ChessMatch
    {
        public ChessBoard Board { get; private set; }
        private int Turn;
        private Color CurrentPlayer;
        public bool EndMatch { get; private set; }

        public ChessMatch()
        {
            Board = new ChessBoard(8, 8);
            Turn = 1;
            CurrentPlayer = Color.White;
            EndMatch = false;
            PutPieces();
        }

        public void MakeMovement(Position origin, Position destiny)
        {
            Piece piece = Board.RemovePiece(origin);
            piece.IncreaseMovement();
            Piece capturedPiece = Board.RemovePiece(destiny);
            Board.SetPiece(piece, destiny);
        }

        private void PutPieces()
        {
            Board.SetPiece(new Tower(Color.White, Board), new ChessPosition('c', 1).ConvertToPosition());
            Board.SetPiece(new Tower(Color.White, Board), new ChessPosition('c', 2).ConvertToPosition());
            Board.SetPiece(new Tower(Color.White, Board), new ChessPosition('c', 3).ConvertToPosition());

            Board.SetPiece(new Tower(Color.Black, Board), new ChessPosition('b', 1).ConvertToPosition());
            Board.SetPiece(new Tower(Color.Black, Board), new ChessPosition('b', 2).ConvertToPosition());
            Board.SetPiece(new Tower(Color.Black, Board), new ChessPosition('b', 3).ConvertToPosition());
        }
    }
}
