using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board
{
    internal class ChessBoard
    {
        public int Rows { get; set; }
        public int Columns { get; set; }

        private Piece[,]? Pieces;

        public ChessBoard(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;

            Pieces = new Piece[Rows, Columns];
        }

        public Piece ReturnPiece(int row, int column)
        {
            return Pieces[row, column];
        }

        public Piece ReturnPiece(Position position)
        {
            return Pieces[position.Row, position.Column];
        }

        public bool PieceExistsPosition(Position position)
        {
            CheckValidPosition(position);

            return ReturnPiece(position) != null;
        }

        public void SetPiece(Piece piece, Position position)
        {
            if (PieceExistsPosition(position))
            {
                throw new BoardException("There's already a piece in this position!");
            }

            Pieces[position.Row, position.Column] = piece;
            piece.Position = position;
        }

        public Piece RemovePiece(Position position)
        {
            if (PieceExistsPosition(position) == null)
            {
                return null;
            }

            Piece tempVar = ReturnPiece(position);
            tempVar.Position = null;
            Pieces[position.Row, position.Column] = null;
            return tempVar;
        }

        public bool ValidPosition(Position position)
        {
            if (position.Row < 0 || position.Column >= Rows || position.Column < 0 || position.Column >= Columns)
            {
                return false;
            }

            return true;
        }

        public void CheckValidPosition(Position position)
        {
            if (!ValidPosition(position))
            {
                throw new BoardException("invalid position!");
            }
        }
    }
}
