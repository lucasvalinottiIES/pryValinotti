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
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            InitializeComponent();
        }

        private void cmdPlay_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                this.Hide();
                frmGalaga frm = new frmGalaga(txtName.Text);
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
