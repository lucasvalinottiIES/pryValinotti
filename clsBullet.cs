using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryValinotti
{
    public class clsBullet
    {
        public Size bulletSize = new Size(6, 15);
        private Point bulletLocation;
        public PictureBox pbBullet = new PictureBox();

        public clsBullet(Point playerLocation, Size playerSize)
        {
            this.bulletLocation = new Point(playerLocation.X + playerSize.Width / 2, playerLocation.Y);
        }

        public void createBullet(string shooter)
        {
            this.pbBullet.Size = bulletSize;
            this.pbBullet.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbBullet.Image = Image.FromFile($"./assets/Galaga/{shooter}bullet.png");
            this.pbBullet.Location = this.bulletLocation;
        }

        public void Shoot(string shooter)
        {
            if(shooter == "p")
            {
                this.pbBullet.Location = new Point(pbBullet.Location.X, pbBullet.Location.Y - 10);
            }
            else
            {
                this.pbBullet.Location = new Point(pbBullet.Location.X, pbBullet.Location.Y + 10);
            }
        }
    }
}
