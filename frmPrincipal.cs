﻿using System;
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
            frmGalaga frm = new frmGalaga();
            frm.ShowDialog();
        }
    }
}
