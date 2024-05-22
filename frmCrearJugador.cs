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
        List<clsPersonaje> jugadores = new List<clsPersonaje>();

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
            bool repetido = false;
            foreach (clsPersonaje jugador in jugadores)
            {
                if(txtNombre.Text.ToLower() == jugador.Nombre.ToLower())
                {
                    repetido = true;
                    break;
                }
            }
            if (repetido) MessageBox.Show("Ingrese otro nombre, ya existe ese jugador.");
            else
            {
                iniciarJuego(true);
            }
        }

        private void txtAtaques_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\t')
            {
                e.Handled = true;
            }
        }

        private void frmCrearJugador_Load(object sender, EventArgs e)
        {
            clsMySQL BD = new clsMySQL();
            jugadores = BD.listarJugadores();
            if (jugadores.Count > 0)
            {
                lbJugadores.DataSource = jugadores;
                lbJugadores.ValueMember = "Nombre";
            }
        }

        private void lbJugadores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clsPersonaje jugador = (clsPersonaje)lbJugadores.SelectedItem;
            txtNombre.Text = jugador.Nombre;
            txtVida.Text = jugador.Vida.ToString();
            urlImagen = $"./assets/JuegoRol/{jugador.Imagen}.png";
            pbImagen.ImageLocation = urlImagen;
            indiceImagen = int.Parse(jugador.Imagen);
            lblImagen.Text = indiceImagen.ToString();
            string[] ataque = jugador.Dano.Split("d");
            txtAtaques.Text = ataque[0];
            txtDano.Text = ataque[1];
            cmdCargar.Enabled = true;
            cmdCrear.Enabled = false;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            cmdCargar.Enabled = false;
            cmdCrear.Enabled = true;
            txtNombre.Text = "";
            txtVida.Text = "";
            indiceImagen = 1;
            urlImagen = $"./assets/JuegoRol/{indiceImagen}.png";
            pbImagen.ImageLocation = urlImagen;
            lblImagen.Text = indiceImagen.ToString();
            txtAtaques.Text = "";
            txtDano.Text = "";
        }

        private void iniciarJuego(bool nuevo)
        {
            if (nuevo)
            {
                clsMySQL BD = new clsMySQL();
                if (txtNombre.Text != String.Empty) personaje.Nombre = txtNombre.Text;
                if (txtVida.Text != String.Empty) personaje.Vida = int.Parse(txtVida.Text);
                if (txtDano.Text != String.Empty) personaje.Dano = txtAtaques.Text + "d" + txtDano.Text;
                personaje.Imagen = indiceImagen.ToString();
                BD.guardarJugador(personaje);
            }
            else
            {
                personaje = (clsPersonaje)lbJugadores.SelectedItem;
            }
            frmJuegoRol frm = new frmJuegoRol(personaje);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            iniciarJuego(false);
        }
    }
}
