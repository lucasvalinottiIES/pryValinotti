namespace pryValinotti
{
    partial class frmFirma
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
            this.gbHerramientas = new System.Windows.Forms.GroupBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.nudGrosor = new System.Windows.Forms.NumericUpDown();
            this.lblGrosor = new System.Windows.Forms.Label();
            this.cmdColor = new System.Windows.Forms.Button();
            this.gbDibujo = new System.Windows.Forms.GroupBox();
            this.pbDibujo = new System.Windows.Forms.PictureBox();
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.gbHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosor)).BeginInit();
            this.gbDibujo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDibujo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHerramientas
            // 
            this.gbHerramientas.Controls.Add(this.pbColor);
            this.gbHerramientas.Controls.Add(this.cmdGuardar);
            this.gbHerramientas.Controls.Add(this.nudGrosor);
            this.gbHerramientas.Controls.Add(this.lblGrosor);
            this.gbHerramientas.Controls.Add(this.cmdColor);
            this.gbHerramientas.Location = new System.Drawing.Point(12, 12);
            this.gbHerramientas.Name = "gbHerramientas";
            this.gbHerramientas.Size = new System.Drawing.Size(142, 426);
            this.gbHerramientas.TabIndex = 0;
            this.gbHerramientas.TabStop = false;
            this.gbHerramientas.Text = "Herramientas";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(16, 397);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(109, 23);
            this.cmdGuardar.TabIndex = 0;
            this.cmdGuardar.Text = "Guardar Dibujo";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // nudGrosor
            // 
            this.nudGrosor.Location = new System.Drawing.Point(16, 170);
            this.nudGrosor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGrosor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrosor.Name = "nudGrosor";
            this.nudGrosor.Size = new System.Drawing.Size(109, 23);
            this.nudGrosor.TabIndex = 0;
            this.nudGrosor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGrosor
            // 
            this.lblGrosor.AutoSize = true;
            this.lblGrosor.Location = new System.Drawing.Point(16, 152);
            this.lblGrosor.Name = "lblGrosor";
            this.lblGrosor.Size = new System.Drawing.Size(79, 15);
            this.lblGrosor.TabIndex = 0;
            this.lblGrosor.Text = "Grosor (1-10):";
            // 
            // cmdColor
            // 
            this.cmdColor.Location = new System.Drawing.Point(16, 39);
            this.cmdColor.Name = "cmdColor";
            this.cmdColor.Size = new System.Drawing.Size(109, 23);
            this.cmdColor.TabIndex = 0;
            this.cmdColor.Text = "Seleccionar Color";
            this.cmdColor.UseVisualStyleBackColor = true;
            this.cmdColor.Click += new System.EventHandler(this.cmdColor_Click);
            // 
            // gbDibujo
            // 
            this.gbDibujo.Controls.Add(this.pbDibujo);
            this.gbDibujo.Location = new System.Drawing.Point(160, 12);
            this.gbDibujo.Name = "gbDibujo";
            this.gbDibujo.Size = new System.Drawing.Size(628, 426);
            this.gbDibujo.TabIndex = 1;
            this.gbDibujo.TabStop = false;
            this.gbDibujo.Text = "Dibujo";
            // 
            // pbDibujo
            // 
            this.pbDibujo.BackColor = System.Drawing.Color.White;
            this.pbDibujo.Location = new System.Drawing.Point(6, 22);
            this.pbDibujo.Name = "pbDibujo";
            this.pbDibujo.Size = new System.Drawing.Size(616, 398);
            this.pbDibujo.TabIndex = 0;
            this.pbDibujo.TabStop = false;
            // 
            // cdColor
            // 
            this.cdColor.FullOpen = true;
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Black;
            this.pbColor.Location = new System.Drawing.Point(16, 68);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(109, 53);
            this.pbColor.TabIndex = 1;
            this.pbColor.TabStop = false;
            // 
            // frmFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDibujo);
            this.Controls.Add(this.gbHerramientas);
            this.Name = "frmFirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma";
            this.gbHerramientas.ResumeLayout(false);
            this.gbHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosor)).EndInit();
            this.gbDibujo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDibujo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbHerramientas;
        private NumericUpDown nudGrosor;
        private Label lblGrosor;
        private Button cmdColor;
        private GroupBox gbDibujo;
        private Button cmdGuardar;
        private PictureBox pbDibujo;
        private ColorDialog cdColor;
        private PictureBox pbColor;
    }
}