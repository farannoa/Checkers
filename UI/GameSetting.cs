using Ex05.Logic;

namespace Ex05.UI
{
    public partial class GameSetting : Form
    {
        public int BoardSize { get; set; }

        public string PlayerOneName { get; set;}

        public string PlayerTwoName { get; set; }

        public bool IsComputer { get; set; }
        public GameSetting()
        {
            InitializeComponent();
            NameOfPlayer2TextBox.Enabled = false;
            NameOfPlayer2TextBox.Text = "[Computer]";
            PlayerTwoName = "Computer";
            IsComputer = true;
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonSix_CheckedChanged(object sender, EventArgs e)
        {
            BoardSize = 6;
        }


        private void RadioButtonEight_CheckedChanged(object sender, EventArgs e)
        {
            BoardSize = 8;
        }

        private void RadioButtonTen_CheckedChanged(object sender, EventArgs e)
        {
            BoardSize = 10;
        }

        private void NameOfPlayer1_TextChanged(object sender, EventArgs e)
        {
            PlayerOneName = (sender as TextBox).Text;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Checkers game = new Checkers(this);
            this.Close();
        }

        private void NameOfPlayer2_TextChanged(object sender, EventArgs e)
        {
            PlayerTwoName = (sender as TextBox).Text;
        }

        private void CheckBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as CheckBox).Checked)
            {
                NameOfPlayer2TextBox.Enabled = true;
                NameOfPlayer2TextBox.Text = "";
                PlayerTwoName = NameOfPlayer2TextBox.Text;
                IsComputer = false;
            }
            else
            {
                NameOfPlayer2TextBox.Enabled = false;
                NameOfPlayer2TextBox.Text = "[Computer]";
                PlayerTwoName = "Computer";
                IsComputer = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}