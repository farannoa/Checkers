namespace Ex05.UI
{
    partial class Checkers
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
            this.PanelGame = new System.Windows.Forms.Panel();
            this.playerNameOne = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // PanelGame
            // 
            this.PanelGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelGame.Location = new System.Drawing.Point(0, 0);
            this.PanelGame.Name = "PanelGame";
            this.PanelGame.Size = new System.Drawing.Size(1198, 677);
            this.PanelGame.TabIndex = 0;
            this.PanelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // playerNameOne
            // 
            this.playerNameOne.AccessibleName = "namePlayerOne";
            this.playerNameOne.AutoSize = true;
            this.playerNameOne.BackColor = System.Drawing.Color.Transparent;
            this.playerNameOne.Dock = System.Windows.Forms.DockStyle.Top;
            this.playerNameOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playerNameOne.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerNameOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerNameOne.Location = new System.Drawing.Point(0, 0);
            this.playerNameOne.Name = "playerNameOne";
            this.playerNameOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playerNameOne.Size = new System.Drawing.Size(316, 44);
            this.playerNameOne.TabIndex = 1;
            this.playerNameOne.Text = "playerNameOne";
            this.playerNameOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Checkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1198, 677);
            this.Controls.Add(this.playerNameOne);
            this.Controls.Add(this.PanelGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Checkers";
            this.Text = ";";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelGame;
        private Label playerNameOne;
        private PrintDialog printDialog1;
    }
}