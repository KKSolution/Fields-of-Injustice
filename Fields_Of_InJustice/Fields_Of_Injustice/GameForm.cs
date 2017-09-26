using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Fields_Of_InJustice
{
    public partial class frmGameForm : Form
    {
        private List<BombAnimation> listAnimation = new List<BombAnimation>();
        private List<PictureBox> arrayBlocks = new List<PictureBox>();
        private List<Explosion> explosionArray = new List<Explosion>();
        private List<Speed> speedArray = new List<Speed>();
        private List<Bomb> bombArray = new List<Bomb>();
        private List<TimeFreeze> timeFreezeArray = new List<TimeFreeze>();
        private Sprite playerOne = new Sprite(1);
        private Sprite playerTwo = new Sprite(2);
        private bool keyUp, keyDn, keyLef, keyRi, keyA, keyW, keyS, keyD, keyV, keyP, keyO, keyB, keyEsc, moveOK = true;
        private int chkDirOne = -1, chkDirTwo = -1;
        private int[] player1Items = new int[3];
        private int[] player2Items = new int[3];
        private int playerOneFrame = 0;
        private int playerTwoFrame = 0;

        public frmGameForm()
        {
            InitializeComponent();
        }

        private void frmGameForm_Load(object sender, EventArgs e)
        {
            int counter = 0;
            int[] arrayTaken = new int[36];
            Random randX = new Random();
            Thread.Sleep(57);
            Random randY = new Random();
            Point blockLocation = new Point(0, 0);
            InputBoxForm inputOne = new InputBoxForm();
            InputBoxForm inputTwo = new InputBoxForm();


            for (int verticalBlocksOne = 0; verticalBlocksOne < 15; ++verticalBlocksOne)
            {
                arrayBlocks.Add(new PictureBox());
                arrayBlocks[arrayBlocks.Count - 1].BackColor = Color.Red;
                arrayBlocks[arrayBlocks.Count - 1].Size = new Size(60, 60);
                arrayBlocks[arrayBlocks.Count - 1].Location = new Point(blockLocation.X, blockLocation.Y);
                arrayBlocks[arrayBlocks.Count - 1].BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(arrayBlocks[arrayBlocks.Count - 1]);
                blockLocation.Y += 60;
            }

            blockLocation.X += 60;
            blockLocation.Y -= 60;

            for (int horizontalBlocksOne = 0; horizontalBlocksOne < 14; ++horizontalBlocksOne)
            {
                arrayBlocks.Add(new PictureBox());
                arrayBlocks[arrayBlocks.Count - 1].BackColor = Color.Red;
                arrayBlocks[arrayBlocks.Count - 1].Size = new Size(60, 60);
                arrayBlocks[arrayBlocks.Count - 1].Location = new Point(blockLocation.X, blockLocation.Y);
                arrayBlocks[arrayBlocks.Count - 1].BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(arrayBlocks[arrayBlocks.Count - 1]);
                blockLocation.X += 60;
            }

            blockLocation.X -= 60;
            blockLocation.Y -= 60;

            for (int verticalBlocksTwo = 0; verticalBlocksTwo < 14; ++verticalBlocksTwo)
            {
                arrayBlocks.Add(new PictureBox());
                arrayBlocks[arrayBlocks.Count - 1].BackColor = Color.Red;
                arrayBlocks[arrayBlocks.Count - 1].Size = new Size(60, 60);
                arrayBlocks[arrayBlocks.Count - 1].Location = new Point(blockLocation.X, blockLocation.Y);
                arrayBlocks[arrayBlocks.Count - 1].BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(arrayBlocks[arrayBlocks.Count - 1]);
                blockLocation.Y -= 60;
            }

            blockLocation.X -= 60;
            blockLocation.Y += 60;

            for (int horizontalBlocksTwo = 0; horizontalBlocksTwo < 13; ++horizontalBlocksTwo)
            {
                arrayBlocks.Add(new PictureBox());
                arrayBlocks[arrayBlocks.Count - 1].BackColor = Color.Red;
                arrayBlocks[arrayBlocks.Count - 1].Size = new Size(60, 60);
                arrayBlocks[arrayBlocks.Count - 1].Location = new Point(blockLocation.X, blockLocation.Y);
                arrayBlocks[arrayBlocks.Count - 1].BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(arrayBlocks[arrayBlocks.Count - 1]);
                blockLocation.X -= 60;
            }

            for (int boxes = 0; boxes < 84; ++boxes)
            {
                blockLocation.X = 60 * randX.Next(1, 14);
                blockLocation.Y = 60 * randY.Next(1, 14);

                if ((blockLocation.X == 60 && blockLocation.Y == 60) || (blockLocation.X == 780 && blockLocation.Y == 780))
                {
                    boxes -= 1;
                    continue;
                }
                else if ((blockLocation.X == 120 && blockLocation.Y == 60) || (blockLocation.X == 720 && blockLocation.Y == 780))
                {
                    boxes -= 1;
                    continue;
                }
                else if ((blockLocation.X == 60 && blockLocation.Y == 120) || (blockLocation.X == 780 && blockLocation.Y == 720))
                {
                    boxes -= 1;
                    continue;
                }

                for (int checkBLocks = 0; checkBLocks < arrayBlocks.Count; ++checkBLocks)
                {
                    if (arrayBlocks[checkBLocks].Location.X == blockLocation.X && arrayBlocks[checkBLocks].Location.Y == blockLocation.Y)
                    {
                        boxes -= 1;
                        goto ExitFor;
                    }
                }

                arrayBlocks.Add(new PictureBox());

                if (boxes % 4 == 0)
                {
                    arrayBlocks[arrayBlocks.Count - 1].Image = Fields_Of_InJustice.Properties.Resources.rock;
                }
                else if (boxes % 4 == 1)
                {
                    arrayBlocks[arrayBlocks.Count - 1].Image = Fields_Of_InJustice.Properties.Resources.tree;
                }
                else if (boxes % 4 == 2)
                {
                    arrayBlocks[arrayBlocks.Count - 1].Image = Fields_Of_InJustice.Properties.Resources.House_One;
                }
                else if (boxes % 4 == 3)
                {
                    arrayBlocks[arrayBlocks.Count - 1].Image = Fields_Of_InJustice.Properties.Resources.House_Two;
                }

                arrayBlocks[arrayBlocks.Count - 1].SizeMode = PictureBoxSizeMode.StretchImage;
                arrayBlocks[arrayBlocks.Count - 1].Size = new Size(60, 60);
                arrayBlocks[arrayBlocks.Count - 1].Location = new Point(blockLocation.X, blockLocation.Y);
                arrayBlocks[arrayBlocks.Count - 1].BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(arrayBlocks[arrayBlocks.Count - 1]);
                counter += 1;
ExitFor:        continue;
            }

            Random randItems = new Random();
            Thread.Sleep(57);
            Random rand84 = new Random();
            int checkCounter, tempRand = randItems.Next(3, 9);
            counter = 0;

            for (int placeExplosionItems = 0; placeExplosionItems < tempRand; ++placeExplosionItems)
            {
                checkCounter = rand84.Next(arrayBlocks.Count - 84, arrayBlocks.Count);

                if (arrayTaken.Contains(checkCounter))
                {
                    placeExplosionItems -= 1;
                    continue;
                }

                arrayTaken[counter] = checkCounter;
                counter += 1;

                explosionArray.Add(new Explosion(arrayBlocks[checkCounter].Location.X, arrayBlocks[checkCounter].Location.Y));
                this.Controls.Add(explosionArray[explosionArray.Count - 1].GetExplosionPic);
            }

            tempRand = randItems.Next(3, 9);

            for (int placeSpeedItems = 0; placeSpeedItems < tempRand; ++placeSpeedItems)
            {
                checkCounter = rand84.Next(arrayBlocks.Count - 84, arrayBlocks.Count);

                if (arrayTaken.Contains(checkCounter))
                {
                    placeSpeedItems -= 1;
                    continue;
                }

                arrayTaken[counter] = checkCounter;
                counter += 1;

                speedArray.Add(new Speed(arrayBlocks[checkCounter].Location.X, arrayBlocks[checkCounter].Location.Y));
                this.Controls.Add(speedArray[speedArray.Count - 1].GetSpeedPic);
            }

            tempRand = randItems.Next(3, 9);

            for (int placeBombItems = 0; placeBombItems < tempRand; ++placeBombItems)
            {
                checkCounter = rand84.Next(arrayBlocks.Count - 84, arrayBlocks.Count);

                if (arrayTaken.Contains(checkCounter))
                {
                    placeBombItems -= 1;
                    continue;
                }

                arrayTaken[counter] = checkCounter;
                counter += 1;

                bombArray.Add(new Bomb(arrayBlocks[checkCounter].Location.X, arrayBlocks[checkCounter].Location.Y));
                this.Controls.Add(bombArray[bombArray.Count - 1].GetBombPic);
            }

            tempRand = randItems.Next(3, 9);

            for (int placeFreezeItems = 0; placeFreezeItems < tempRand; ++placeFreezeItems)
            {
                checkCounter = rand84.Next(arrayBlocks.Count - 84, arrayBlocks.Count);

                if (arrayTaken.Contains(checkCounter))
                {
                    placeFreezeItems -= 1;
                    continue;
                }

                arrayTaken[counter] = checkCounter;
                counter += 1;

                timeFreezeArray.Add(new TimeFreeze(arrayBlocks[checkCounter].Location.X, arrayBlocks[checkCounter].Location.Y));
                this.Controls.Add(timeFreezeArray[timeFreezeArray.Count - 1].GetFreezePic);
            }

            inputOne.show("Enter Player 1 Name (8 characters, spaces count):");

            if (inputOne.DialogResult == DialogResult.OK)
            {
                if (inputOne.text.Length > 8)
                    lblPlayerOne.Text = inputOne.text.Substring(0, 8).Trim();
                else
                    lblPlayerOne.Text = inputOne.text;
            }
            else if (inputOne.DialogResult == DialogResult.Cancel)
                lblPlayerOne.Text = "Player 1";

            inputTwo.show("Enter Player 2 Name (8 characters, spaces count):");

            if (inputTwo.DialogResult == DialogResult.OK)
            {
                if (inputTwo.text.Length > 8)
                    lblPlayerTwo.Text = inputTwo.text.Substring(0, 8).Trim();
                else
                    lblPlayerTwo.Text = inputTwo.text;
            }
            else if (inputTwo.DialogResult == DialogResult.Cancel)
                lblPlayerTwo.Text = "Player 2";

            tmrBombCheck.Enabled = true;
            tmrMoveCheckOne.Enabled = true;
            tmrMoveCheckTwo.Enabled = true;
        }

        private void tmrBombCheck_Tick(object sender, EventArgs e)
        {
            Image blueFire = Fields_Of_InJustice.Properties.Resources.blue_flamewallflame_appear_0000;
            Image redFire = Fields_Of_InJustice.Properties.Resources.red_flamewallflame_appear_0000;

            for (int chkAnimate = 0; chkAnimate < listAnimation.Count; chkAnimate++)
            {
                listAnimation[chkAnimate].ExplodeTick -= tmrBombCheck.Interval;

                if (listAnimation[chkAnimate].ExplodeTick == 0)
                {
                    if (listAnimation[chkAnimate].Centre.BackColor == Color.Transparent)
                        listAnimation[chkAnimate].ShowAnimation(listAnimation[chkAnimate].BombAnimationLoc.X, listAnimation[chkAnimate].BombAnimationLoc.Y, playerOne.Strength, arrayBlocks, blueFire);
                    else
                        listAnimation[chkAnimate].ShowAnimation(listAnimation[chkAnimate].BombAnimationLoc.X, listAnimation[chkAnimate].BombAnimationLoc.Y, playerTwo.Strength, arrayBlocks, redFire);

                    for (int animateCreate = 0; animateCreate < listAnimation[chkAnimate].Explosions.Length; animateCreate++)
                        this.Controls.Add(listAnimation[chkAnimate].Explosions[animateCreate]);

                    for (int explodedBlocks = 0; explodedBlocks < listAnimation[chkAnimate].RemoveBlocks.Count(); ++explodedBlocks)
                        this.Controls.Remove(arrayBlocks[listAnimation[chkAnimate].RemoveBlocks[explodedBlocks]]);

                    for (int removeArrayBlocks = 0; removeArrayBlocks < listAnimation[chkAnimate].RemoveBlocks.Count(); ++removeArrayBlocks)
                    {
                        arrayBlocks.RemoveAt(listAnimation[chkAnimate].RemoveBlocks[removeArrayBlocks] - removeArrayBlocks);
                    }

                    for (int chkHitOne = 0; chkHitOne < listAnimation[chkAnimate].Explosions.Length; ++chkHitOne)
                    {
                        if (listAnimation[chkAnimate].Explosions[chkHitOne].Bounds.IntersectsWith(playerOne.spritePic))
                        {
                            playerOne.Life -= 1;
                            prgLifeOne.PerformStep();

                            if (playerOne.Life == 0)
                            {
                                MessageBox.Show("Player 2 has won!", "GAME OVER!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Environment.Exit(0);
                            }

                            break;
                        }
                    }

                    for (int chkHitTwo = 0; chkHitTwo < listAnimation[chkAnimate].Explosions.Length; ++chkHitTwo)
                    {
                        if (listAnimation[chkAnimate].Explosions[chkHitTwo].Bounds.IntersectsWith(playerTwo.spritePic))
                        {
                            playerTwo.Life -= 1;
                            prgLifeTwo.PerformStep();

                            if (playerTwo.Life == 0)
                            {
                                MessageBox.Show("Player 1 has won!", "GAME OVER!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Environment.Exit(0);
                            }

                            break;
                        }
                    }
                }
                else if (listAnimation[chkAnimate].ExplodeTick == -500)
                {
                    for (int animateRemove = 0; animateRemove < listAnimation[chkAnimate].Explosions.Length; animateRemove++)
                        this.Controls.Remove(listAnimation[chkAnimate].Explosions[animateRemove]);

                    this.Controls.Remove(listAnimation[chkAnimate].Centre);

                    if (listAnimation[chkAnimate].Centre.BackColor == Color.Transparent && playerOne.NumOfBombs < playerOne.MaxBombs)
                        playerOne.NumOfBombs += 1;
                    else if (listAnimation[chkAnimate].Centre.BackColor == Color.Purple && playerTwo.NumOfBombs < playerTwo.MaxBombs)
                        playerTwo.NumOfBombs += 1;

                    listAnimation.RemoveAt(chkAnimate--);
                }
            }
        }

        private void frmGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (keyEsc == false)
                {
                    tmrBombCheck.Enabled = false;
                    tmrMoveCheckOne.Enabled = false;
                    tmrMoveCheckTwo.Enabled = false;
                    keyEsc = true;
                }
                else if (keyEsc == true)
                {
                    tmrBombCheck.Enabled = true;
                    tmrMoveCheckOne.Enabled = true;
                    tmrMoveCheckTwo.Enabled = true;
                    keyEsc = false;
                }
            }

            if (e.KeyCode == Keys.W)
                keyW = true;
            else if (e.KeyCode == Keys.S)
                keyS = true;
            else if (e.KeyCode == Keys.D)
                keyD = true;
            else if (e.KeyCode == Keys.A)
                keyA = true;

            if (e.KeyCode == Keys.Down)
                keyDn = true;
            else if (e.KeyCode == Keys.Left)
                keyLef = true;
            else if (e.KeyCode == Keys.Up)
                keyUp = true;
            else if (e.KeyCode == Keys.Right)
                keyRi = true;

            if (e.KeyCode == Keys.V)
                keyV = true;

            if (e.KeyCode == Keys.B)
                keyB = true;

            if (e.KeyCode == Keys.P)
                keyP = true;

            if (e.KeyCode == Keys.O)
                keyO = true;
        }

        private void frmGameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
                keyP = false;

            if (e.KeyCode == Keys.O)
                keyO = false;

            if (e.KeyCode == Keys.V)
                keyV = false;

            if (e.KeyCode == Keys.B)
                keyB = true;

            if (e.KeyCode == Keys.Down)
                keyDn = false;
            else if (e.KeyCode == Keys.Left)
                keyLef = false;
            else if (e.KeyCode == Keys.Up)
                keyUp = false;
            else if (e.KeyCode == Keys.Right)
                keyRi = false;

            if (e.KeyCode == Keys.W)
                keyW = false;
            else if (e.KeyCode == Keys.A)
                keyA = false;
            else if (e.KeyCode == Keys.S)
                keyS = false;
            else if (e.KeyCode == Keys.D)
                keyD = false;
        }

        private void tmrMoveCheckOne_Tick(object sender, EventArgs e)
        {
            if (keyP == true && playerOne.NumOfBombs > 0)
            {
                for (int chkIntersectOne = 0; chkIntersectOne < listAnimation.Count; chkIntersectOne++)
                {
                    if ((Math.Abs(playerOne.SpriteLoc.X - listAnimation[chkIntersectOne].BombAnimationLoc.X) < 45))
                    {
                        if ((Math.Abs(playerOne.SpriteLoc.Y - listAnimation[chkIntersectOne].BombAnimationLoc.Y) < 45))
                            goto Exit;
                    }
                }

                listAnimation.Add(new BombAnimation());
                listAnimation[listAnimation.Count - 1].BombAnimationLoc = new Point(playerOne.SpriteLoc.X, playerOne.SpriteLoc.Y);
                listAnimation[listAnimation.Count - 1].Centre.Image = Fields_Of_InJustice.Properties.Resources.blue_flamewallflame_appear_0000;
                listAnimation[listAnimation.Count - 1].Centre.SizeMode = PictureBoxSizeMode.StretchImage;
                listAnimation[listAnimation.Count - 1].Centre.BackColor = Color.Transparent;
                listAnimation[listAnimation.Count - 1].Centre.Location = new Point(listAnimation[listAnimation.Count - 1].BombAnimationLoc.X, listAnimation[listAnimation.Count - 1].BombAnimationLoc.Y);
                listAnimation[listAnimation.Count - 1].Centre.Size = new Size(45, 45);
                playerOne.NumOfBombs -= 1;
                this.Controls.Add(listAnimation[listAnimation.Count - 1].Centre);
            }

Exit:
            if (keyO == true && playerOne.NumOfFreeze > 0 && playerOne.FreezeCounter == 0)
            {
                playerOne.FreezeTempSpeed = playerTwo.Speed;
                playerOne.FreezeCounter += 30;
                playerTwo.Speed = 3;
            }

            if (playerOne.FreezeCounter <= 3000 && playerOne.FreezeCounter > 0)
            {
                playerOne.FreezeCounter += 30;

            }
            else if (playerOne.FreezeCounter > 3000)
            {
                playerOne.FreezeCounter = 0;
                playerOne.NumOfFreeze -= 1;
                playerTwo.Speed += playerOne.FreezeTempSpeed;
                lblFreezeOne.Text = "x" + playerOne.NumOfFreeze;
            }

            if (keyLef == true)
            {
                moveOK = true;

                for (int chkIntersect = 0; chkIntersect < arrayBlocks.Count(); ++chkIntersect)
                {
                    if (arrayBlocks[chkIntersect].Location.X < playerOne.SpriteLoc.X)
                    {
                        if ((Math.Abs((playerOne.SpriteLoc.X - playerOne.Speed) - arrayBlocks[chkIntersect].Location.X) < 60))
                        {
                            if (arrayBlocks[chkIntersect].Location.Y < playerOne.SpriteLoc.Y)
                            {
                                if ((Math.Abs(playerOne.SpriteLoc.Y - arrayBlocks[chkIntersect].Location.Y) < 60))
                                    moveOK = false;
                            }
                            else if (arrayBlocks[chkIntersect].Location.Y > playerOne.SpriteLoc.Y)
                            {
                                if ((Math.Abs(playerOne.SpriteLoc.Y - arrayBlocks[chkIntersect].Location.Y) < 45))
                                    moveOK = false;
                            }
                            else if (arrayBlocks[chkIntersect].Location.Y == playerOne.SpriteLoc.Y)
                                moveOK = false;
                        }
                    }
                }

                if (moveOK == true)
                    playerOne.SpriteLoc = new Point(playerOne.SpriteLoc.X - playerOne.Speed, playerOne.SpriteLoc.Y);

                if (chkDirOne != 1)
                {
                    chkDirOne = 1;
                }
            }
            else if (keyDn == true)
            {
                moveOK = true;

                for (int chkIntersect = 0; chkIntersect < arrayBlocks.Count(); ++chkIntersect)
                {
                    if (arrayBlocks[chkIntersect].Location.Y > playerOne.SpriteLoc.Y)
                    {
                        if ((Math.Abs((playerOne.SpriteLoc.Y + playerOne.Speed) - arrayBlocks[chkIntersect].Location.Y) < 45))
                        {
                            if (arrayBlocks[chkIntersect].Location.X < playerOne.SpriteLoc.X)
                            {
                                if ((Math.Abs(playerOne.SpriteLoc.X - arrayBlocks[chkIntersect].Location.X) < 60))
                                {
                                    moveOK = false;
                                    break;
                                }
                            }
                            else if (arrayBlocks[chkIntersect].Location.X > playerOne.SpriteLoc.X)
                            {
                                if ((Math.Abs(playerOne.SpriteLoc.X - arrayBlocks[chkIntersect].Location.X) < 45))
                                {
                                    moveOK = false;
                                    break;
                                }
                            }
                            else if (arrayBlocks[chkIntersect].Location.X == playerOne.SpriteLoc.X)
                                moveOK = false;
                        }
                    }
                }

                if (moveOK == true)
                    playerOne.SpriteLoc = new Point(playerOne.SpriteLoc.X, playerOne.SpriteLoc.Y + playerOne.Speed);

                if (chkDirOne != 0)
                {
                    chkDirOne = 0;
                }

            }
            else if (keyRi == true)
            {
                moveOK = true;

                for (int chkIntersect = 0; chkIntersect < arrayBlocks.Count(); ++chkIntersect)
                {
                    if (arrayBlocks[chkIntersect].Location.X > playerOne.SpriteLoc.X)
                    {
                        if ((Math.Abs((playerOne.SpriteLoc.X + playerOne.Speed) - arrayBlocks[chkIntersect].Location.X) < 45))
                        {
                            if (arrayBlocks[chkIntersect].Location.Y < playerOne.SpriteLoc.Y)
                            {
                                if ((Math.Abs(playerOne.SpriteLoc.Y - arrayBlocks[chkIntersect].Location.Y) < 60))
                                    moveOK = false;
                            }
                            else if (arrayBlocks[chkIntersect].Location.Y > playerOne.SpriteLoc.Y)
                            {
                                if ((Math.Abs(playerOne.SpriteLoc.Y - arrayBlocks[chkIntersect].Location.Y) < 45))
                                    moveOK = false;
                            }
                            else if (arrayBlocks[chkIntersect].Location.Y == playerOne.SpriteLoc.Y)
                                moveOK = false;
                        }
                    }
                }

                if (moveOK == true)
                    playerOne.SpriteLoc = new Point(playerOne.SpriteLoc.X + playerOne.Speed, playerOne.SpriteLoc.Y);

                if (chkDirOne != 3)
                {
                    chkDirOne = 3;

                }
            }
            else if (keyUp == true)
            {
                moveOK = true;

                for (int chkIntersect = 0; chkIntersect < arrayBlocks.Count(); ++chkIntersect)
                {
                    if (arrayBlocks[chkIntersect].Location.Y < playerOne.SpriteLoc.Y)
                    {
                        if ((Math.Abs((playerOne.SpriteLoc.Y - playerOne.Speed) - arrayBlocks[chkIntersect].Location.Y) < 60))
                        {
                            if (arrayBlocks[chkIntersect].Location.X < playerOne.SpriteLoc.X)
                            {
                                if ((Math.Abs(playerOne.SpriteLoc.X - arrayBlocks[chkIntersect].Location.X) < 60))
                                {
                                    moveOK = false;
                                    break;
                                }
                            }
                            else if (arrayBlocks[chkIntersect].Location.X > playerOne.SpriteLoc.X)
                            {
                                if ((Math.Abs(playerOne.SpriteLoc.X - arrayBlocks[chkIntersect].Location.X) < 45))
                                {
                                    moveOK = false;
                                    break;
                                }
                            }
                            else if (arrayBlocks[chkIntersect].Location.X == playerOne.SpriteLoc.X)
                                moveOK = false;
                        }
                    }
                }

                if (moveOK == true)
                    playerOne.SpriteLoc = new Point(playerOne.SpriteLoc.X, playerOne.SpriteLoc.Y - playerOne.Speed);

                if (chkDirOne != 2)
                {
                    chkDirOne = 2;
                }
            }

            for (int bombIntersect = 0; bombIntersect < bombArray.Count(); ++bombIntersect)
            {
                if ((Math.Abs(playerOne.SpriteLoc.X - bombArray[bombIntersect].GetBombPic.Location.X) < 44))
                {
                    if ((Math.Abs(playerOne.SpriteLoc.Y - bombArray[bombIntersect].GetBombPic.Location.Y) < 44))
                    {
                        this.Controls.Remove(bombArray[bombIntersect].GetBombPic);
                        bombArray.RemoveAt(bombIntersect);
                        playerOne.NumOfBombs += 1;
                        playerOne.MaxBombs += 1;
                        player1Items[0] += 1;
                        lblBombOne.Text = "x" + player1Items[0];
                    }
                }
            }

            for (int explosionIntersect = 0; explosionIntersect < explosionArray.Count(); ++explosionIntersect)
            {
                if ((Math.Abs(playerOne.SpriteLoc.X - explosionArray[explosionIntersect].GetExplosionPic.Location.X) < 44))
                {
                    if ((Math.Abs(playerOne.SpriteLoc.Y - explosionArray[explosionIntersect].GetExplosionPic.Location.Y) < 44))
                    {
                        this.Controls.Remove(explosionArray[explosionIntersect].GetExplosionPic);
                        explosionArray.RemoveAt(explosionIntersect);
                        playerOne.Strength += 1;
                        player1Items[1] += 1;
                        lblExplosionOne.Text = "x" + player1Items[1];
                    }
                }
            }

            for (int speedIntersect = 0; speedIntersect < speedArray.Count(); ++speedIntersect)
            {
                if ((Math.Abs(playerOne.SpriteLoc.X - speedArray[speedIntersect].GetSpeedPic.Location.X) < 44))
                {
                    if ((Math.Abs(playerOne.SpriteLoc.Y - speedArray[speedIntersect].GetSpeedPic.Location.Y) < 44))
                    {
                        this.Controls.Remove(speedArray[speedIntersect].GetSpeedPic);
                        speedArray.RemoveAt(speedIntersect);
                        playerOne.Speed += 3;
                        player1Items[2] += 1;
                        lblSpeedOne.Text = "x" + player1Items[2];
                    }
                }
            }

            for (int timeFreezeIntersect = 0; timeFreezeIntersect < timeFreezeArray.Count(); ++timeFreezeIntersect)
            {
                if ((Math.Abs(playerOne.SpriteLoc.X - timeFreezeArray[timeFreezeIntersect].GetFreezePic.Location.X) < 44))
                {
                    if ((Math.Abs(playerOne.SpriteLoc.Y - timeFreezeArray[timeFreezeIntersect].GetFreezePic.Location.Y) < 44))
                    {
                        this.Controls.Remove(timeFreezeArray[timeFreezeIntersect].GetFreezePic);
                        timeFreezeArray.RemoveAt(timeFreezeIntersect);
                        playerOne.NumOfFreeze += 1;
                        lblFreezeOne.Text = "x" + playerOne.NumOfFreeze;
                    }
                }
            }

            if (playerOneFrame == 7)
                playerOneFrame = 0;
            else
                playerOneFrame += 1;

            if (chkDirOne == 1)
            {
                if (playerOneFrame == 0)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_w0000;
                else if (playerOneFrame == 1)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_w0001;
                else if (playerOneFrame == 2)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_w0002;
                else if (playerOneFrame == 3)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_w0003;
                else if (playerOneFrame == 4)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_w0004;
                else if (playerOneFrame == 5)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_w0005;
                else if (playerOneFrame == 6)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_w0006;
                else if (playerOneFrame == 7)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_w0007;
            }
            else if (chkDirOne == 0)
            {
                if (playerOneFrame == 0)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_s0000;
                else if (playerOneFrame == 1)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_s0001;
                else if (playerOneFrame == 2)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_s0002;
                else if (playerOneFrame == 3)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_s0003;
                else if (playerOneFrame == 4)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_s0004;
                else if (playerOneFrame == 5)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_s0005;
                else if (playerOneFrame == 6)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_s0006;
                else if (playerOneFrame == 7)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_s0007;
            }
            else if (chkDirOne == 3)
            {
                if (playerOneFrame == 0)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_e0000;
                else if (playerOneFrame == 1)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_e0001;
                else if (playerOneFrame == 2)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_e0002;
                else if (playerOneFrame == 3)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_e0003;
                else if (playerOneFrame == 4)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_e0004;
                else if (playerOneFrame == 5)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_e0005;
                else if (playerOneFrame == 6)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_e0006;
                else if (playerOneFrame == 7)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_e0007;
            }
            else if (chkDirOne == 2)
            {
                if (playerOneFrame == 0)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_n0000;
                else if (playerOneFrame == 1)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_n0001;
                else if (playerOneFrame == 2)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_n0002;
                else if (playerOneFrame == 3)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_n0003;
                else if (playerOneFrame == 4)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_n0004;
                else if (playerOneFrame == 5)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_n0005;
                else if (playerOneFrame == 6)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_n0006;
                else if (playerOneFrame == 7)
                    playerOne.playerImage = Fields_Of_InJustice.Properties.Resources._2walking_n0007;
            }

            this.Invalidate();
        }

        private void tmrMoveCheckTwo_Tick(object sender, EventArgs e)
        {
            if (keyV == true && playerTwo.NumOfBombs > 0)
            {
                for (int chkIntersectTwo = 0; chkIntersectTwo < listAnimation.Count; chkIntersectTwo++)
                {
                    if ((Math.Abs(playerTwo.SpriteLoc.X - listAnimation[chkIntersectTwo].BombAnimationLoc.X) < 45))
                    {
                        if ((Math.Abs(playerTwo.SpriteLoc.Y - listAnimation[chkIntersectTwo].BombAnimationLoc.Y) < 45))
                            goto Exit2;
                    }
                }

                listAnimation.Add(new BombAnimation());
                listAnimation[listAnimation.Count - 1].BombAnimationLoc = new Point(playerTwo.SpriteLoc.X, playerTwo.SpriteLoc.Y);
                listAnimation[listAnimation.Count - 1].Centre.Image = Fields_Of_InJustice.Properties.Resources.red_flamewallflame_appear_0000;
                listAnimation[listAnimation.Count - 1].Centre.SizeMode = PictureBoxSizeMode.StretchImage;
                listAnimation[listAnimation.Count - 1].Centre.BackColor = Color.Purple;
                listAnimation[listAnimation.Count - 1].Centre.Location = new Point(listAnimation[listAnimation.Count - 1].BombAnimationLoc.X, listAnimation[listAnimation.Count - 1].BombAnimationLoc.Y);
                listAnimation[listAnimation.Count - 1].Centre.Size = new Size(45, 45);
                this.Controls.Add(listAnimation[listAnimation.Count - 1].Centre);
                playerTwo.NumOfBombs -= 1;
            }

Exit2:
            if (keyB == true && playerTwo.NumOfFreeze > 0 && playerTwo.FreezeCounter == 0)
            {
                playerTwo.FreezeTempSpeed = playerOne.Speed;
                playerTwo.FreezeCounter += 30;
                playerOne.Speed = 3;
            }

            if (playerTwo.FreezeCounter <= 3000 && playerTwo.FreezeCounter > 0)
            {
                playerTwo.FreezeCounter += 30;
            }
            else if (playerTwo.FreezeCounter > 3000)
            {
                playerTwo.FreezeCounter = 0;
                playerTwo.NumOfFreeze -= 1;
                playerOne.Speed += playerTwo.FreezeTempSpeed;
                lblFreezeTwo.Text = "x" + playerTwo.NumOfFreeze;
                keyB = false;
            }

            if (keyA == true)
            {
                moveOK = true;

                for (int chkIntersect = 0; chkIntersect < arrayBlocks.Count(); ++chkIntersect)
                {
                    if (arrayBlocks[chkIntersect].Location.X < playerTwo.SpriteLoc.X)
                    {
                        if ((Math.Abs((playerTwo.SpriteLoc.X - playerTwo.Speed) - arrayBlocks[chkIntersect].Location.X) < 60))
                        {
                            if ((Math.Abs(playerTwo.SpriteLoc.Y - arrayBlocks[chkIntersect].Location.Y) < 45))
                                moveOK = false;
                        }
                    }
                }

                if (moveOK == true)
                    playerTwo.SpriteLoc = new Point(playerTwo.SpriteLoc.X - playerTwo.Speed, playerTwo.SpriteLoc.Y);

                if (chkDirTwo != 1)
                {
                    chkDirTwo = 1;
                }

            }
            else if (keyS == true)
            {
                moveOK = true;

                for (int chkIntersect = 0; chkIntersect < arrayBlocks.Count(); ++chkIntersect)
                {
                    if ((Math.Abs((playerTwo.SpriteLoc.Y + playerTwo.Speed) - arrayBlocks[chkIntersect].Location.Y) < 45))
                    {
                        if ((Math.Abs(playerTwo.SpriteLoc.X - arrayBlocks[chkIntersect].Location.X) < 45))
                            moveOK = false;
                    }
                }

                if (moveOK == true)
                    playerTwo.SpriteLoc = new Point(playerTwo.SpriteLoc.X, playerTwo.SpriteLoc.Y + playerTwo.Speed);

                if (chkDirTwo != 0)
                {
                    chkDirTwo = 0;
                }

            }
            else if (keyD == true)
            {
                moveOK = true;

                for (int chkIntersect = 0; chkIntersect < arrayBlocks.Count(); ++chkIntersect)
                {
                    if ((Math.Abs((playerTwo.SpriteLoc.X + playerTwo.Speed) - arrayBlocks[chkIntersect].Location.X) < 45))
                    {
                        if ((Math.Abs(playerTwo.SpriteLoc.Y - arrayBlocks[chkIntersect].Location.Y) < 45))
                            moveOK = false;
                    }
                }

                if (moveOK == true)
                    playerTwo.SpriteLoc = new Point(playerTwo.SpriteLoc.X + playerTwo.Speed, playerTwo.SpriteLoc.Y);

                if (chkDirTwo != 3)
                {
                    chkDirTwo = 3;

                }
            }
            else if (keyW == true)
            {
                moveOK = true;

                for (int chkIntersect = 0; chkIntersect < arrayBlocks.Count(); ++chkIntersect)
                {
                    if (arrayBlocks[chkIntersect].Location.Y < playerTwo.SpriteLoc.Y)
                    {
                        if ((Math.Abs((playerTwo.SpriteLoc.Y - playerTwo.Speed) - arrayBlocks[chkIntersect].Location.Y) < 60))
                        {
                            if ((Math.Abs(playerTwo.SpriteLoc.X - arrayBlocks[chkIntersect].Location.X) < 45))
                                moveOK = false;
                        }
                    }
                }
                
                if (moveOK == true)
                    playerTwo.SpriteLoc = new Point(playerTwo.SpriteLoc.X, playerTwo.SpriteLoc.Y - playerTwo.Speed);

                if (chkDirTwo != 2)
                {
                    chkDirTwo = 2;
                }
            }

            for (int bombIntersect = 0; bombIntersect < bombArray.Count(); ++bombIntersect)
            {
                if ((Math.Abs(playerTwo.SpriteLoc.X - bombArray[bombIntersect].GetBombPic.Location.X) < 44))
                {
                    if ((Math.Abs(playerTwo.SpriteLoc.Y - bombArray[bombIntersect].GetBombPic.Location.Y) < 44))
                    {
                        this.Controls.Remove(bombArray[bombIntersect].GetBombPic);
                        bombArray.RemoveAt(bombIntersect);
                        playerTwo.NumOfBombs += 1;
                        playerTwo.MaxBombs += 1;
                        player2Items[0] += 1;
                        lblBombTwo.Text = "x" + player2Items[0];
                    }
                }
            }

            for (int explosionIntersect = 0; explosionIntersect < explosionArray.Count(); ++explosionIntersect)
            {
                if ((Math.Abs(playerTwo.SpriteLoc.X - explosionArray[explosionIntersect].GetExplosionPic.Location.X) < 44))
                {
                    if ((Math.Abs(playerTwo.SpriteLoc.Y - explosionArray[explosionIntersect].GetExplosionPic.Location.Y) < 44))
                    {
                        this.Controls.Remove(explosionArray[explosionIntersect].GetExplosionPic);
                        explosionArray.RemoveAt(explosionIntersect);
                        playerTwo.Strength += 1;
                        player2Items[1] += 1;
                        lblExplosionTwo.Text = "x" + player2Items[1];
                    }
                }
            }

            for (int speedIntersect = 0; speedIntersect < speedArray.Count(); ++speedIntersect)
            {
                if ((Math.Abs(playerTwo.SpriteLoc.X - speedArray[speedIntersect].GetSpeedPic.Location.X) < 44))
                {
                    if ((Math.Abs(playerTwo.SpriteLoc.Y - speedArray[speedIntersect].GetSpeedPic.Location.Y) < 44))
                    {
                        this.Controls.Remove(speedArray[speedIntersect].GetSpeedPic);
                        speedArray.RemoveAt(speedIntersect);
                        playerTwo.Speed += 3;
                        player2Items[2] += 1;
                        lblSpeedTwo.Text = "x" + player2Items[2];
                    }
                }
            }

            for (int timeFreezeIntersect = 0; timeFreezeIntersect < timeFreezeArray.Count(); ++timeFreezeIntersect)
            {
                if ((Math.Abs(playerTwo.SpriteLoc.X - timeFreezeArray[timeFreezeIntersect].GetFreezePic.Location.X) < 44))
                {
                    if ((Math.Abs(playerTwo.SpriteLoc.Y - timeFreezeArray[timeFreezeIntersect].GetFreezePic.Location.Y) < 44))
                    {
                        this.Controls.Remove(timeFreezeArray[timeFreezeIntersect].GetFreezePic);
                        timeFreezeArray.RemoveAt(timeFreezeIntersect);
                        playerTwo.NumOfFreeze += 1;
                        lblFreezeTwo.Text = "x" + playerTwo.NumOfFreeze;
                    }
                }
            }

            if (playerTwoFrame == 7)
                playerTwoFrame = 0;
            else
                playerTwoFrame += 1;

            if (chkDirTwo == 1)
            {
                if (playerTwoFrame == 0)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_w0000;
                else if (playerTwoFrame == 1)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_w0001;
                else if (playerTwoFrame == 2)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_w0002;
                else if (playerTwoFrame == 3)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_w0003;
                else if (playerTwoFrame == 4)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_w0004;
                else if (playerTwoFrame == 5)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_w0005;
                else if (playerTwoFrame == 6)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_w0006;
                else if (playerTwoFrame == 7)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_w0007;
            }
            else if (chkDirTwo == 0)
            {
                if (playerTwoFrame == 0)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_s0000;
                else if (playerTwoFrame == 1)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_s0001;
                else if (playerTwoFrame == 2)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_s0002;
                else if (playerTwoFrame == 3)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_s0003;
                else if (playerTwoFrame == 4)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_s0004;
                else if (playerTwoFrame == 5)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_s0005;
                else if (playerTwoFrame == 6)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_s0006;
                else if (playerTwoFrame == 7)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_s0007;
            }
            else if (chkDirTwo == 3)
            {
                if (playerTwoFrame == 0)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_e0000;
                else if (playerTwoFrame == 1)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_e0001;
                else if (playerTwoFrame == 2)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_e0002;
                else if (playerTwoFrame == 3)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_e0003;
                else if (playerTwoFrame == 4)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_e0004;
                else if (playerTwoFrame == 5)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_e0005;
                else if (playerTwoFrame == 6)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_e0006;
                else if (playerTwoFrame == 7)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_e0007;
            }
            else if (chkDirTwo == 2)
            {
                if (playerTwoFrame == 0)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_n0000;
                else if (playerTwoFrame == 1)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_n0001;
                else if (playerTwoFrame == 2)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_n0002;
                else if (playerTwoFrame == 3)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_n0003;
                else if (playerTwoFrame == 4)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_n0004;
                else if (playerTwoFrame == 5)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_n0005;
                else if (playerTwoFrame == 6)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_n0006;
                else if (playerTwoFrame == 7)
                    playerTwo.playerImage = Fields_Of_InJustice.Properties.Resources.walking_n0007;
            }

            this.Invalidate();
        }

        private void frmGameForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(playerOne.playerImage, playerOne.spritePic);
            e.Graphics.DrawImage(playerTwo.playerImage, playerTwo.spritePic);
        }
    }
}
