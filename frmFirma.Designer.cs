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
            this.nudGrosor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.gbDibujo = new System.Windows.Forms.GroupBox();
            this.pbDibujo = new System.Windows.Forms.PictureBox();
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.gbHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            this.gbDibujo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDibujo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHerramientas
            // 
            this.gbHerramientas.Controls.Add(this.nudGrosor);
            this.gbHerramientas.Controls.Add(this.label1);
            this.gbHerramientas.Controls.Add(this.cmdBorrar);
            this.gbHerramientas.Controls.Add(this.pbColor);
            this.gbHerramientas.Controls.Add(this.cmdGuardar);
            this.gbHerramientas.Location = new System.Drawing.Point(12, 12);
            this.gbHerramientas.Name = "gbHerramientas";
            this.gbHerramientas.Size = new System.Drawing.Size(142, 426);
            this.gbHerramientas.TabIndex = 0;
            this.gbHerramientas.TabStop = false;
            this.gbHerramientas.Text = "Herramientas";
            // 
            // nudGrosor
            // 
            this.nudGrosor.Location = new System.Drawing.Point(7, 160);
            this.nudGrosor.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudGrosor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrosor.Name = "nudGrosor";
            this.nudGrosor.Size = new System.Drawing.Size(120, 23);
            this.nudGrosor.TabIndex = 1;
            this.nudGrosor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar Color";
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(16, 368);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(109, 23);
            this.cmdBorrar.TabIndex = 2;
            this.cmdBorrar.Text = "Borrar Lienzo";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Black;
            this.pbColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbColor.Location = new System.Drawing.Point(7, 43);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(109, 53);
            this.pbColor.TabIndex = 1;
            this.pbColor.TabStop = false;
            this.pbColor.Click += new System.EventHandler(this.pbColor_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(16, 397);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(109, 23);
            this.cmdGuardar.TabIndex = 0;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
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
            this.pbDibujo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDibujo_MouseDown);
            this.pbDibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDibujo_MouseMove);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            this.gbDibujo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDibujo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbHerramientas;
        private GroupBox gbDibujo;
        private Button cmdGuardar;
        private PictureBox pbDibujo;
        private ColorDialog cdColor;
        private PictureBox pbColor;
        private Button cmdBorrar;
        private Label label1;
        private NumericUpDown nudGrosor;
    }
}