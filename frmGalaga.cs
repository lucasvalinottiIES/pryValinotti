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

        // Variable para la creacion de enemigos.
        int enemyCount = 7; // Cantidad de enemigos
        int xPositionEnemy = 17; // Posicion inicial del primer enemigo
        int enemyVelocity = 1; // Velocidad inicial de los enemigos
        // Variable booleana para controlar que no se dispare antes de empezar a jugar
        bool canShoot = false;
        Random r = new Random();

        // Listas para controlar tanto enemigos como balas.
        List<PictureBox> enemies = new List<PictureBox>();
        List<PictureBox> bullets = new List<PictureBox>();
        public frmGalaga()
        {
            InitializeComponent();
            createEnemies();
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
                        enemies.Remove(enemy);
                        bullets.Remove(bullet);
                        return true;
                    }
                }
            }
            return false;
        }

        private bool checkEnemyCollision()
        {
            foreach (PictureBox enemy in enemies)
            {
                if(pbPlayer.Bounds.IntersectsWith(enemy.Bounds))
                {
                    enemy.Dispose();
                    enemies.Remove(enemy);
                    return true;
                }
            }
            return false;
        }

        public void restartGame()
        {
            enemyVelocity = 1;
            lblVelocity.Text = string.Format("{0:D2}", enemyVelocity);
            foreach (PictureBox enemy in enemies) enemy.Dispose();
            foreach (PictureBox bullet in bullets) bullet.Dispose();
            enemies.Clear();
            bullets.Clear();
            createEnemies();
        }

        public void createBullet()
        {
            if (canShoot)
            {
                PictureBox bullet = new PictureBox();
                bullet.Size = new Size(7, 15);
                bullet.SizeMode = PictureBoxSizeMode.StretchImage;
                bullet.Image = Image.FromFile($"./assets/Galaga/bullet.png");
                bullet.Location = new Point(pbPlayer.Location.X + pbPlayer.Size.Width / 2, pbPlayer.Location.Y + pbPlayer.Size.Height / 2);
                this.Controls.Add(bullet);
                xPositionEnemy += (bullet.Size.Width + 10);
                bullets.Add(bullet);
            }
        }

        public void createEnemies()
        {
            xPositionEnemy = 17;
            for (int i = 0; i < enemyCount; i++)
            {
                int nEnemy = r.Next(1, 4);
                PictureBox enemy = new PictureBox();
                enemy.Size = new Size(35, 35);
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
                pbPlayer.Location = new Point(pbPlayer.Location.X + 15, pbPlayer.Location.Y);
                if (pbPlayer.Location.X > screenWidth - pbPlayer.Size.Width)
                {
                    pbPlayer.Location = new Point(screenWidth - pbPlayer.Size.Width, pbPlayer.Location.Y);
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X - 15, pbPlayer.Location.Y);
                if (pbPlayer.Location.X < 0)
                {
                    pbPlayer.Location = new Point(0, pbPlayer.Location.Y);
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                createBullet();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                lblJugar.Visible = false;
                canShoot = true;
                clock.Start();
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox enemy in enemies)
            {
                enemy.Location = new Point(enemy.Location.X, enemy.Location.Y + enemyVelocity);
                if (enemy.Bounds.Bottom > screenHeight)
                {
                    canShoot = false;
                    clock.Stop();
                    DialogResult result = MessageBox.Show("Perdiste! Volver a jugar?", "Juego Terminado", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        restartGame();
                        lblJugar.Visible = true;
                        score = 0;
                        lblScore.Text = string.Format("{0:D2}", score);
                        break;
                    }
                    else
                    {
                        enemies.Clear();
                        this.Close();
                        break;
                    }
                }
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
                if (score > 0 && score % 10 == 0 && enemyVelocity < 10)
                {
                    enemyVelocity++;
                    lblVelocity.Text = string.Format("{0:D2}", enemyVelocity);
                }
                if (enemies.Count == 0) createEnemies();
            }
            if (checkEnemyCollision())
            {
                canShoot = false;
                clock.Stop();
                DialogResult result = MessageBox.Show("Perdiste! Volver a jugar?", "Juego Terminado", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    restartGame();
                    lblJugar.Visible = true;
                    score = 0;
                    lblScore.Text = string.Format("{0:D2}", score);
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
