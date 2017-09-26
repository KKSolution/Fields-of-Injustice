namespace Fields_Of_InJustice
{
    partial class frmMoreControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoreControls));
            this.lblTips = new System.Windows.Forms.Label();
            this.picShowGame = new System.Windows.Forms.PictureBox();
            this.btnCloseControls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picShowGame)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTips
            // 
            this.lblTips.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTips.Location = new System.Drawing.Point(275, 9);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(410, 402);
            this.lblTips.TabIndex = 0;
            this.lblTips.Text = resources.GetString("lblTips.Text");
            // 
            // picShowGame
            // 
            this.picShowGame.Location = new System.Drawing.Point(40, 106);
            this.picShowGame.Name = "picShowGame";
            this.picShowGame.Size = new System.Drawing.Size(100, 50);
            this.picShowGame.TabIndex = 1;
            this.picShowGame.TabStop = false;
            // 
            // btnCloseControls
            // 
            this.btnCloseControls.Location = new System.Drawing.Point(319, 422);
            this.btnCloseControls.Name = "btnCloseControls";
            this.btnCloseControls.Size = new System.Drawing.Size(75, 23);
            this.btnCloseControls.TabIndex = 2;
            this.btnCloseControls.Text = "Close";
            this.btnCloseControls.UseVisualStyleBackColor = true;
            this.btnCloseControls.Click += new System.EventHandler(this.btnCloseControls_Click);
            // 
            // frmMoreControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 457);
            this.Controls.Add(this.btnCloseControls);
            this.Controls.Add(this.picShowGame);
            this.Controls.Add(this.lblTips);
            this.Name = "frmMoreControls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "More Controls";
            ((System.ComponentModel.ISupportInitialize)(this.picShowGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.PictureBox picShowGame;
        private System.Windows.Forms.Button btnCloseControls;
    }
}