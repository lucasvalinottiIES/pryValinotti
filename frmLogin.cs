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
    public partial class frmLogin : Form
    {
        string usuario = "lucasvalinotti";
        string contra = "lucas123";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdIniciarSesion_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == usuario && txtContra.Text == contra) 
            {
                frmPrincipal frm = new frmPrincipal();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
        }
    }
}
