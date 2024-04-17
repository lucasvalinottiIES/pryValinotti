using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryValinotti
{
    public class clsEnemy
    {
        Random r = new Random();
        public Size enemySize = new Size(35, 35);
        public int level;
        public Point enemyLocation;
        public PictureBox pbEnemy = new PictureBox();

        public clsEnemy(Point location)
        {
            this.enemyLocation = location;
        }

        public void createEnemy()
        {
            this.pbEnemy.Size = enemySize;
            this.pbEnemy.SizeMode = PictureBoxSizeMode.StretchImage;
            this.level = r.Next(1,7);
            this.pbEnemy.Image = Image.FromFile($"./assets/Galaga/enemy{this.level}.png");
            this.pbEnemy.Location = this.enemyLocation;
        }

        public void moveEnemy()
        {
            pbEnemy.Location = new Point(pbEnemy.Location.X, pbEnemy.Location.Y + this.enemySize.Height + 5);
        }

        public void moveEnemy(int side)
        {
            pbEnemy.Location = new Point(pbEnemy.Location.X + side, pbEnemy.Location.Y);
        }

    }


}
