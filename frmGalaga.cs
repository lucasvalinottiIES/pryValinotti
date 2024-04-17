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
        // SCORE
        int score = 0;
        clsScoreData scoreData = new clsScoreData();
        int highscore;

        // PLAYER
        clsPlayer player = new clsPlayer(new Point(153, 383));
        string playerName;

        // FLAGS
        bool bossLoaded = false;
        bool playing = false;
        bool canMove = false;
        bool canShoot = false;

        // Variables para la creacion de enemigos y movimiento de enemigos.
        int xPositionEnemy = 17; // Posicion inicial del primer enemigo
        int side = 1;

        // BOSS
        clsBoss boss;
        int bossLoader = 0;
        int bossLevel = 1;

        Random r = new Random();

        // Listas para controlar tanto enemigos como balas.
        List<clsEnemy> enemies = new List<clsEnemy>();
        List<clsBullet> bullets = new List<clsBullet>();
        List<clsBullet> ebullets = new List<clsBullet>();
        List<clsBullet> bbullets = new List<clsBullet>();

        public frmGalaga(string playerName)
        {
            InitializeComponent();
            createEnemies();
            this.playerName = playerName;
            this.Text += $" - {this.playerName}";
        }

        #region Iniciar y reiniciar el juego
        private void frmGalaga_Load(object sender, EventArgs e)
        {   
            player.createPlayer();
            this.Controls.Add(player.pbPlayer);
            highscore = scoreData.getHighScore();
            lblHighScore.Text = highscore.ToString("D2");
            lblLevel.Text = bossLevel.ToString("D2");
            lblPlayer.Text = playerName;
        }
        private void restartGame()
        {
            score = 0;
            lblScore.Text = score.ToString("D2");
            bossLevel = 1;
            lblLevel.Text = bossLevel.ToString("D2");
            bossLoader = 0;
            player.restartLevel();
            deleteBullets();
            deleteEnemies();
            deleteBoss();
            createEnemies();
            player.pbPlayer.Location = new Point(153, 383);
            lblJugar.Visible = true;
        }
        #endregion

        #region Crear balas y Enemigos
        public void createBullet()
        {
            clsBullet bullet = new clsBullet(player.pbPlayer.Location, player.playerSize,"p");
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

        public void createBoss()
        {
            bossLoaded = true;
            boss = new clsBoss(bossLevel);
            boss.createBoss();
            this.Controls.Add(boss.pbBoss);
            bossLoader = 0;
        }
        #endregion

        #region Capturar Teclas
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
            else if (e.KeyCode == Keys.D && canShoot)
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
            }else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion

        #region Colisiones de Balas
        private void checkBulletCollision()
        {
            if (!bossLoaded)
            {
                List<clsEnemy> enemyCopy = new List<clsEnemy>(enemies);
                foreach (clsEnemy enemy in enemyCopy)
                {
                    foreach (clsBullet bullet in bullets)
                    {
                        // Comprobación de rectángulos superpuestos (ajustados para el tamaño de la bala)
                        if (bullet.pbBullet.Bounds.IntersectsWith(enemy.pbEnemy.Bounds))
                        {
                            score += enemy.level * 100;
                            bossLoader += enemy.level * 100;
                            lblScore.Text = score.ToString();
                            enemy.pbEnemy.Dispose();
                            bullet.pbBullet.Dispose();
                            enemies.Remove(enemy);
                            bullets.Remove(bullet);
                            if (bossLoader > 15000)
                            {
                                deleteBullets();
                                deleteEnemies();
                                createBoss();
                            }
                            break;
                        }

                    }
                }
            }
            else
            {
                foreach (clsBullet bullet in bullets)
                {
                    // Comprobación de rectángulos superpuestos (ajustados para el tamaño de la bala)
                    if (bullet.pbBullet.Bounds.IntersectsWith(boss.pbBoss.Bounds))
                    {
                        bullet.pbBullet.Dispose();
                        bullets.Remove(bullet);
                        boss.life -= 10;
                        if(boss.life <= 0)
                        {
                            deleteBoss();
                            score += bossLevel * 2500;
                            if(bossLevel == 2 || bossLevel == 4) player.upgradeLevel();
                            lblScore.Text = score.ToString();
                            bossLevel++;
                            lblLevel.Text = bossLevel.ToString("D2");
                        }
                        break;
                    }
                }
            }
        }

        private void checkBossBulletCollision()
        {
            List<clsBullet> bBulletsCopy = new List<clsBullet>(bbullets);
            foreach (clsBullet bbullet in bBulletsCopy)
            {
                // Comprobación de rectángulos superpuestos (ajustados para el tamaño de la bala)
                if (bbullet.pbBullet.Bounds.IntersectsWith(player.pbPlayer.Bounds))
                {
                    bbullet.pbBullet.Dispose();
                    bbullets.Remove(bbullet);
                    playing = false;
                    canShoot = false;
                    canMove = false;
                    clock.Stop();
                    scoreData.addScore(this.playerName, this.score);
                    if (score > highscore)
                    {
                        MessageBox.Show("NEW HIGHSCORE!!!", $"{playerName} - Juego Terminado");
                        lblHighScore.Text = score.ToString();
                    }
                    DialogResult result = MessageBox.Show($"Perdiste :( \nVolver a Jugar?\n", $"{playerName} - Juego Terminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        restartGame();
                    }
                    else
                    {
                        this.Close();
                    }
                    break;
                }
            }
        }

        private void checkEnemyBulletCollision()
        {
            List<clsBullet> eBulletsCopy = new List<clsBullet>(ebullets);
            foreach (clsBullet ebullet in eBulletsCopy)
            {
                // Comprobación de rectángulos superpuestos (ajustados para el tamaño de la bala)
                if (ebullet.pbBullet.Bounds.IntersectsWith(player.pbPlayer.Bounds))
                {
                    ebullet.pbBullet.Dispose();
                    ebullets.Remove(ebullet);
                    playing = false;
                    canShoot = false;
                    canMove = false;
                    clock.Stop();
                    scoreData.addScore(this.playerName, this.score);
                    if (score > highscore)
                    {
                        MessageBox.Show("NEW HIGHSCORE!!!", $"{playerName} - Juego Terminado");
                        lblHighScore.Text = score.ToString();
                    }
                    DialogResult result = MessageBox.Show($"Perdiste :( \nVolver a Jugar?\n", $"{playerName} - Juego Terminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(result == DialogResult.Yes)
                    {
                        restartGame();
                    }
                    else
                    {
                        this.Close();
                    }
                    break;
                }
            }
        }
        #endregion

        #region Borrar enemigos y balas
        private void deleteEnemies()
        {
            List<clsEnemy> enemyCopy = new List<clsEnemy>(enemies);

            foreach (clsEnemy enemy in enemyCopy)
            {
                enemies.Remove(enemy);
                enemy.pbEnemy.Dispose();
            }
        }

        private void deleteBullets()
        {
            List<clsBullet> bulletsCopy = new List<clsBullet>(bullets);
            foreach (clsBullet bullet in bulletsCopy)
            {
                bullets.Remove(bullet);
                bullet.pbBullet.Dispose();
            }
            List<clsBullet> ebulletsCopy = new List<clsBullet>(ebullets);

            foreach (clsBullet bullet in ebulletsCopy)
            {
                ebullets.Remove(bullet);
                bullet.pbBullet.Dispose();
            }

            List<clsBullet> bbulletsCopy = new List<clsBullet>(bbullets);

            foreach (clsBullet bullet in bbulletsCopy)
            {
                bbullets.Remove(bullet);
                bullet.pbBullet.Dispose();
            }
        }

        private void deleteBoss()
        {
            if(bossLoaded)
            {
                boss.pbBoss.Dispose();
                deleteBullets();
                bossLoaded = false;
            }
        }
        #endregion

        #region Clock
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

            if(!bossLoaded)
            {
                List<clsBullet> ebulletsCopy = new List<clsBullet>(ebullets);

                foreach (clsBullet bullet in ebulletsCopy)
                {
                    bullet.Shoot("e");

                    if (bullet.pbBullet.Location.Y > 465)
                    {
                        // Elimina la bala de la lista original
                        ebullets.Remove(bullet);

                        // Libera la memoria del control PictureBox
                        bullet.pbBullet.Dispose();
                    }
                }
                if (enemies.Count < 5)
                {
                    createEnemies();
                    if (r.Next(1, 51) == 1) createEnemies(); // 1 posibilidad entre 50 de crear dos filas de enemigos.
                }
                foreach (clsEnemy enemy in enemies)
                {
                    enemy.moveEnemy(side);
                    if (r.Next(1, 201) == 1) // Una posibilidad entre 200 de disparar
                    {
                        clsBullet eBullet = new clsBullet(enemy.enemyLocation, enemy.enemySize, "e");
                        eBullet.createBullet("e");
                        this.Controls.Add(eBullet.pbBullet);
                        ebullets.Add(eBullet);
                    }
                }    
                checkEnemyBulletCollision();
            }
            else
            {
                List<clsBullet> bbulletsCopy = new List<clsBullet>(bbullets);

                foreach (clsBullet bullet in bbulletsCopy)
                {
                    bullet.Shoot("b");

                    if (bullet.pbBullet.Location.Y > 465)
                    {
                        // Elimina la bala de la lista original
                        bbullets.Remove(bullet);

                        // Libera la memoria del control PictureBox
                        bullet.pbBullet.Dispose();
                    }
                }
                if (r.Next(1, 101) == 1)
                {
                    clsBullet bBullet = new clsBullet(boss.bossLocation, boss.bossSize, "b");
                    bBullet.createBullet("b");
                    this.Controls.Add(bBullet.pbBullet);
                    bbullets.Add(bBullet);
                }
                boss.moveBoss(side);
                checkBossBulletCollision();
            }
            checkBulletCollision();
            side += 1;
            if (side == 8) side = -7;
        }
        #endregion
    }
}
