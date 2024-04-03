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
        int score = 0;
        int screenWidth = 356;
        int screenHeight = 571;
        int enemyCount = 5;
        int xPositionEnemy = 17;
        bool canMove = true;
        Random r = new Random();
        List<PictureBox> enemies = new List<PictureBox>();
        List<PictureBox> bullets = new List<PictureBox>();
        public frmGalaga()
        {
            InitializeComponent();
            for (int i = 0; i < enemyCount; i++)
            {
                int nEnemy = r.Next(1, 4);
                PictureBox enemy = new PictureBox();
                enemy.Size = new Size(50, 50);
                enemy.SizeMode = PictureBoxSizeMode.StretchImage;
                enemy.Image = Image.FromFile($"./assets/Galaga/enemy{nEnemy}.png");
                enemy.Location = new Point(xPositionEnemy, 50);
                this.Controls.Add(enemy);
                xPositionEnemy += (enemy.Size.Width + 10);
                enemies.Add(enemy);
            }
        }

        private void frmGalaga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X + 10, pbPlayer.Location.Y);
                if (pbPlayer.Location.X > screenWidth - pbPlayer.Size.Width)
                {
                    pbPlayer.Location = new Point(screenWidth - pbPlayer.Size.Width, pbPlayer.Location.Y);
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X - 10, pbPlayer.Location.Y);
                if (pbPlayer.Location.X < 0)
                {
                    pbPlayer.Location = new Point(0, pbPlayer.Location.Y);
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                createBullet();
                canMove = false;

            }
            else if (e.KeyCode == Keys.R)
            {
                restartGame();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                lblJugar.Visible = false;
                clock.Start();
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox enemy in enemies)
            {
                int velocity = r.Next(1, 3);
                enemy.Location = new Point(enemy.Location.X, enemy.Location.Y + velocity);
            }
            foreach (PictureBox bullet in bullets)
            {
                bullet.Location = new Point(bullet.Location.X, bullet.Location.Y - 5);
                if (bullet.Location.Y < 0) bullet.Dispose();
            }
            if (checkBulletCollision())
            {
                score++;
                lblScore.Text = string.Format("{0:D2}", score);
            }

        }

        private bool checkBulletCollision()
        {
            foreach (PictureBox enemy in enemies)
            {
                foreach (PictureBox bullet in bullets)
                {
                    // Comprobación de rectángulos superpuestos (ajustados para el tamaño de la bala)
                    if (bullet.Bounds.IntersectsWith(enemy.Bounds))
                    {
                        enemy.Dispose();
                        bullet.Dispose();
                        MessageBox.Show($"Cantidad de enemigos: {enemies.Count}");
                        return true;
                    }
                }
            }
            return false;
        }

        private bool checkWin()
        {
            foreach (PictureBox enemy in enemies)
            {
                if (enemy.Visible == true) return false;
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

        public void createBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.Size = new Size(15, 27);
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.Image = Image.FromFile($"./assets/Galaga/bullet.png");
            bullet.Location = new Point(pbPlayer.Location.X + pbPlayer.Size.Width / 2, pbPlayer.Location.Y + pbPlayer.Size.Height / 2);
            this.Controls.Add(bullet);
            xPositionEnemy += (bullet.Size.Width + 10);
            bullets.Add(bullet);
        }
    }
}
