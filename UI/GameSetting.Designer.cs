namespace Ex05.UI
{
    partial class GameSetting
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSetting));
            this.label1 = new System.Windows.Forms.Label();
            this.RadioButtonSix = new System.Windows.Forms.RadioButton();
            this.RadioButtonEight = new System.Windows.Forms.RadioButton();
            this.RadioButtonTen = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameOfPlayer1 = new System.Windows.Forms.TextBox();
            this.CheckBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.NameOfPlayer2TextBox = new System.Windows.Forms.TextBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(35, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Board Size:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RadioButtonSix
            // 
            this.RadioButtonSix.AutoSize = true;
            this.RadioButtonSix.BackColor = System.Drawing.Color.Red;
            this.RadioButtonSix.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonSix.ForeColor = System.Drawing.Color.Snow;
            this.RadioButtonSix.Location = new System.Drawing.Point(227, 133);
            this.RadioButtonSix.Name = "RadioButtonSix";
            this.RadioButtonSix.Size = new System.Drawing.Size(68, 27);
            this.RadioButtonSix.TabIndex = 1;
            this.RadioButtonSix.TabStop = true;
            this.RadioButtonSix.Text = "6x6";
            this.RadioButtonSix.UseVisualStyleBackColor = false;
            this.RadioButtonSix.CheckedChanged += new System.EventHandler(this.radioButtonSix_CheckedChanged);
            // 
            // RadioButtonEight
            // 
            this.RadioButtonEight.AutoSize = true;
            this.RadioButtonEight.BackColor = System.Drawing.Color.Red;
            this.RadioButtonEight.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonEight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RadioButtonEight.Location = new System.Drawing.Point(321, 133);
            this.RadioButtonEight.Name = "RadioButtonEight";
            this.RadioButtonEight.Size = new System.Drawing.Size(68, 27);
            this.RadioButtonEight.TabIndex = 2;
            this.RadioButtonEight.TabStop = true;
            this.RadioButtonEight.Text = "8x8";
            this.RadioButtonEight.UseVisualStyleBackColor = false;
            this.RadioButtonEight.CheckedChanged += new System.EventHandler(this.RadioButtonEight_CheckedChanged);
            // 
            // RadioButtonTen
            // 
            this.RadioButtonTen.AutoSize = true;
            this.RadioButtonTen.BackColor = System.Drawing.Color.Red;
            this.RadioButtonTen.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonTen.ForeColor = System.Drawing.SystemColors.Control;
            this.RadioButtonTen.Location = new System.Drawing.Point(417, 133);
            this.RadioButtonTen.Name = "RadioButtonTen";
            this.RadioButtonTen.Size = new System.Drawing.Size(84, 27);
            this.RadioButtonTen.TabIndex = 3;
            this.RadioButtonTen.TabStop = true;
            this.RadioButtonTen.Text = "10x10";
            this.RadioButtonTen.UseVisualStyleBackColor = false;
            this.RadioButtonTen.CheckedChanged += new System.EventHandler(this.RadioButtonTen_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(35, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Players:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(62, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player 1:";
            // 
            // NameOfPlayer1
            // 
            this.NameOfPlayer1.Location = new System.Drawing.Point(182, 192);
            this.NameOfPlayer1.Name = "NameOfPlayer1";
            this.NameOfPlayer1.Size = new System.Drawing.Size(369, 31);
            this.NameOfPlayer1.TabIndex = 7;
            this.NameOfPlayer1.TextChanged += new System.EventHandler(this.NameOfPlayer1_TextChanged);
            // 
            // CheckBoxPlayer2
            // 
            this.CheckBoxPlayer2.AutoSize = true;
            this.CheckBoxPlayer2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxPlayer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckBoxPlayer2.Location = new System.Drawing.Point(35, 245);
            this.CheckBoxPlayer2.Name = "CheckBoxPlayer2";
            this.CheckBoxPlayer2.Size = new System.Drawing.Size(121, 27);
            this.CheckBoxPlayer2.TabIndex = 8;
            this.CheckBoxPlayer2.Text = "Player 2:";
            this.CheckBoxPlayer2.UseVisualStyleBackColor = true;
            this.CheckBoxPlayer2.CheckedChanged += new System.EventHandler(this.CheckBoxPlayer2_CheckedChanged);
            // 
            // NameOfPlayer2TextBox
            // 
            this.NameOfPlayer2TextBox.Location = new System.Drawing.Point(182, 241);
            this.NameOfPlayer2TextBox.Name = "NameOfPlayer2TextBox";
            this.NameOfPlayer2TextBox.ShortcutsEnabled = false;
            this.NameOfPlayer2TextBox.Size = new System.Drawing.Size(369, 31);
            this.NameOfPlayer2TextBox.TabIndex = 9;
            this.NameOfPlayer2TextBox.Text = "[Computer]";
            this.NameOfPlayer2TextBox.TextChanged += new System.EventHandler(this.NameOfPlayer2_TextChanged);
            // 
            // ButtonOK
            // 
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonOK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonOK.Location = new System.Drawing.Point(471, 312);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(80, 64);
            this.ButtonOK.TabIndex = 10;
            this.ButtonOK.Text = "Done";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(279, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 40);
            this.label4.TabIndex = 12;
            this.label4.Text = "Let\'s Start! ";
            // 
            // GameSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(799, 428);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.NameOfPlayer2TextBox);
            this.Controls.Add(this.CheckBoxPlayer2);
            this.Controls.Add(this.NameOfPlayer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RadioButtonTen);
            this.Controls.Add(this.RadioButtonEight);
            this.Controls.Add(this.RadioButtonSix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSetting";
            this.Text = "Game Setting";
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton RadioButtonSix;
        private RadioButton RadioButtonEight;
        private RadioButton RadioButtonTen;
        private Label label2;
        private Label label3;
        private TextBox NameOfPlayer1;
        private CheckBox CheckBoxPlayer2;
        private TextBox NameOfPlayer2TextBox;
        private Button ButtonOK;
        private PictureBox pictureBox1;
        private Label label4;
    }
}