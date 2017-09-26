//Class Explosion defines attributes, constructors, and methods to allow use of the bomb items.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Fields_Of_InJustice
{
    class Bomb
    {
        private PictureBox bombPic;

        //This constructor places the bomb item on the game form.
        public Bomb(int xBomb, int yBomb)
        {
            bombPic = new PictureBox();
            bombPic.Size = new Size(59, 59);
            bombPic.SizeMode = PictureBoxSizeMode.StretchImage;
            bombPic.Location = new Point(xBomb + 1, yBomb + 1);
            bombPic.Image = Fields_Of_InJustice.Properties.Resources.Bomb;
        }

        //This readonly property returns the bomb item picturebox.
        public PictureBox GetBombPic
        {
            get
            {
                return bombPic;
            }
        }
    }
}