namespace pryValinotti
{
    partial class frmCrearJugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearJugador));
            this.lblJugador = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtVida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdAnt = new System.Windows.Forms.Button();
            this.lblImagen = new System.Windows.Forms.Label();
            this.cmdSig = new System.Windows.Forms.Button();
            this.cmdCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJugador.Location = new System.Drawing.Point(12, 22);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(107, 30);
            this.lblJugador.TabIndex = 3;
            this.lblJugador.Text = "JUGADOR";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(12, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 29);
            this.txtNombre.TabIndex = 4;
            // 
            // txtVida
            // 
            this.txtVida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVida.Location = new System.Drawing.Point(12, 159);
            this.txtVida.Name = "txtVida";
            this.txtVida.Size = new System.Drawing.Size(212, 29);
            this.txtVida.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "VIDA";
            // 
            // txtDano
            // 
            this.txtDano.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDano.Location = new System.Drawing.Point(12, 260);
            this.txtDano.Name = "txtDano";
            this.txtDano.Size = new System.Drawing.Size(212, 29);
            this.txtDano.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "DAÑO";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(335, 64);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(228, 207);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 9;
            this.pbImagen.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(335, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "IMAGEN";
            // 
            // cmdAnt
            // 
            this.cmdAnt.Location = new System.Drawing.Point(385, 277);
            this.cmdAnt.Name = "cmdAnt";
            this.cmdAnt.Size = new System.Drawing.Size(44, 44);
            this.cmdAnt.TabIndex = 11;
            this.cmdAnt.Text = "<";
            this.cmdAnt.UseVisualStyleBackColor = true;
            this.cmdAnt.Click += new System.EventHandler(this.cmdAnt_Click);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImagen.Location = new System.Drawing.Point(435, 284);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(35, 30);
            this.lblImagen.TabIndex = 12;
            this.lblImagen.Text = "10";
            // 
            // cmdSig
            // 
            this.cmdSig.Location = new System.Drawing.Point(476, 277);
            this.cmdSig.Name = "cmdSig";
            this.cmdSig.Size = new System.Drawing.Size(44, 44);
            this.cmdSig.TabIndex = 13;
            this.cmdSig.Text = ">";
            this.cmdSig.UseVisualStyleBackColor = true;
            this.cmdSig.Click += new System.EventHandler(this.cmdSig_Click);
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(193, 346);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(182, 52);
            this.cmdCrear.TabIndex = 14;
            this.cmdCrear.Text = "CREAR";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // frmCrearJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 407);
            this.Controls.Add(this.cmdCrear);
            this.Controls.Add(this.cmdSig);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.cmdAnt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.txtDano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblJugador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCrearJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Jugador";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblJugador;
        private TextBox txtNombre;
        private TextBox txtVida;
        private Label label1;
        private TextBox txtDano;
        private Label label2;
        private PictureBox pbImagen;
        private Label label3;
        private Button cmdAnt;
        private Label lblImagen;
        private Button cmdSig;
        private Button cmdCrear;
    }
}