using System.Text;

namespace Ex05.Logic
{
    public class Board
    {
        private int m_Size;
        private Tile[,] m_Board;
        private Player m_Player1;
        private Player m_Player2;

        public Board(int i_Size, Player i_Player1, Player i_Player2)
        {
            m_Size = i_Size;
            m_Board = new Tile[m_Size, m_Size];
            m_Player1 = i_Player1;
            m_Player2 = i_Player2;
        }

        public Tile GetTile(int row, int col)
        {
            return m_Board[row, col];
        }

        public int GetSize()
        {
            return m_Size;
        }

        public void Init()
        {
            for (int row = 0; row < m_Size; row++)
            {
                for (int col = 0; col < m_Size; col++)
                {
                    m_Board[row, col] = new Tile(row, col);
                }
            }
        }
        
        public void Restart()
        {
            m_Player1.ResetListOfPieces();
            m_Player2.ResetListOfPieces();
            int sizeAreaOfPlayer = ((m_Size - 2) / 2);
            for (int row = 0; row < m_Size; row++)
            {
                for (int col = 0; col < m_Size; col++)
                {
                    m_Board[row, col].SetPiece(null);
                    if((row + col) % 2 == 1)
                    {
                        if(row < sizeAreaOfPlayer)
                        {
                            Piece toSetShape = new Piece(m_Player2, m_Board[row, col]);
                            m_Board[row, col].SetPiece(toSetShape);
                            m_Player2.AddPieceToList(toSetShape);
                        }

                        if(row >= sizeAreaOfPlayer + 2)
                        {
                            Piece toSetShape = new Piece(m_Player1, m_Board[row, col]);
                            m_Board[row, col].SetPiece(toSetShape);
                            m_Player1.AddPieceToList(toSetShape);
                        }
                    }
                }
            }
        }
    }
}




