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
    public partial class frmFirma : Form
    {
        public frmFirma()
        {
            InitializeComponent();
        }

        private void cmdColor_Click(object sender, EventArgs e)
        {
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se selecciono un color");
            }
            else
            {
                MessageBox.Show("No se selecciono nada");
            }

        }
    }
}
