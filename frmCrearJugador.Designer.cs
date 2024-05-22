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
            this.label4 = new System.Windows.Forms.Label();
            this.txtAtaques = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbJugadores = new System.Windows.Forms.ListBox();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
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
            this.txtVida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAtaques_KeyPress);
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
            this.txtDano.Size = new System.Drawing.Size(73, 29);
            this.txtDano.TabIndex = 8;
            this.txtDano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAtaques_KeyPress);
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
            this.pbImagen.Location = new System.Drawing.Point(251, 64);
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
            this.label3.Location = new System.Drawing.Point(251, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "IMAGEN";
            // 
            // cmdAnt
            // 
            this.cmdAnt.Location = new System.Drawing.Point(301, 277);
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
            this.lblImagen.Location = new System.Drawing.Point(351, 284);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(35, 30);
            this.lblImagen.TabIndex = 12;
            this.lblImagen.Text = "10";
            // 
            // cmdSig
            // 
            this.cmdSig.Location = new System.Drawing.Point(392, 277);
            this.cmdSig.Name = "cmdSig";
            this.cmdSig.Size = new System.Drawing.Size(44, 44);
            this.cmdSig.TabIndex = 13;
            this.cmdSig.Text = ">";
            this.cmdSig.UseVisualStyleBackColor = true;
            this.cmdSig.Click += new System.EventHandler(this.cmdSig_Click);
            // 
            // cmdCrear
            // 
            this.cmdCrear.Enabled = false;
            this.cmdCrear.Location = new System.Drawing.Point(12, 367);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(115, 28);
            this.cmdCrear.TabIndex = 14;
            this.cmdCrear.Text = "CREAR";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(123, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "ATAQUES";
            // 
            // txtAtaques
            // 
            this.txtAtaques.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAtaques.Location = new System.Drawing.Point(123, 260);
            this.txtAtaques.Name = "txtAtaques";
            this.txtAtaques.Size = new System.Drawing.Size(73, 29);
            this.txtAtaques.TabIndex = 16;
            this.txtAtaques.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAtaques_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(534, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "CARGAR JUGADOR";
            // 
            // lbJugadores
            // 
            this.lbJugadores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbJugadores.FormattingEnabled = true;
            this.lbJugadores.ItemHeight = 21;
            this.lbJugadores.Location = new System.Drawing.Point(535, 65);
            this.lbJugadores.Name = "lbJugadores";
            this.lbJugadores.Size = new System.Drawing.Size(193, 214);
            this.lbJugadores.TabIndex = 18;
            this.lbJugadores.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbJugadores_MouseDoubleClick);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(12, 333);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(115, 28);
            this.cmdNuevo.TabIndex = 20;
            this.cmdNuevo.Text = "NUEVO";
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Enabled = false;
            this.cmdCargar.Location = new System.Drawing.Point(571, 367);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(115, 28);
            this.cmdCargar.TabIndex = 21;
            this.cmdCargar.Text = "CARGAR";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // frmCrearJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 407);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.lbJugadores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAtaques);
            this.Controls.Add(this.label4);
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
            this.Load += new System.EventHandler(this.frmCrearJugador_Load);
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
        private Label label4;
        private TextBox txtAtaques;
        private Label label5;
        private ListBox lbJugadores;
        private Button cmdNuevo;
        private Button cmdCargar;
    }
}