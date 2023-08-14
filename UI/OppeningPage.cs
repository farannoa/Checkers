using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05.UI
{
    public partial class OpenningPage : Form
    {
        public OpenningPage()
        {
            InitializeComponent();
           // playSimpleSound();

        }

        private void OpenningPage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void startClick(object sender, EventArgs e)
        {
            this.Hide();
            GameSetting loginPage = new GameSetting();
            loginPage.ShowDialog();
            this.Close();

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Maroon;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void playSimpleSound()
        //{
        //SoundPlayer simpleSound = new SoundPlayer(
        //@"C:\Users\noafa\OneDrive\שולחן העבודה\B22 Ex05 Noa 207080136 Nadav 206933954\sara.wave");
        //simpleSound.Play();
        //}
    }
}
