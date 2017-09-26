//Class Explosion defines attributes, constructors, and methods to allow use of the time freeze items.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Fields_Of_InJustice
{
    class TimeFreeze
    {
        private PictureBox timeFreezePic;

        //This constructor places the time freeze item on the game form.
        public TimeFreeze(int xTimeFreeze, int yTimeFreeze)
        {
            timeFreezePic = new PictureBox();
            timeFreezePic.Size = new Size(59, 59);
            timeFreezePic.SizeMode = PictureBoxSizeMode.StretchImage;
            timeFreezePic.Location = new Point(xTimeFreeze + 1, yTimeFreeze + 1);
            timeFreezePic.Image = Fields_Of_InJustice.Properties.Resources.Time_Freeze;
        }

        //This readonly property returns the time freeze item picturebox.
        public PictureBox GetFreezePic
        {
            get
            {
                return timeFreezePic;
            }
        }
    }
}
