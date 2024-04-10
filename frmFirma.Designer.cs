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
            gbHerramientas = new GroupBox();
            nudGrosor = new NumericUpDown();
            label1 = new Label();
            cmdBorrar = new Button();
            pbColor = new PictureBox();
            cmdGuardar = new Button();
            gbDibujo = new GroupBox();
            pbDibujo = new PictureBox();
            cdColor = new ColorDialog();
            gbHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGrosor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbColor).BeginInit();
            gbDibujo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDibujo).BeginInit();
            SuspendLayout();
            // 
            // gbHerramientas
            // 
            gbHerramientas.Controls.Add(nudGrosor);
            gbHerramientas.Controls.Add(label1);
            gbHerramientas.Controls.Add(cmdBorrar);
            gbHerramientas.Controls.Add(pbColor);
            gbHerramientas.Controls.Add(cmdGuardar);
            gbHerramientas.Location = new Point(12, 12);
            gbHerramientas.Name = "gbHerramientas";
            gbHerramientas.Size = new Size(142, 426);
            gbHerramientas.TabIndex = 0;
            gbHerramientas.TabStop = false;
            gbHerramientas.Text = "Herramientas";
            // 
            // nudGrosor
            // 
            nudGrosor.Location = new Point(7, 160);
            nudGrosor.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudGrosor.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudGrosor.Name = "nudGrosor";
            nudGrosor.Size = new Size(120, 23);
            nudGrosor.TabIndex = 1;
            nudGrosor.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleccionar Color";
            // 
            // cmdBorrar
            // 
            cmdBorrar.Location = new Point(16, 368);
            cmdBorrar.Name = "cmdBorrar";
            cmdBorrar.Size = new Size(109, 23);
            cmdBorrar.TabIndex = 2;
            cmdBorrar.Text = "Borrar Lienzo";
            cmdBorrar.UseVisualStyleBackColor = true;
            cmdBorrar.Click += cmdBorrar_Click;
            // 
            // pbColor
            // 
            pbColor.BackColor = Color.Black;
            pbColor.Cursor = Cursors.Hand;
            pbColor.Location = new Point(7, 43);
            pbColor.Name = "pbColor";
            pbColor.Size = new Size(109, 53);
            pbColor.TabIndex = 1;
            pbColor.TabStop = false;
            pbColor.Click += pbColor_Click;
            // 
            // cmdGuardar
            // 
            cmdGuardar.Location = new Point(16, 397);
            cmdGuardar.Name = "cmdGuardar";
            cmdGuardar.Size = new Size(109, 23);
            cmdGuardar.TabIndex = 0;
            cmdGuardar.Text = "Guardar";
            cmdGuardar.UseVisualStyleBackColor = true;
            cmdGuardar.Click += cmdGuardar_Click;
            // 
            // gbDibujo
            // 
            gbDibujo.Controls.Add(pbDibujo);
            gbDibujo.Location = new Point(160, 12);
            gbDibujo.Name = "gbDibujo";
            gbDibujo.Size = new Size(628, 426);
            gbDibujo.TabIndex = 1;
            gbDibujo.TabStop = false;
            gbDibujo.Text = "Dibujo";
            // 
            // pbDibujo
            // 
            pbDibujo.BackColor = Color.White;
            pbDibujo.Cursor = Cursors.Cross;
            pbDibujo.Location = new Point(6, 22);
            pbDibujo.Name = "pbDibujo";
            pbDibujo.Size = new Size(616, 398);
            pbDibujo.TabIndex = 0;
            pbDibujo.TabStop = false;
            pbDibujo.MouseDown += pbDibujo_MouseDown;
            pbDibujo.MouseMove += pbDibujo_MouseMove;
            // 
            // frmFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(gbDibujo);
            Controls.Add(gbHerramientas);
            Name = "frmFirma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Firma";
            gbHerramientas.ResumeLayout(false);
            gbHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGrosor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbColor).EndInit();
            gbDibujo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbDibujo).EndInit();
            ResumeLayout(false);
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