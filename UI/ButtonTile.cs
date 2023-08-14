using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex05.Logic;
using Ex05.UI.Properties;

namespace Ex05.UI
{
    public class ButtonTile : Button
    {
        public int Row { get; set; }  
        public int Col { get; set; } 
        public char CharToImage { get; set; }

        public ButtonTile(int i_Row, int i_Col)
        {
            Row = i_Row;
            Col = i_Col;
            this.ChangeToPicture();
        }

        public void ChangeToPicture()
        {
            int width = this.Width ;
            int height = this.Height ;

            switch (CharToImage)
            {
                case 'X':
                    this.Image = new Bitmap(Resources.DarkBrownImage, this.Width - 10 , this.Height - 13);
                    break;
                case 'Z':
                    this.Image = new Bitmap(Resources.BibiKingPicture, this.Width, this.Height);
                    break;
                case 'O':
                    this.Image = new Bitmap(Resources.lightBrown, this.Width - 10 , this.Height - 13);
                    break;
                case 'Q':
                    this.Image = new Bitmap(Resources.saraIsQueen, this.Width, this.Height);
                    break;
                case ' ':
                    this.Image = null;
                    break;
            }
            
        }

    }
}