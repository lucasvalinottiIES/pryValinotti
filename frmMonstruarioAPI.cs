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
    public partial class frmMonstruarioAPI : Form
    {
        public frmMonstruarioAPI()
        {
            InitializeComponent();
        }

        clsMySQL BD = new clsMySQL();
        clsAPI API = new clsAPI();
        private void frmMonstruarioAPI_Load(object sender, EventArgs e)
        {
            BD.listarTipos(tvTipos);
        }

        private void tvTipos_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string nombreFormateado = formatearNombre(e.Node.Text);
            API.getData(nombreFormateado, txtJson);
        }

        private string formatearNombre(string nombre) 
        {
            nombre = nombre.ToLower();
            string[] subNombres = nombre.Split(" ");
            string nombreFormateado = "";
            foreach (string subNombre in subNombres)
            {
                nombreFormateado += subNombre + "-";
            }
            nombreFormateado = nombreFormateado.TrimEnd('-');
            return nombreFormateado;
        }
    }
}
