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
    public partial class frmMonstruarioMySQL : Form
    {
        public frmMonstruarioMySQL()
        {
            InitializeComponent();
        }
        clsMySQL BD = new clsMySQL();

        private void frmMonstruarioMySQL_Load(object sender, EventArgs e)
        {
            try
            {
                BD.listarTipos(tvTipos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tvTipos_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            BD.listarInfo(dgvDetalles, e.Node.Text);
            lblDatos.Text = "Datos detallados de: " + e.Node.Text;
            string indice = BD.buscarIndice(e.Node.Text);
            string url = "https://www.dnd5eapi.co/api/images/monsters/";
            pbImagen.ImageLocation = url + indice + ".png";
        }
    }
}
