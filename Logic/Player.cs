using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.Logic
{
    public class Player
    {
        public string Name { get; private set; }
        public bool IsComputer { get; private set; }
        public char Shape { get; private set; }
        public char KingShape { get; private set; }
        public string Direction { get; private set; }
        public int Score { get; set; }
        List<Piece> m_ListOfPieces = new List<Piece>();

        public Player(string i_Name, bool i_IsComputer, char i_Shape, char i_KingShape, string i_direction)
        {
            Name = i_Name;
            IsComputer = i_IsComputer;
            Shape = i_Shape;
            KingShape = i_KingShape;
            Direction = i_direction;
            Score = 0;
        }

        public bool GetIsComputer()
        {

            return IsComputer;
        }

        public void AddPieceToList(Piece i_PieceToAdd)
        {
            m_ListOfPieces.Add(i_PieceToAdd);
        }

        public void ResetListOfPieces()
        {
            m_ListOfPieces = new List<Piece>();
        }

        public List<Piece> GetPiecesList()
        {

            return m_ListOfPieces;
        }

        public void RemoveFromPiecesList(Piece i_Piece)
        {
            int pieceRow = i_Piece.Location.GetRow();
            int pieceColumn = i_Piece.Location.GetColumn();
            for (int i = 0; i < m_ListOfPieces.Count; i++)
            {
                if (m_ListOfPieces[i].Location.GetRow() == pieceRow
                   && m_ListOfPieces[i].Location.GetColumn() == pieceColumn)
                {
                    m_ListOfPieces.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
        