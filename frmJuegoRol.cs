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
    public partial class frmJuegoRol : Form
    {
        private clsPersonaje jugador;
        private clsPersonaje enemigo = new clsPersonaje();
        public frmJuegoRol(clsPersonaje personaje)
        {
            InitializeComponent();
            jugador = personaje;
            pbJugador.ImageLocation = $"./assets/JuegoRol/{jugador.Imagen}.png";
            lblJugador.Text = "NOMBRE: " + jugador.Nombre;
            lblDano.Text = "DAÑO: " + jugador.Dano;
            lblVida.Text = "VIDA: " + jugador.Vida.ToString();
            enemigo = enemigo.crearEnemigo();
            pbEnemigo.ImageLocation = enemigo.Imagen;
            lblEnemigo.Text = "NOMBRE: \n" + enemigo.Nombre;
            lblDanoE.Text = "DAÑO: " + enemigo.Dano;
            lblVidaE.Text = "VIDA: " + enemigo.Vida.ToString();
        }
    }
}
