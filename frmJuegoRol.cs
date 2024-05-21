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
            pbJugador.ImageLocation = jugador.Imagen;
            lblJugador.Text = jugador.Nombre;
            lblDano.Text = jugador.Dano;
            lblVida.Text = jugador.Vida.ToString();
            enemigo = enemigo.crearEnemigo();
            pbEnemigo.ImageLocation = enemigo.Imagen;
            lblEnemigo.Text = enemigo.Nombre;
            lblDanoE.Text = enemigo.Dano;
            lblVidaE.Text = enemigo.Vida.ToString();
        }
    }
}
