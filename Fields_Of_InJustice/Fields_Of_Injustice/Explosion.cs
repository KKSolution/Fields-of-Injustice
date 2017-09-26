//Class Explosion defines attributes, constructors, and methods to allow use of the explosion items.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Fields_Of_InJustice
{
    class Explosion
    {
        private PictureBox explosionPic;

        //This constructor places the explosion item on the game form.
        public Explosion(int xExplosion, int yExplosion)
        {
            explosionPic = new PictureBox();
            explosionPic.Size = new Size(59, 59);
            explosionPic.SizeMode = PictureBoxSizeMode.StretchImage;
            explosionPic.Location = new Point(xExplosion + 1, yExplosion + 1);
            explosionPic.Image = Fields_Of_InJustice.Properties.Resources.Explosion;
        }

        //This readonly property returns the explosion item picturebox.
        public PictureBox GetExplosionPic
        {
            get
            {
                return explosionPic;
            }
        }
    }
}
