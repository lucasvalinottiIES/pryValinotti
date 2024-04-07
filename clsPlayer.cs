using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryValinotti
{
    public class clsPlayer
    {
        public Size playerSize = new Size(35,35);
        private string image = "./assets/Galaga/Player.png";
        private Point playerLocation;
        public PictureBox pbPlayer = new PictureBox();

        public clsPlayer(Point location)
        {
            this.playerLocation = location;
        }

        public void createPlayer()
        {
            this.pbPlayer.Size = playerSize;
            this.pbPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbPlayer.Image = Image.FromFile(this.image);
            this.pbPlayer.Location = this.playerLocation;
        }

        public void movePlayer(string direction)
        {
            if(direction == "left")
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X - 15, pbPlayer.Location.Y);
                if (pbPlayer.Location.X < 0)
                {
                    pbPlayer.Location = new Point(0, pbPlayer.Location.Y);
                }
            }
            else if(direction == "right") 
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X + 15, pbPlayer.Location.Y);
                if (pbPlayer.Location.X > 303)
                {
                    pbPlayer.Location = new Point(303, pbPlayer.Location.Y);
                }
            }
        }

    }
}
