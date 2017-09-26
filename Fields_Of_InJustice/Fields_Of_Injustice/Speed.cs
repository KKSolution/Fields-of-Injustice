//Class Explosion defines attributes, constructors, and methods to allow use of the speed items.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Fields_Of_InJustice
{
    class Speed
    {
        private PictureBox speedPic;

        //This constructor places the speed item on the game form.
        public Speed(int xSpeed, int ySpeed)
        {
            speedPic = new PictureBox();
            speedPic.Size = new Size(59, 59);
            speedPic.SizeMode = PictureBoxSizeMode.StretchImage;
            speedPic.Location = new Point(xSpeed + 1, ySpeed + 1);
            speedPic.Image = Fields_Of_InJustice.Properties.Resources.Speed;
        }

        //This readonly property returns the speed item picturebox.
        public PictureBox GetSpeedPic
        {
            get
            {
                return speedPic;
            }
        }
    }
}
