namespace pryValinotti
{
    partial class frmMonstruarioMySQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonstruarioMySQL));
            this.tvTipos = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTamano = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblInteligencia = new System.Windows.Forms.Label();
            this.lblDano = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // tvTipos
            // 
            this.tvTipos.Location = new System.Drawing.Point(12, 48);
            this.tvTipos.Name = "tvTipos";
            this.tvTipos.Size = new System.Drawing.Size(319, 390);
            this.tvTipos.TabIndex = 0;
            this.tvTipos.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvTipos_NodeMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipos";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatos.Location = new System.Drawing.Point(337, 9);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(211, 25);
            this.lblDatos.TabIndex = 2;
            this.lblDatos.Text = "Datos detallados de: ---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(337, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imagen:";
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(337, 180);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(567, 235);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 5;
            this.pbImagen.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(552, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "* La carga puede demorar. Algunos monstruos no tienen imagen.";
            // 
            // lblTamano
            // 
            this.lblTamano.AutoSize = true;
            this.lblTamano.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTamano.Location = new System.Drawing.Point(377, 48);
            this.lblTamano.Name = "lblTamano";
            this.lblTamano.Size = new System.Drawing.Size(71, 21);
            this.lblTamano.TabIndex = 7;
            this.lblTamano.Text = "Tamaño: ";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(377, 83);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(47, 21);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo: ";
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFuerza.Location = new System.Drawing.Point(377, 118);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(63, 21);
            this.lblFuerza.TabIndex = 9;
            this.lblFuerza.Text = "Fuerza: ";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExp.Location = new System.Drawing.Point(559, 83);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(95, 21);
            this.lblExp.TabIndex = 11;
            this.lblExp.Text = "Experiencia: ";
            // 
            // lblInteligencia
            // 
            this.lblInteligencia.AutoSize = true;
            this.lblInteligencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInteligencia.Location = new System.Drawing.Point(559, 48);
            this.lblInteligencia.Name = "lblInteligencia";
            this.lblInteligencia.Size = new System.Drawing.Size(96, 21);
            this.lblInteligencia.TabIndex = 10;
            this.lblInteligencia.Text = "Inteligencia: ";
            // 
            // lblDano
            // 
            this.lblDano.AutoSize = true;
            this.lblDano.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDano.Location = new System.Drawing.Point(559, 118);
            this.lblDano.Name = "lblDano";
            this.lblDano.Size = new System.Drawing.Size(54, 21);
            this.lblDano.TabIndex = 12;
            this.lblDano.Text = "Daño: ";
            // 
            // frmMonstruarioMySQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.lblDano);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblInteligencia);
            this.Controls.Add(this.lblFuerza);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTamano);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvTipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMonstruarioMySQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monstruario My SQL";
            this.Load += new System.EventHandler(this.frmMonstruarioMySQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView tvTipos;
        private Label label1;
        private Label lblDatos;
        private Label label3;
        private PictureBox pbImagen;
        private Label label4;
        private Label lblTamano;
        private Label lblTipo;
        private Label lblFuerza;
        private Label lblExp;
        private Label lblInteligencia;
        private Label lblDano;
    }
}