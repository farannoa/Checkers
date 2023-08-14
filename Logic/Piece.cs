using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.Logic
{
    public class Piece
    {
        private readonly Player r_Player;
        public Tile Location { get; set; }
        private bool m_IsKing;

        public Piece(Player i_Player, Tile i_Location)
        {
            r_Player = i_Player;
            Location = i_Location;
            m_IsKing = false;
        }

        public bool IsKing()
        {

            return m_IsKing;
        }

        public void SetToKing()
        {
            m_IsKing = true;
        }

        public char GetShape()
        {
            char shape = r_Player.Shape;
            if (this.IsKing())
            {
                shape = r_Player.KingShape;
            }

            return shape;
        }

        public Player GetPlayer()
        {

            return r_Player;
        }
    }
}