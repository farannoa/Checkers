using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.Logic
{
    public class Tile
    {
        public readonly int r_Col;
        public readonly int r_Row;
        private Piece m_OccupiedPiece;

        public Tile(int i_Row, int i_Col)
        {
            r_Col = i_Col;
            r_Row = i_Row;
            m_OccupiedPiece = null;
        }

        public Piece GetPiece()
        {

            return m_OccupiedPiece;
        }

        public void SetPiece(Piece i_PieceToSet)
        {
            m_OccupiedPiece = i_PieceToSet;
        }

        public bool IsOccupied()
        {

            return this.GetPiece() != null;
        }

        public int GetRow()
        {

            return r_Row;
        }

        public int GetColumn()
        {

            return r_Col;
        }
    }
}