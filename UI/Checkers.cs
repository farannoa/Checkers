using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Ex05.Logic;

namespace Ex05.UI
{
    public partial class Checkers : Form
    {
        private readonly int r_BoardSize;
        private readonly Player r_PlayerOne;
        private readonly Player r_PlayerTwo;
        private Player m_CurrentPlayer;
        private Player m_OtherPlayer;
        private readonly Board r_Board;
        private readonly ButtonTile[,] r_Buttons;
        private readonly Color[] r_Colors = new Color[] { Color.DimGray, Color.White };
        private int m_PickedRow;
        private int m_PickedCol;
        private bool m_AteAPiece;
        const int k_SizeOfButton = 100;

        public Checkers(Form i_GameSettings)
        {
            r_BoardSize = (i_GameSettings as GameSetting).BoardSize;
            r_PlayerOne = new Player((i_GameSettings as GameSetting).PlayerOneName, false, 'X', 'Z', "Up");
            r_PlayerTwo = new Player(
                (i_GameSettings as GameSetting).PlayerTwoName,
                (i_GameSettings as GameSetting).IsComputer,
                'O',
                'Q',
                "Down");
            m_CurrentPlayer = r_PlayerOne;
            m_OtherPlayer = r_PlayerTwo;
            r_Board = new Board(r_BoardSize, r_PlayerOne, r_PlayerTwo);
            r_Buttons = new ButtonTile[r_BoardSize, r_BoardSize];
            InitializeComponent();
            this.Size = new Size(r_BoardSize * (k_SizeOfButton + 4), r_BoardSize * (k_SizeOfButton + 4) + 100);
            PanelGame.Size = new Size(r_BoardSize * (k_SizeOfButton + 4), r_BoardSize * (k_SizeOfButton + 4));
            init();
            ShowDialog();
        }

        private void restart(Form i_EndGameForm)
        {
            bool playAgain = false;

            if(i_EndGameForm is WinningPage)
            {
                playAgain = (i_EndGameForm as WinningPage).PlayAgain;
            }
            else
            {
                if(i_EndGameForm is WinningPage)
                {
                    playAgain = (i_EndGameForm as WinningPage).PlayAgain;
                }
            }

            if(playAgain)
            {
                m_PickedRow = -1;
                m_PickedCol = -1;
                m_AteAPiece = false;
                r_Board.Restart();
                m_CurrentPlayer = r_PlayerOne;
                m_OtherPlayer = r_PlayerTwo;
                for(int row = 0; row < r_BoardSize; row++)
                {
                    for(int col = 0; col < r_BoardSize; col++)
                    {
                        if(r_Board.GetTile(row, col).IsOccupied())
                        {
                            r_Buttons[row, col].CharToImage = r_Board.GetTile(row, col).GetPiece().GetShape();
                        }
                        else
                        {
                            r_Buttons[row, col].CharToImage = ' ';
                        }

                        r_Buttons[row, col].ChangeToPicture();
                    }
                }

                this.Update();

                return;
            }

            this.Close();
        }

        private void init()
        {
            m_PickedRow = -1;
            m_PickedCol = -1;
            m_AteAPiece = false;
            r_Board.Init();
            r_Board.Restart();

            for(int row = 0; row < r_BoardSize; row++)
            {
                if(row % 2 == 0)
                {
                    r_Colors[0] = Color.DimGray;
                    r_Colors[1] = Color.White;
                }
                else
                {
                    r_Colors[1] = Color.DimGray;
                    r_Colors[0] = Color.White;
                }

                for(int col = 0; col < r_BoardSize; col++)
                {
                    r_Buttons[row, col] = new ButtonTile(row, col);
                    r_Buttons[row, col].BackColor = r_Colors[(col % 2 == 0) ? 1 : 0];
                    if((row + col) % 2 == 0)
                    {
                        r_Buttons[row, col].Enabled = false;
                    }

                    if(r_Board.GetTile(row, col).IsOccupied())
                    {
                        r_Buttons[row, col].CharToImage = r_Board.GetTile(row, col).GetPiece().GetShape();
                    }

                    r_Buttons[row, col].ChangeToPicture();
                    this.playerNameOne.Text = String.Format("its {0} turn's!", m_CurrentPlayer.Name);
                    r_Buttons[row, col].Click += Checkers_Click;
                }
            }

            this.printUIBoard();
        }


        private void printUIBoard()
        {
            int left = 2;
            int top = 2;
            
            for(int row = 0; row < r_BoardSize; row++)
            {
                left = 2;
                for(int col = 0; col < r_BoardSize; col++)
                {
                    r_Buttons[row, col].Location = new Point(left, top);
                    r_Buttons[row, col].Size = new Size(k_SizeOfButton, k_SizeOfButton);
                    r_Buttons[row, col].FlatAppearance.BorderColor = Color.DimGray;
                    r_Buttons[row, col].FlatAppearance.BorderSize = 4;
                    PanelGame.Controls.Add(r_Buttons[row, col]);
                    left += k_SizeOfButton;
                    r_Buttons[row, col].ChangeToPicture();
                }

                top += k_SizeOfButton;
            }
        }

        private void Checkers_Click(object sender, EventArgs e)
        {
            ButtonTile button = sender as ButtonTile;
            int destRow = button.Row;
            int destCol = button.Col;
            Tile currentTile = r_Board.GetTile(destRow, destCol);

            if(!m_CurrentPlayer.GetIsComputer())
            {
                if(m_PickedRow == -1 && m_PickedCol == -1)
                {
                    if(currentTile.IsOccupied())
                    {
                        if(currentTile.GetPiece().GetPlayer() == m_CurrentPlayer)
                        {
                            changeColor(m_PickedRow, m_PickedCol, destRow, destCol);
                            m_PickedRow = destRow;
                            m_PickedCol = destCol;
                        }
                        else
                        {
                            new InvalidMoveForm("Please Choose Your Own Pawn");
                        }
                    }
                    else
                    {
                        new InvalidMoveForm("You have chosen an empty tile");
                    }
                }
                else
                {
                    if(destRow == m_PickedRow && destCol == m_PickedCol)
                    {
                        changeColor(m_PickedRow, m_PickedCol, destRow, destCol);
                        m_PickedRow = -1;
                        m_PickedCol = -1;
                    }
                    else
                    {
                        if(currentTile.IsOccupied())
                        {
                            if(currentTile.GetPiece().GetPlayer() == m_CurrentPlayer)
                            {
                                changeColor(m_PickedRow, m_PickedCol, destRow, destCol);
                                m_PickedRow = destRow;
                                m_PickedCol = destCol;
                            }
                            else
                            {
                                new InvalidMoveForm("You Have Chosen an occupied tile");
                            }
                        }
                        else
                        {
                            if(GameLogic.IsLegalMove(
                                   m_CurrentPlayer,
                                   r_Board,
                                   m_PickedRow,
                                   m_PickedCol,
                                   destRow,
                                   destCol))
                            {
                                GameLogic.MovePiece(
                                    m_CurrentPlayer,
                                    r_Board,
                                    m_PickedRow,
                                    m_PickedCol,
                                    destRow,
                                    destCol);
                                r_Buttons[destRow, destCol].Image = r_Buttons[m_PickedRow, m_PickedCol].Image;
                                r_Buttons[destRow, destCol].CharToImage =
                                    r_Board.GetTile(destRow, destCol).GetPiece().GetShape();
                                r_Buttons[destRow, destCol].ChangeToPicture();
                                r_Buttons[m_PickedRow, m_PickedCol].Image = null;
                                if(Math.Abs(m_PickedRow - destRow) == 2)
                                {
                                    int enemyRow = (destRow + m_PickedRow) / 2;
                                    int enemyCol = (destCol + m_PickedCol) / 2;
                                    r_Buttons[enemyRow, enemyCol].Image = null;

                                    if(GameLogic.SinglePieceCanEat(m_CurrentPlayer, r_Board, currentTile.GetPiece())
                                       .Any())
                                    {
                                        changeColor(m_PickedRow, m_PickedCol, destRow, destCol);
                                        m_PickedCol = destCol;
                                        m_PickedRow = destRow;
                                        m_AteAPiece = true;
                                    }
                                    else
                                    {
                                        Player temp = m_CurrentPlayer;
                                        m_CurrentPlayer = m_OtherPlayer;
                                        m_OtherPlayer = temp;
                                        changeColor(m_PickedRow, m_PickedCol, m_PickedRow, m_PickedCol);
                                        m_PickedCol = -1;
                                        m_PickedRow = -1;
                                        m_AteAPiece = false;
                                    }
                                }
                                else
                                {
                                    Player temp = m_CurrentPlayer;
                                    m_CurrentPlayer = m_OtherPlayer;
                                    m_OtherPlayer = temp;
                                    changeColor(m_PickedRow, m_PickedCol, m_PickedRow, m_PickedCol);
                                    m_PickedCol = -1;
                                    m_PickedRow = -1;
                                    m_AteAPiece = false;
                                }
                            }
                            else
                            {
                                new InvalidMoveForm();
                            }
                        }
                    }
                }
            }

            bool currentPlayerHasLegalMoves = GameLogic.AnyLegalMoves(m_CurrentPlayer, r_Board);
            bool otherPlayerHasLegalMoves = GameLogic.AnyLegalMoves(m_OtherPlayer, r_Board);
            if(!currentPlayerHasLegalMoves && !otherPlayerHasLegalMoves)
            {
                TieForm tie = new TieForm();
                this.restart(tie);
            }
            else
            {
                if(!currentPlayerHasLegalMoves || !m_CurrentPlayer.GetPiecesList().Any())
                {
                    WinningPage win = new WinningPage(m_OtherPlayer);
                    this.restart(win);
                }
            }

            playerNameOne.Text = String.Format("It's {0}'s turn!", m_CurrentPlayer.Name); 
            if(m_CurrentPlayer.GetIsComputer())
            {
                this.Update();
                Thread.Sleep(1000);
                GameLogic.ComputerPlay(m_CurrentPlayer, r_Board);
                for(int row = 0; row < r_BoardSize; row++)
                {
                    for(int col = 0; col < r_BoardSize; col++)
                    {
                        if(r_Board.GetTile(row, col).IsOccupied())
                        {
                            r_Buttons[row, col].CharToImage = r_Board.GetTile(row, col).GetPiece().GetShape();
                        }
                        else
                        {
                            r_Buttons[row, col].CharToImage = ' ';
                        }

                        r_Buttons[row, col].ChangeToPicture();
                    }
                }

                Player tempPlayer = m_CurrentPlayer;
                m_CurrentPlayer = m_OtherPlayer;
                m_OtherPlayer = tempPlayer;
                playerNameOne.Text = m_CurrentPlayer.Name;
                currentPlayerHasLegalMoves = GameLogic.AnyLegalMoves(m_CurrentPlayer, r_Board);
                otherPlayerHasLegalMoves = GameLogic.AnyLegalMoves(m_OtherPlayer, r_Board);
                if(!currentPlayerHasLegalMoves && !otherPlayerHasLegalMoves)
                {
                    TieForm tie = new TieForm();
                    this.restart(tie);
                }
                else
                {
                    if(!currentPlayerHasLegalMoves || !m_CurrentPlayer.GetPiecesList().Any())
                    {
                        WinningPage win = new WinningPage(m_OtherPlayer);
                        this.restart(win);
                    }
                }

                playerNameOne.Text = String.Format("It's {0}'s turn!", m_CurrentPlayer.Name);
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeColor(int i_CurrentRow, int i_CurrentCol, int i_DestRow, int i_DestCol)
        {
            if(i_CurrentRow == -1 && i_CurrentCol == -1)
            {
                r_Buttons[i_DestRow, i_DestCol].BackColor = Color.LightBlue;
            }
            else
            {
                if(i_CurrentRow == i_DestRow && i_CurrentCol == i_DestCol)
                {
                    r_Buttons[i_CurrentRow, i_CurrentCol].BackColor = Color.DimGray;
                }
                else
                {
                    r_Buttons[i_CurrentRow, i_CurrentCol].BackColor = Color.DimGray;
                    r_Buttons[i_DestRow, i_DestCol].BackColor = Color.LightBlue;
                }

                if(i_DestRow == -1 && i_DestCol == -1)
                {
                    r_Buttons[i_DestRow, i_DestCol].BackColor = Color.DimGray;
                }
            }
        } 
    }
}
