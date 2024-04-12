using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryValinotti
{
    public class clsBoss
    {
        Random r = new Random();
        public Size bossSize = new Size(150, 150);
        public int level;
        public int life;
        public Point bossLocation = new Point(95, 55);
        public string image;
        public PictureBox pbBoss = new PictureBox();

        public clsBoss(int bossLevel)
        {
            this.level = bossLevel;
            if(bossLevel <= 8)
            {
                this.image = $"./assets/Galaga/boss{this.level}.png";
                this.life = this.level * 50 + 50;
            }
            else
            {
                Random r = new Random();
                this.image = $"./assets/Galaga/boss{r.Next(1,9)}.png";
                this.life = 500;
            }
        }

        public void createBoss()
        {
            this.pbBoss.Size = bossSize;
            this.pbBoss.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbBoss.Image = Image.FromFile(this.image);
            this.pbBoss.Location = this.bossLocation;
        }

        public void moveBoss(int side)
        {
            pbBoss.Location = new Point(pbBoss.Location.X + side, pbBoss.Location.Y);
        }
    }
}
