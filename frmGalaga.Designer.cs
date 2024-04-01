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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGalaga));
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbEnemyOne = new System.Windows.Forms.PictureBox();
            this.pbEnemyTwo = new System.Windows.Forms.PictureBox();
            this.pbEnemyThree = new System.Windows.Forms.PictureBox();
            this.pbEnemyFour = new System.Windows.Forms.PictureBox();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.pbBullet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBullet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(118, 388);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(50, 50);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // pbEnemyOne
            // 
            this.pbEnemyOne.Image = ((System.Drawing.Image)(resources.GetObject("pbEnemyOne.Image")));
            this.pbEnemyOne.Location = new System.Drawing.Point(12, 12);
            this.pbEnemyOne.Name = "pbEnemyOne";
            this.pbEnemyOne.Size = new System.Drawing.Size(50, 50);
            this.pbEnemyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemyOne.TabIndex = 1;
            this.pbEnemyOne.TabStop = false;
            // 
            // pbEnemyTwo
            // 
            this.pbEnemyTwo.Image = ((System.Drawing.Image)(resources.GetObject("pbEnemyTwo.Image")));
            this.pbEnemyTwo.Location = new System.Drawing.Point(80, 12);
            this.pbEnemyTwo.Name = "pbEnemyTwo";
            this.pbEnemyTwo.Size = new System.Drawing.Size(50, 50);
            this.pbEnemyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemyTwo.TabIndex = 2;
            this.pbEnemyTwo.TabStop = false;
            // 
            // pbEnemyThree
            // 
            this.pbEnemyThree.Image = ((System.Drawing.Image)(resources.GetObject("pbEnemyThree.Image")));
            this.pbEnemyThree.Location = new System.Drawing.Point(153, 12);
            this.pbEnemyThree.Name = "pbEnemyThree";
            this.pbEnemyThree.Size = new System.Drawing.Size(50, 50);
            this.pbEnemyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemyThree.TabIndex = 3;
            this.pbEnemyThree.TabStop = false;
            // 
            // pbEnemyFour
            // 
            this.pbEnemyFour.Image = ((System.Drawing.Image)(resources.GetObject("pbEnemyFour.Image")));
            this.pbEnemyFour.Location = new System.Drawing.Point(225, 12);
            this.pbEnemyFour.Name = "pbEnemyFour";
            this.pbEnemyFour.Size = new System.Drawing.Size(50, 50);
            this.pbEnemyFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemyFour.TabIndex = 4;
            this.pbEnemyFour.TabStop = false;
            // 
            // clock
            // 
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // pbBullet
            // 
            this.pbBullet.Image = ((System.Drawing.Image)(resources.GetObject("pbBullet.Image")));
            this.pbBullet.Location = new System.Drawing.Point(134, 389);
            this.pbBullet.Name = "pbBullet";
            this.pbBullet.Size = new System.Drawing.Size(15, 27);
            this.pbBullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBullet.TabIndex = 5;
            this.pbBullet.TabStop = false;
            this.pbBullet.Visible = false;
            // 
            // frmGalaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.Controls.Add(this.pbEnemyFour);
            this.Controls.Add(this.pbEnemyThree);
            this.Controls.Add(this.pbEnemyTwo);
            this.Controls.Add(this.pbEnemyOne);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbBullet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGalaga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galaga muy Trucho";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGalaga_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBullet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbPlayer;
        private PictureBox pbEnemyOne;
        private PictureBox pbEnemyTwo;
        private PictureBox pbEnemyThree;
        private PictureBox pbEnemyFour;
        private System.Windows.Forms.Timer clock;
        private PictureBox pbBullet;
    }
}