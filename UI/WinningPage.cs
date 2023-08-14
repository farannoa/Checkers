using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex05.Logic;

namespace Ex05.UI
{
    public partial class WinningPage : Form
    {
        public bool PlayAgain { get; private set; }

        public WinningPage(Player i_WinningPlayer)
        {
            int score = computeScore(i_WinningPlayer.GetPiecesList());
            i_WinningPlayer.Score += score;
            InitializeComponent();
            winningPageLabel.Text = String.Format("{0} won the game! {0} have {1} points!\nDo you want to play again?", i_WinningPlayer.Name, score);
            this.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.DimGray;
            PlayAgain = true;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.DimGray;
            PlayAgain = false;
            this.Close();
        }

        private static int computeScore(List<Piece> i_List)
        {
            int score = 0;

            for (int i = 0; i < i_List.Count(); i++)
            {
                if (i_List[i].IsKing())
                {
                    score += 4;
                }
                else
                {
                    score += 1;
                }
            }

            return score;
        }
    }
}
