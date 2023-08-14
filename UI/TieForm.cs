using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05.UI
{
    public partial class TieForm : Form
    {
        public bool PlayAgain { get; private set; }
        public TieForm()
        {
            PlayAgain = false;
            InitializeComponent();
            this.ShowDialog();
        }

        private void ItsATieName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TieForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.DimGray;
            PlayAgain = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.DimGray;
            this.Close();
        }

        private void BennetPicureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
