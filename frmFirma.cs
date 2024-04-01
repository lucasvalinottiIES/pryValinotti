using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryValinotti
{
    public partial class frmFirma : Form
    {
        Graphics lienzo;
        List<Point> puntos = new List<Point>();
        Bitmap bmpLienzo;
        public frmFirma()
        {
            InitializeComponent();
            bmpLienzo = new Bitmap(pbDibujo.Width, pbDibujo.Height);
            lienzo = Graphics.FromImage(bmpLienzo);
        }

        private void pbDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            decimal nudgrosor = nudGrosor.Value;
            float grosor = 3 + (float)nudgrosor;
            Pen pen = new Pen(pbColor.BackColor, grosor);
            if (e.Button == MouseButtons.Left) 
            {
                try
                {
                    // Agrego los puntos donde estuvo el mmouse para dibujar una linea
                    puntos.Add(e.Location);
                    if(puntos.Count > 2)
                    {
                        lienzo.DrawCurve(pen, puntos.ToArray(), 0.5f);
                    }
                    pbDibujo.Image = bmpLienzo;
                } catch (Exception ex) {  MessageBox.Show(ex.Message);}

                // El siguiente codigo esta por las dudas llegue a ser mas eficiente, pero no
                // lo es seguramente.
                //
                //if (puntos.Count > 2)
                //{
                //    int len = puntos.Count;
                //    List<Point> subpuntos = new List<Point>();
                //    subpuntos.Add(puntos[len - 1]);
                //    subpuntos.Add(puntos[len - 2]);

                //}
            }
            else
            {
                puntos.Clear();
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            // Convertir la imagen del PictureBox a un Bitmap
            //  Un Bitmap es una representación en memoria de una imagen,
            //  que incluye todos los píxeles de la imagen.
            Bitmap bmp = (Bitmap)pbDibujo.Image;

            // Crear un objeto SaveFileDialog
            SaveFileDialog sfd = new SaveFileDialog();

            // Que tipos de archivo quiero guardar
            sfd.Filter = "Imágenes (*.png)|*.png;";

            // Titulo del filedialog
            sfd.Title = "Guardar dibujo";

            // Mostrar el diálogo
            DialogResult result = sfd.ShowDialog();

            // Si el usuario seleccionó un archivo
            if (result == DialogResult.OK)
            {
                // Obtener el nombre del archivo
                string filename = sfd.FileName;

                // Guardar la imagen en formato PNG
                bmp.Save(filename, ImageFormat.Png);
                MessageBox.Show("Imagen guardada correctamente", "Guardar dibujo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Liberar la memoria utilizada por el Bitmap
            bmp.Dispose();

            // Vuelvo a crear el lienzo y el bitmap para que no de error de parameter Invalid.
            bmpLienzo = new Bitmap(pbDibujo.Width, pbDibujo.Height);
            lienzo = Graphics.FromImage(bmpLienzo);
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            lienzo.Clear(Color.White);
            pbDibujo.Image = null;
        }

        private void pbDibujo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pbDibujo.Cursor = Cursors.Cross;
                puntos.Add(e.Location);
            }
            //else if (e.Button == MouseButtons.Right)
            //{
            //    pbDibujo.Cursor = Cursors.Default;
            //    puntos.Clear();
            //}
        }

        private void pbColor_Click(object sender, EventArgs e)
        {
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                pbColor.BackColor = cdColor.Color;
            }
        }
    }
}
