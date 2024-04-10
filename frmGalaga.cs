using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryValinotti
{
    public partial class frmGalaga : Form
    {

        int score = 0;

        clsPlayer player = new clsPlayer(new Point(153, 383));
        bool playing = false;
        bool canMove = false;
        bool canShoot = false;
        // Variable para la creacion de enemigos.
        int xPositionEnemy = 17; // Posicion inicial del primer enemigo
        int side = 1;
        // Variable booleana para controlar que no se dispare antes de empezar a jugar
        Random r = new Random();

        // Listas para controlar tanto enemigos como balas.
        List<clsEnemy> enemies = new List<clsEnemy>();
        List<clsBullet> bullets = new List<clsBullet>();
        List<clsBullet> ebullets = new List<clsBullet>();

        public frmGalaga(string playerName)
        {
            InitializeComponent();
            createEnemies();
            this.Text += $" - {playerName}";
        }

        private bool checkBulletCollision()
        {
            foreach (clsEnemy enemy in enemies)
            {
                foreach (clsBullet bullet in bullets)
                {
                    // Comprobación de rectángulos superpuestos (ajustados para el tamaño de la bala)
                    if (bullet.pbBullet.Bounds.IntersectsWith(enemy.pbEnemy.Bounds))
                    {
                        score += enemy.level * 100;
                        lblScore.Text = score.ToString();
                        enemy.pbEnemy.Dispose();
                        bullet.pbBullet.Dispose();
                        enemies.Remove(enemy);
                        bullets.Remove(bullet);
                        return true;
                    }
                }
            }
            return false;
        }

        private void restartGame()
        {
            score = 0;
            lblScore.Text = score.ToString("D2");
            // TODO: Si se supero el HighScore modificarlo.
            List<clsBullet> bulletsCopy = new List<clsBullet>(bullets);
            foreach (clsBullet bullet in bulletsCopy)
            {
                bullets.Remove(bullet);
                bullet.pbBullet.Dispose();
            }
            List<clsBullet> ebulletsCopy = new List<clsBullet>(ebullets);

            foreach (clsBullet bullet in ebulletsCopy)
            {
                bullets.Remove(bullet);
                bullet.pbBullet.Dispose();
            }
            List<clsEnemy> enemyCopy = new List<clsEnemy>(enemies);

            foreach (clsEnemy enemy in enemyCopy)
            {
                enemies.Remove(enemy);
                enemy.pbEnemy.Dispose();
            }
            createEnemies();
            player.pbPlayer.Location = new Point(153, 383);
            lblJugar.Visible = true;
        }

        private void checkEBulletCollision()
        {

            foreach (clsBullet ebullet in ebullets)
            {
                // Comprobación de rectángulos superpuestos (ajustados para el tamaño de la bala)
                if (ebullet.pbBullet.Bounds.IntersectsWith(player.pbPlayer.Bounds))
                {
                    playing = false;
                    canShoot = false;
                    canMove = false;
                    clock.Stop();
                    DialogResult result = MessageBox.Show("Perdiste :( \nVolver a Jugar? ", "Juego Terminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(result == DialogResult.Yes)
                    {
                        restartGame();
                    }
                    else
                    {
                        ebullet.pbBullet.Dispose();
                        bullets.Remove(ebullet);
                        this.Close();
                    }
                }
            }
        }

        private bool checkEnemyCollision()
        {
            foreach (clsEnemy enemy in enemies)
            {   
                if (player.pbPlayer.Bounds.IntersectsWith(enemy.pbEnemy.Bounds))
                {
                    enemy.pbEnemy.Dispose();
                    enemies.Remove(enemy);
                    canShoot = false;
                    canMove = false;
                    return true;
                }
            }
            return false;
        }

        public void createBullet()
        {
            clsBullet bullet = new clsBullet(player.pbPlayer.Location, player.playerSize);
            bullet.createBullet("p");
            this.Controls.Add(bullet.pbBullet);
            bullets.Add(bullet);
        }

        public void createEnemies()
        {
            foreach (clsEnemy enemy in enemies)
            {
                enemy.moveEnemy();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
            }
            xPositionEnemy = 17;
            for (int i = 0; i < 7; i++)
            {
                clsEnemy enemy = new clsEnemy(new Point(xPositionEnemy,50));
                enemy.createEnemy();
                this.Controls.Add(enemy.pbEnemy);
                xPositionEnemy += (enemy.enemySize.Width + 10);
                enemies.Add(enemy);
            }  
        }

        private void frmGalaga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && canMove)
            {
                player.movePlayer("right");
            }
            else if (e.KeyCode == Keys.Left && canMove)
            {
                player.movePlayer("left");
            }
            else if (e.KeyCode == Keys.Space && canShoot)
            {
                createBullet();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if(!playing)
                {
                    lblJugar.Visible = false;
                    playing = true;
                    canShoot = true;
                    canMove = true;
                    clock.Start();
                }
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            List<clsBullet> bulletsCopy = new List<clsBullet>(bullets);
            foreach (clsBullet bullet in bulletsCopy)
            {
                bullet.Shoot("p");

                if (bullet.pbBullet.Location.Y + bullet.bulletSize.Height < 0)
                {
                    bullets.Remove(bullet);
                    bullet.pbBullet.Dispose();
                }
            }
            List<clsBullet> ebulletsCopy = new List<clsBullet>(ebullets);

            foreach (clsBullet bullet in ebulletsCopy)
            {
                bullet.Shoot("e");

                if (bullet.pbBullet.Location.Y > 465)
                {
                    // Elimina la bala de la lista original
                    bullets.Remove(bullet);

                    // Libera la memoria del control PictureBox
                    bullet.pbBullet.Dispose();
                }
            }
            foreach (clsEnemy enemy in enemies)
            {
                enemy.moveEnemy(side);
                if(r.Next(1,201) == 1) // Una posibilidad entre 200 de disparar
                {
                    clsBullet eBullet = new clsBullet(enemy.enemyLocation, enemy.enemySize);
                    eBullet.createBullet("e");
                    this.Controls.Add(eBullet.pbBullet);
                    ebullets.Add(eBullet);
                }
            }
            if (enemies.Count < 5) 
            {
                createEnemies();
                if (r.Next(1, 51) == 1) createEnemies(); // 1 posibilidad entre 50 de crear dos filas de enemigos.
            }
            checkBulletCollision();
            checkEBulletCollision();
            checkEnemyCollision();
            side += 1;
            if (side == 8) side = -7;
        }

        private void frmGalaga_Load(object sender, EventArgs e)
        {   
            player.createPlayer();
            this.Controls.Add(player.pbPlayer);
        }
    }
}
