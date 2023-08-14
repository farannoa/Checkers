namespace Ex05.UI
{
    partial class TieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItsATieName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BennetPicureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BennetPicureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ItsATieName
            // 
            this.ItsATieName.AutoSize = true;
            this.ItsATieName.Font = new System.Drawing.Font("Showcard Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItsATieName.Location = new System.Drawing.Point(119, 94);
            this.ItsATieName.Name = "ItsATieName";
            this.ItsATieName.Size = new System.Drawing.Size(493, 98);
            this.ItsATieName.TabIndex = 0;
            this.ItsATieName.Text = "I\'ts a Tie!!!";
            this.ItsATieName.Click += new System.EventHandler(this.ItsATieName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Would You Like To Play Another Game?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 300;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(404, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 110);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 300;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(79, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 110);
            this.button2.TabIndex = 3;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BennetPicureBox
            // 
            this.BennetPicureBox.BackColor = System.Drawing.Color.Transparent;
            this.BennetPicureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BennetPicureBox.Image = global::Ex05.UI.Properties.Resources.pictureBennet_png;
            this.BennetPicureBox.Location = new System.Drawing.Point(603, 30);
            this.BennetPicureBox.Name = "BennetPicureBox";
            this.BennetPicureBox.Size = new System.Drawing.Size(150, 180);
            this.BennetPicureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BennetPicureBox.TabIndex = 4;
            this.BennetPicureBox.TabStop = false;
            this.BennetPicureBox.Click += new System.EventHandler(this.BennetPicureBox_Click);
            // 
            // TieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BennetPicureBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItsATieName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TieForm";
            this.Text = "TieForm";
            this.Load += new System.EventHandler(this.TieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BennetPicureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ItsATieName;
        private Label label1;
        private Button button1;
        private Button button2;
        private PictureBox BennetPicureBox;
    }
}