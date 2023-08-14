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
    public partial class InvalidMoveForm : Form
    {
        public InvalidMoveForm(string i_InvalidMove)
        {
            InitializeComponent();
            label1.Text = String.Format("Invalid Move!\n{0}", i_InvalidMove);
            this.Show();
        }

        public InvalidMoveForm()
        {
            InitializeComponent();
            label1.Text = "Invalid Move!";
            this.Show();
        }


        private void InvalidMoveForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backLabelEnter(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.DarkBlue;

        }
    }
}
