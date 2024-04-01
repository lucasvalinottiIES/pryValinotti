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
        bool canMove = true;
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
            if (e.KeyCode == Keys.Right && canMove)
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X + 10, pbPlayer.Location.Y);
                pbBullet.Location = new Point(pbPlayer.Location.X + 12, pbPlayer.Location.Y);
                if (pbPlayer.Location.X > screenWidth - pbPlayer.Size.Width)
                {
                    pbPlayer.Location = new Point(screenWidth - pbPlayer.Size.Width, pbPlayer.Location.Y);
                    pbBullet.Location = new Point(pbPlayer.Location.X + 12, pbPlayer.Location.Y);
                }
            }
            else if (e.KeyCode == Keys.Left && canMove)
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
                pbBullet.Location = new Point(pbPlayer.Location.X + 12, pbPlayer.Location.Y);
                pbBullet.Visible= true;
                canMove= false;
                clock.Start();
            }else if(e.KeyCode == Keys.R)
            {
                restartGame();
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            pbBullet.Location = new Point(pbBullet.Location.X, pbBullet.Location.Y - 10);
            if (checkCollision())
            {
                pbBullet.Visible = false;
                canMove = true;
                clock.Stop();
            }
            if(pbBullet.Location.Y + pbBullet.Size.Height < 0) 
            {
                pbBullet.Visible = false;
                canMove = true;
                clock.Stop();
            }
        }

        private bool checkCollision()
        {
            foreach (PictureBox enemy in enemies)
            {
                if (pbBullet.Location.Y + 2 > enemy.Location.Y && pbBullet.Location.Y + 2 < enemy.Location.Y + enemy.Size.Height)
                {
                    if (pbBullet.Location.X > enemy.Location.X && pbBullet.Location.X < enemy.Location.X + enemy.Size.Width)
                    {
                        enemy.Visible = false;
                        if (checkWin())
                        {
                            clock.Stop();
                            DialogResult result = MessageBox.Show("GANASTE!\n¿Volver a jugar?", "EL PEOR JUEGO DE LA HISTORIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes) restartGame();
                            else this.Close();
                        }
                        return true;
                    }
                }
            }
            return false;
        }

        private bool checkWin()
        {
            bool win = true;
            foreach (PictureBox enemy in enemies)
            {
                if(enemy.Visible == true) return false;
            }
            return true;
        }

        public void restartGame()
        {
            foreach (PictureBox enemy in enemies)
            {
                enemy.Visible = true;
            }
        }
    }
}
