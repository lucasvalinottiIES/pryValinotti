using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryValinotti
{
    public partial class frmCrearJugador : Form
    {
        private int indiceImagen = 1;
        private string nombreJugador = "SIN NOMBRE";
        private int vida = 0;
        private string dano = "0d0";
        private string urlImagen = "";
        private clsPersonaje personaje = new clsPersonaje();

        public frmCrearJugador()
        {
            InitializeComponent();
            lblImagen.Text = indiceImagen.ToString();
            pbImagen.ImageLocation = $"./assets/JuegoRol/{indiceImagen}.png";
            urlImagen = $"./assets/JuegoRol/{indiceImagen}.png";
            personaje.Nombre = nombreJugador;
            personaje.Vida = vida;
            personaje.Dano = dano;
            personaje.Imagen = urlImagen;
        }

        private void cmdSig_Click(object sender, EventArgs e)
        {
            indiceImagen++;
            if (indiceImagen > 10) indiceImagen = 1;
            lblImagen.Text = indiceImagen.ToString();
            pbImagen.ImageLocation = $"./assets/JuegoRol/{indiceImagen}.png";
            urlImagen = $"./assets/JuegoRol/{indiceImagen}.png";
        }

        private void cmdAnt_Click(object sender, EventArgs e)
        {
            indiceImagen--;
            if (indiceImagen < 1) indiceImagen = 10;
            lblImagen.Text = indiceImagen.ToString();
            pbImagen.ImageLocation = $"./assets/JuegoRol/{indiceImagen}.png";
            urlImagen = $"./assets/JuegoRol/{indiceImagen}.png";
        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != String.Empty) personaje.Nombre = txtNombre.Text;
            if (txtVida.Text != String.Empty) personaje.Vida = int.Parse(txtVida.Text);
            if (txtDano.Text != String.Empty) personaje.Dano = txtDano.Text;
            personaje.Imagen = urlImagen;
            frmJuegoRol frm = new frmJuegoRol(personaje);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
