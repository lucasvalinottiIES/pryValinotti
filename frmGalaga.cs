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
    public partial class frmGalaga : Form
    {
        int screenWidth = 303;
        int screenHeight = 489;
        List<PictureBox> enemies = new List<PictureBox>();
        public frmGalaga()
        {
            InitializeComponent();
            enemies.Add(pbEnemyOne);
            enemies.Add(pbEnemyTwo);
            enemies.Add(pbEnemyThree);
            enemies.Add(pbEnemyFour);
        }

        private void frmGalaga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X + 10, pbPlayer.Location.Y);
                pbBullet.Location = new Point(pbPlayer.Location.X + 12, pbPlayer.Location.Y);
                if (pbPlayer.Location.X > screenWidth - pbPlayer.Size.Width)
                {
                    pbPlayer.Location = new Point(screenWidth - pbPlayer.Size.Width, pbPlayer.Location.Y);
                    pbBullet.Location = new Point(pbPlayer.Location.X + 12, pbPlayer.Location.Y);
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X - 10, pbPlayer.Location.Y);
                pbBullet.Location = new Point(pbPlayer.Location.X + 12, pbBullet.Location.Y);
                if (pbPlayer.Location.X < 0)
                {
                    pbPlayer.Location = new Point(0, pbPlayer.Location.Y); 
                    pbBullet.Location = new Point(pbPlayer.Location.X + 12, pbPlayer.Location.Y);
                }
            }else if(e.KeyCode== Keys.Space)
            {
                clock.Start();
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {

        }
    }
}
