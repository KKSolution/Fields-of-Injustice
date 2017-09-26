using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Fields_Of_InJustice
{
    class Sprite
    {
        public Rectangle spritePic = new Rectangle();
        public Image playerImage;
        private Point spriteLoc = new Point();
        private int numOfBombs = 1, maxBombs = 1, numOfFreeze, freezeCounter, freezeTempSpeed;
        private int str = 0, speed = 3, life = 4;

        public Sprite(int playerNum)
        {
            if (playerNum == 1)
            {
                spriteLoc = new Point(60, 60);
                playerImage = Fields_Of_InJustice.Properties.Resources._2walking_w0000;
            }
            else
            {
                spriteLoc = new Point(780, 780);
                playerImage = Fields_Of_InJustice.Properties.Resources.walking_e0000;
            }

            spritePic.Location = spriteLoc;
            spritePic.Size = new Size(45, 45);
            str = 1;
        }

        public Point SpriteLoc
        {
            get
            {
                return spriteLoc;
            }
            set
            {
                spriteLoc = value;
                spritePic.Location = spriteLoc;
            }
        }

        public int Strength
        {
            get
            {
                return str;
            }
            set
            {
                str = value;
            }
        }

        public int NumOfBombs
        {
            get
            {
                return numOfBombs;
            }
            set
            {
                numOfBombs = value;
            }
        }

        public int MaxBombs
        {
            get
            {
                return maxBombs;
            }
            set
            {
                maxBombs = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public int NumOfFreeze
        {
            get
            {
                return numOfFreeze;
            }
            set
            {
                numOfFreeze = value;
            }
        }

        public int FreezeCounter
        {
            get
            {
                return freezeCounter;
            }
            set
            {
                freezeCounter = value;
            }
        }

        public int FreezeTempSpeed
        {
            get
            {
                return freezeTempSpeed;
            }
            set
            {
                freezeTempSpeed = value;
            }
        }

        public int Life
        {
            get
            {
                return life;
            }
            set
            {
                life = value;
            }
        }
    }
}
