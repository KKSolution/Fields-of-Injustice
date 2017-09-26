using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Fields_Of_InJustice
{
    class BombAnimation
    {
        int explodeTick = 2000;
        Point bombAnimationLoc = new Point();
        private PictureBox[] explosions = new PictureBox[0];
        private PictureBox centre = new PictureBox();
        private List<int> removeBlocks = new List<int>();
        private int playerPossession = 0;

        public PictureBox[] Explosions
        {
            get
            {
                return explosions;
            }
            set
            {
                explosions = value;
            }
        }

        public PictureBox Centre
        {
            get
            {
                return centre;
            }
            set
            {
                centre = value;
            }
        }

        public Point BombAnimationLoc
        {
            get
            {
                return bombAnimationLoc;
            }
            set
            {
                bombAnimationLoc = value;
            }
        }

        public int ExplodeTick
        {
            get
            {
                return explodeTick;
            }
            set
            {
                explodeTick = value;
            }
        }

        public int PlayerPossession
        {
            get
            {
                return playerPossession;
            }
            set
            {
                playerPossession = value;
            }
        }

        public List<int> RemoveBlocks
        {
            get
            {
                return removeBlocks;
            }
        }

        public void ShowAnimation(int xBombPos, int yBombPos, int explosionRadius, List<PictureBox> chckArrayBlocks, Image setPic)
        {
            bool up = true, down = true, left = true, right = true;

            for (int createBomb = 1; createBomb <= explosionRadius; createBomb++)
            {
                if (up == true)
                {
                    Array.Resize(ref explosions, explosions.Length + 1);
                    explosions[explosions.Length - 1] = new PictureBox();
                    explosions[explosions.Length - 1].Location = new Point(xBombPos, yBombPos - 45 * createBomb);
                    explosions[explosions.Length - 1].Size = new Size(45, 45);
                    explosions[explosions.Length - 1].Image = setPic;
                    explosions[explosions.Length - 1].SizeMode = PictureBoxSizeMode.StretchImage;
                }

                for (int chkWithBoundary = 0; chkWithBoundary < 56; ++chkWithBoundary)
                {
                    if ((Math.Abs(explosions[explosions.Length - 1].Location.X - chckArrayBlocks[chkWithBoundary].Location.X) < 45))
                        if ((Math.Abs(explosions[explosions.Length - 1].Location.Y - chckArrayBlocks[chkWithBoundary].Location.Y) < 45))
                        {
                            explosions[explosions.Length - 1] = null;
                            Array.Resize(ref explosions, explosions.Length - 1);
                            up = false;
                            break;
                        }
                }

                if (left == true)
                {
                    Array.Resize(ref explosions, explosions.Length + 1);
                    explosions[explosions.Length - 1] = new PictureBox();
                    explosions[explosions.Length - 1].Location = new Point(xBombPos - 45 * createBomb, yBombPos);
                    explosions[explosions.Length - 1].Size = new Size(45, 45);
                    explosions[explosions.Length - 1].Image = setPic;
                    explosions[explosions.Length - 1].SizeMode = PictureBoxSizeMode.StretchImage;
                }

                for (int chkWithBoundary = 0; chkWithBoundary < 56; ++chkWithBoundary)
                {
                    if ((Math.Abs(explosions[explosions.Length - 1].Location.X - chckArrayBlocks[chkWithBoundary].Location.X) < 45))
                        if ((Math.Abs(explosions[explosions.Length - 1].Location.Y - chckArrayBlocks[chkWithBoundary].Location.Y) < 45))
                        {
                            explosions[explosions.Length - 1] = null;
                            Array.Resize(ref explosions, explosions.Length - 1);
                            left = false;
                            break;
                        }
                }

                if (right == true)
                {
                    Array.Resize(ref explosions, explosions.Length + 1);
                    explosions[explosions.Length - 1] = new PictureBox();
                    explosions[explosions.Length - 1].Location = new Point(xBombPos + 45 * createBomb, yBombPos);
                    explosions[explosions.Length - 1].Size = new Size(45, 45);
                    explosions[explosions.Length - 1].Image = setPic;
                    explosions[explosions.Length - 1].SizeMode = PictureBoxSizeMode.StretchImage;
                }

                for (int chkWithBoundary = 0; chkWithBoundary < 56; ++chkWithBoundary)
                {
                    if ((Math.Abs(explosions[explosions.Length - 1].Location.X - chckArrayBlocks[chkWithBoundary].Location.X) < 45))
                        if ((Math.Abs(explosions[explosions.Length - 1].Location.Y - chckArrayBlocks[chkWithBoundary].Location.Y) < 45))
                        {
                            explosions[explosions.Length - 1] = null;
                            Array.Resize(ref explosions, explosions.Length - 1);
                            right = false;
                            break;
                        }
                }

                if (down == true)
                {
                    Array.Resize(ref explosions, explosions.Length + 1);
                    explosions[explosions.Length - 1] = new PictureBox();
                    explosions[explosions.Length - 1].Location = new Point(xBombPos, yBombPos + 45 * createBomb);
                    explosions[explosions.Length - 1].Size = new Size(45, 45);
                    explosions[explosions.Length - 1].Image = setPic;
                    explosions[explosions.Length - 1].SizeMode = PictureBoxSizeMode.StretchImage;
                }

                for (int chkWithBoundary = 0; chkWithBoundary < 56; ++chkWithBoundary)
                {
                    if ((Math.Abs(explosions[explosions.Length - 1].Location.X - chckArrayBlocks[chkWithBoundary].Location.X) < 45))
                        if ((Math.Abs(explosions[explosions.Length - 1].Location.Y - chckArrayBlocks[chkWithBoundary].Location.Y) < 45))
                        {
                            explosions[explosions.Length - 1] = null;
                            Array.Resize(ref explosions, explosions.Length - 1);
                            down = false;
                            break;
                        }
                }
            }

            for (int eliminateBlock = 0; eliminateBlock < chckArrayBlocks.Count; ++eliminateBlock)
            {
                for (int chckExplosion = 0; chckExplosion < explosions.Length; ++chckExplosion)
                {
                    if ((Math.Abs(explosions[chckExplosion].Location.X - chckArrayBlocks[eliminateBlock].Location.X) < 60))
                        if ((Math.Abs(explosions[chckExplosion].Location.Y - chckArrayBlocks[eliminateBlock].Location.Y) < 60))
                            if (eliminateBlock >= 56)
                            {
                                if (removeBlocks.Contains(eliminateBlock) == false)
                                    removeBlocks.Add(eliminateBlock);
                            }
                }
            }

            removeBlocks.Sort();
        }
    }
}
