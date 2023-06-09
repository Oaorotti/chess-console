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

        public Piece[,]? Pieces;

        public ChessBoard(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;

            Pieces = new Piece[Rows, Columns];
        }
    }
}
