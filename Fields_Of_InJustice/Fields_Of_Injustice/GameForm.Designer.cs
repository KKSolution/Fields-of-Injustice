namespace Fields_Of_InJustice
{
    partial class frmGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrBombCheck = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveCheckOne = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveCheckTwo = new System.Windows.Forms.Timer(this.components);
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblSpeedOne = new System.Windows.Forms.Label();
            this.lblExplosionOne = new System.Windows.Forms.Label();
            this.lblFreezeOne = new System.Windows.Forms.Label();
            this.lblBombOne = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.lblSpeedTwo = new System.Windows.Forms.Label();
            this.lblExplosionTwo = new System.Windows.Forms.Label();
            this.lblFreezeTwo = new System.Windows.Forms.Label();
            this.lblBombTwo = new System.Windows.Forms.Label();
            this.lblLifeOne = new System.Windows.Forms.Label();
            this.prgLifeOne = new System.Windows.Forms.ProgressBar();
            this.lblLifeTwo = new System.Windows.Forms.Label();
            this.prgLifeTwo = new System.Windows.Forms.ProgressBar();
            this.picSpeedOne = new System.Windows.Forms.PictureBox();
            this.picExplosionOne = new System.Windows.Forms.PictureBox();
            this.picBombTwo = new System.Windows.Forms.PictureBox();
            this.picFreezeOne = new System.Windows.Forms.PictureBox();
            this.picFreezeTwo = new System.Windows.Forms.PictureBox();
            this.picBombOne = new System.Windows.Forms.PictureBox();
            this.picExplosionTwo = new System.Windows.Forms.PictureBox();
            this.picSpeedTwo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeedOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplosionOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBombTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFreezeOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFreezeTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBombOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplosionTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeedTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrBombCheck
            // 
            this.tmrBombCheck.Interval = 50;
            this.tmrBombCheck.Tick += new System.EventHandler(this.tmrBombCheck_Tick);
            // 
            // tmrMoveCheckOne
            // 
            this.tmrMoveCheckOne.Interval = 30;
            this.tmrMoveCheckOne.Tick += new System.EventHandler(this.tmrMoveCheckOne_Tick);
            // 
            // tmrMoveCheckTwo
            // 
            this.tmrMoveCheckTwo.Interval = 30;
            this.tmrMoveCheckTwo.Tick += new System.EventHandler(this.tmrMoveCheckTwo_Tick);
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.Location = new System.Drawing.Point(964, 136);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(89, 27);
            this.lblPlayerOne.TabIndex = 1;
            this.lblPlayerOne.Text = "Player 1";
            // 
            // lblSpeedOne
            // 
            this.lblSpeedOne.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedOne.Location = new System.Drawing.Point(1019, 186);
            this.lblSpeedOne.Name = "lblSpeedOne";
            this.lblSpeedOne.Size = new System.Drawing.Size(35, 41);
            this.lblSpeedOne.TabIndex = 1;
            this.lblSpeedOne.Text = "x0";
            this.lblSpeedOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExplosionOne
            // 
            this.lblExplosionOne.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplosionOne.Location = new System.Drawing.Point(1019, 264);
            this.lblExplosionOne.Name = "lblExplosionOne";
            this.lblExplosionOne.Size = new System.Drawing.Size(35, 41);
            this.lblExplosionOne.TabIndex = 5;
            this.lblExplosionOne.Text = "x0";
            this.lblExplosionOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFreezeOne
            // 
            this.lblFreezeOne.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreezeOne.Location = new System.Drawing.Point(1019, 340);
            this.lblFreezeOne.Name = "lblFreezeOne";
            this.lblFreezeOne.Size = new System.Drawing.Size(35, 41);
            this.lblFreezeOne.TabIndex = 6;
            this.lblFreezeOne.Text = "x0";
            this.lblFreezeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBombOne
            // 
            this.lblBombOne.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBombOne.Location = new System.Drawing.Point(1019, 416);
            this.lblBombOne.Name = "lblBombOne";
            this.lblBombOne.Size = new System.Drawing.Size(35, 41);
            this.lblBombOne.TabIndex = 7;
            this.lblBombOne.Text = "x0";
            this.lblBombOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwo.Location = new System.Drawing.Point(964, 542);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(89, 27);
            this.lblPlayerTwo.TabIndex = 10;
            this.lblPlayerTwo.Text = "Player 2";
            // 
            // lblSpeedTwo
            // 
            this.lblSpeedTwo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedTwo.Location = new System.Drawing.Point(1019, 592);
            this.lblSpeedTwo.Name = "lblSpeedTwo";
            this.lblSpeedTwo.Size = new System.Drawing.Size(35, 41);
            this.lblSpeedTwo.TabIndex = 8;
            this.lblSpeedTwo.Text = "x0";
            this.lblSpeedTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExplosionTwo
            // 
            this.lblExplosionTwo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplosionTwo.Location = new System.Drawing.Point(1019, 670);
            this.lblExplosionTwo.Name = "lblExplosionTwo";
            this.lblExplosionTwo.Size = new System.Drawing.Size(35, 41);
            this.lblExplosionTwo.TabIndex = 14;
            this.lblExplosionTwo.Text = "x0";
            this.lblExplosionTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFreezeTwo
            // 
            this.lblFreezeTwo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreezeTwo.Location = new System.Drawing.Point(1019, 746);
            this.lblFreezeTwo.Name = "lblFreezeTwo";
            this.lblFreezeTwo.Size = new System.Drawing.Size(35, 41);
            this.lblFreezeTwo.TabIndex = 15;
            this.lblFreezeTwo.Text = "x0";
            this.lblFreezeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBombTwo
            // 
            this.lblBombTwo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBombTwo.Location = new System.Drawing.Point(1019, 822);
            this.lblBombTwo.Name = "lblBombTwo";
            this.lblBombTwo.Size = new System.Drawing.Size(35, 41);
            this.lblBombTwo.TabIndex = 16;
            this.lblBombTwo.Text = "x0";
            this.lblBombTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLifeOne
            // 
            this.lblLifeOne.BackColor = System.Drawing.Color.Transparent;
            this.lblLifeOne.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifeOne.Location = new System.Drawing.Point(964, 470);
            this.lblLifeOne.Name = "lblLifeOne";
            this.lblLifeOne.Size = new System.Drawing.Size(84, 32);
            this.lblLifeOne.TabIndex = 17;
            this.lblLifeOne.Text = "Life";
            this.lblLifeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgLifeOne
            // 
            this.prgLifeOne.BackColor = System.Drawing.Color.White;
            this.prgLifeOne.Location = new System.Drawing.Point(953, 505);
            this.prgLifeOne.Name = "prgLifeOne";
            this.prgLifeOne.Size = new System.Drawing.Size(118, 23);
            this.prgLifeOne.Step = -25;
            this.prgLifeOne.TabIndex = 19;
            this.prgLifeOne.Value = 100;
            // 
            // lblLifeTwo
            // 
            this.lblLifeTwo.BackColor = System.Drawing.Color.Transparent;
            this.lblLifeTwo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifeTwo.Location = new System.Drawing.Point(964, 876);
            this.lblLifeTwo.Name = "lblLifeTwo";
            this.lblLifeTwo.Size = new System.Drawing.Size(84, 32);
            this.lblLifeTwo.TabIndex = 20;
            this.lblLifeTwo.Text = "Life";
            this.lblLifeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgLifeTwo
            // 
            this.prgLifeTwo.Location = new System.Drawing.Point(953, 911);
            this.prgLifeTwo.Name = "prgLifeTwo";
            this.prgLifeTwo.Size = new System.Drawing.Size(118, 23);
            this.prgLifeTwo.Step = -25;
            this.prgLifeTwo.TabIndex = 21;
            this.prgLifeTwo.Value = 100;
            // 
            // picSpeedOne
            // 
            this.picSpeedOne.Image = global::Fields_Of_InJustice.Properties.Resources.Speed;
            this.picSpeedOne.Location = new System.Drawing.Point(953, 177);
            this.picSpeedOne.Name = "picSpeedOne";
            this.picSpeedOne.Size = new System.Drawing.Size(60, 60);
            this.picSpeedOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpeedOne.TabIndex = 1;
            this.picSpeedOne.TabStop = false;
            // 
            // picExplosionOne
            // 
            this.picExplosionOne.Image = global::Fields_Of_InJustice.Properties.Resources.Explosion;
            this.picExplosionOne.Location = new System.Drawing.Point(953, 255);
            this.picExplosionOne.Name = "picExplosionOne";
            this.picExplosionOne.Size = new System.Drawing.Size(60, 60);
            this.picExplosionOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExplosionOne.TabIndex = 2;
            this.picExplosionOne.TabStop = false;
            // 
            // picBombTwo
            // 
            this.picBombTwo.Image = global::Fields_Of_InJustice.Properties.Resources.Bomb;
            this.picBombTwo.Location = new System.Drawing.Point(953, 813);
            this.picBombTwo.Name = "picBombTwo";
            this.picBombTwo.Size = new System.Drawing.Size(60, 60);
            this.picBombTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBombTwo.TabIndex = 13;
            this.picBombTwo.TabStop = false;
            // 
            // picFreezeOne
            // 
            this.picFreezeOne.Image = global::Fields_Of_InJustice.Properties.Resources.Time_Freeze;
            this.picFreezeOne.Location = new System.Drawing.Point(953, 331);
            this.picFreezeOne.Name = "picFreezeOne";
            this.picFreezeOne.Size = new System.Drawing.Size(60, 60);
            this.picFreezeOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFreezeOne.TabIndex = 3;
            this.picFreezeOne.TabStop = false;
            // 
            // picFreezeTwo
            // 
            this.picFreezeTwo.Image = global::Fields_Of_InJustice.Properties.Resources.Time_Freeze;
            this.picFreezeTwo.Location = new System.Drawing.Point(953, 737);
            this.picFreezeTwo.Name = "picFreezeTwo";
            this.picFreezeTwo.Size = new System.Drawing.Size(60, 60);
            this.picFreezeTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFreezeTwo.TabIndex = 12;
            this.picFreezeTwo.TabStop = false;
            // 
            // picBombOne
            // 
            this.picBombOne.Image = global::Fields_Of_InJustice.Properties.Resources.Bomb;
            this.picBombOne.Location = new System.Drawing.Point(953, 407);
            this.picBombOne.Name = "picBombOne";
            this.picBombOne.Size = new System.Drawing.Size(60, 60);
            this.picBombOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBombOne.TabIndex = 4;
            this.picBombOne.TabStop = false;
            // 
            // picExplosionTwo
            // 
            this.picExplosionTwo.Image = global::Fields_Of_InJustice.Properties.Resources.Explosion;
            this.picExplosionTwo.Location = new System.Drawing.Point(953, 661);
            this.picExplosionTwo.Name = "picExplosionTwo";
            this.picExplosionTwo.Size = new System.Drawing.Size(60, 60);
            this.picExplosionTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExplosionTwo.TabIndex = 11;
            this.picExplosionTwo.TabStop = false;
            // 
            // picSpeedTwo
            // 
            this.picSpeedTwo.Image = global::Fields_Of_InJustice.Properties.Resources.Speed;
            this.picSpeedTwo.Location = new System.Drawing.Point(953, 583);
            this.picSpeedTwo.Name = "picSpeedTwo";
            this.picSpeedTwo.Size = new System.Drawing.Size(60, 60);
            this.picSpeedTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpeedTwo.TabIndex = 9;
            this.picSpeedTwo.TabStop = false;
            // 
            // frmGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(76)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1100, 788);
            this.Controls.Add(this.lblLifeTwo);
            this.Controls.Add(this.prgLifeTwo);
            this.Controls.Add(this.lblLifeOne);
            this.Controls.Add(this.lblBombTwo);
            this.Controls.Add(this.lblFreezeTwo);
            this.Controls.Add(this.picSpeedOne);
            this.Controls.Add(this.lblExplosionTwo);
            this.Controls.Add(this.lblPlayerOne);
            this.Controls.Add(this.lblSpeedTwo);
            this.Controls.Add(this.picExplosionOne);
            this.Controls.Add(this.picBombTwo);
            this.Controls.Add(this.picFreezeOne);
            this.Controls.Add(this.picFreezeTwo);
            this.Controls.Add(this.picBombOne);
            this.Controls.Add(this.picExplosionTwo);
            this.Controls.Add(this.lblSpeedOne);
            this.Controls.Add(this.picSpeedTwo);
            this.Controls.Add(this.lblExplosionOne);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.lblFreezeOne);
            this.Controls.Add(this.lblBombOne);
            this.Controls.Add(this.prgLifeOne);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frmGameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmGameForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picSpeedOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplosionOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBombTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFreezeOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFreezeTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBombOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplosionTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeedTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrBombCheck;
        private System.Windows.Forms.Timer tmrMoveCheckOne;
        private System.Windows.Forms.Timer tmrMoveCheckTwo;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.PictureBox picSpeedOne;
        private System.Windows.Forms.PictureBox picExplosionOne;
        private System.Windows.Forms.PictureBox picFreezeOne;
        private System.Windows.Forms.PictureBox picBombOne;
        private System.Windows.Forms.Label lblSpeedOne;
        private System.Windows.Forms.Label lblExplosionOne;
        private System.Windows.Forms.Label lblFreezeOne;
        private System.Windows.Forms.Label lblBombOne;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.PictureBox picSpeedTwo;
        private System.Windows.Forms.PictureBox picExplosionTwo;
        private System.Windows.Forms.PictureBox picFreezeTwo;
        private System.Windows.Forms.PictureBox picBombTwo;
        private System.Windows.Forms.Label lblSpeedTwo;
        private System.Windows.Forms.Label lblExplosionTwo;
        private System.Windows.Forms.Label lblFreezeTwo;
        private System.Windows.Forms.Label lblBombTwo;
        private System.Windows.Forms.Label lblLifeOne;
        private System.Windows.Forms.ProgressBar prgLifeOne;
        private System.Windows.Forms.Label lblLifeTwo;
        private System.Windows.Forms.ProgressBar prgLifeTwo;





    }
}