namespace pryValinotti
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.marzoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdFirma = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdGalaga = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marzoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // marzoToolStripMenuItem
            // 
            this.marzoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdFirma,
            this.cmdGalaga});
            this.marzoToolStripMenuItem.Name = "marzoToolStripMenuItem";
            this.marzoToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.marzoToolStripMenuItem.Text = "Marzo";
            // 
            // cmdFirma
            // 
            this.cmdFirma.Name = "cmdFirma";
            this.cmdFirma.Size = new System.Drawing.Size(180, 22);
            this.cmdFirma.Text = "Firma";
            this.cmdFirma.Click += new System.EventHandler(this.cmdFirma_Click);
            // 
            // cmdGalaga
            // 
            this.cmdGalaga.Name = "cmdGalaga";
            this.cmdGalaga.Size = new System.Drawing.Size(180, 22);
            this.cmdGalaga.Text = "Galaga";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucas Valinotti";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem marzoToolStripMenuItem;
        private ToolStripMenuItem cmdFirma;
        private ToolStripMenuItem cmdGalaga;
    }
}