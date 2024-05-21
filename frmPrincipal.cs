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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdFirma_Click(object sender, EventArgs e)
        {
            frmFirma frm = new frmFirma();
            frm.ShowDialog();
        }

        private void cmdGalaga_Click(object sender, EventArgs e)
        {
            frmPlayer frm = new frmPlayer();
            frm.ShowDialog();
        }

        private void cmdMonstruarioMySQL_Click(object sender, EventArgs e)
        {
            frmMonstruarioMySQL frm = new frmMonstruarioMySQL();
            frm.ShowDialog();
        }

        private void cmdMonstruarioAPI_Click(object sender, EventArgs e)
        {
            frmMonstruarioAPI frm = new frmMonstruarioAPI();
            frm.ShowDialog();
        }
    }
}
