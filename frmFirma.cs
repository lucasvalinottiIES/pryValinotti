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
        Graphics lienzo;
        bool puedeDibujar = false;
        public frmFirma()
        {
            InitializeComponent();
            lienzo = pbDibujo.CreateGraphics();
        }

        private void cmdColor_Click(object sender, EventArgs e)
        {
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                pbColor.BackColor = cdColor.Color;
            }
        }

        private void pbDibujo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) puedeDibujar = true;
            else if (e.Button == MouseButtons.Right) puedeDibujar = false;
        }

        private void pbDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            Brush brush = new SolidBrush(pbColor.BackColor);
            int grosor = Convert.ToInt32(nudGrosor.Value);
            if (puedeDibujar) lienzo.FillEllipse(brush, e.X, e.Y, grosor, grosor);
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if(sfGuardarFirma.ShowDialog() == DialogResult.OK)
            {
                return;
            }
        }
    }
}
