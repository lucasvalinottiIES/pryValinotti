namespace pryValinotti
{
    partial class frmGalaga
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGalaga));
            pbPlayer = new PictureBox();
            clock = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            lblScore = new Label();
            lblJugar = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPlayer).BeginInit();
            SuspendLayout();
            // 
            // pbPlayer
            // 
            pbPlayer.Image = (Image)resources.GetObject("pbPlayer.Image");
            pbPlayer.Location = new Point(153, 470);
            pbPlayer.Name = "pbPlayer";
            pbPlayer.Size = new Size(50, 50);
            pbPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPlayer.TabIndex = 0;
            pbPlayer.TabStop = false;
            // 
            // clock
            // 
            clock.Interval = 25;
            clock.Tick += clock_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(29, 19);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 6;
            label1.Text = "SCORE: ";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.ForeColor = Color.Yellow;
            lblScore.Location = new Point(84, 19);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(19, 15);
            lblScore.TabIndex = 7;
            lblScore.Text = "00";
            // 
            // lblJugar
            // 
            lblJugar.AutoSize = true;
            lblJugar.ForeColor = Color.Yellow;
            lblJugar.Location = new Point(95, 184);
            lblJugar.Name = "lblJugar";
            lblJugar.Size = new Size(149, 15);
            lblJugar.TabIndex = 8;
            lblJugar.Text = "Presionar ENTER para jugar";
            // 
            // frmGalaga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(340, 532);
            Controls.Add(lblJugar);
            Controls.Add(lblScore);
            Controls.Add(label1);
            Controls.Add(pbPlayer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmGalaga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Galaga muy Trucho";
            KeyDown += frmGalaga_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPlayer;
        private System.Windows.Forms.Timer clock;
        private Label label1;
        private Label lblScore;
        private Label lblJugar;
    }
}