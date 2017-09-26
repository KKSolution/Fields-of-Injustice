namespace Fields_Of_InJustice
{
    partial class frmSplashScreen
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
            this.lblSplashTitle = new System.Windows.Forms.Label();
            this.prgLoading = new System.Windows.Forms.ProgressBar();
            this.tmrLoading = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSplashTitle
            // 
            this.lblSplashTitle.AutoSize = true;
            this.lblSplashTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSplashTitle.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplashTitle.ForeColor = System.Drawing.Color.Red;
            this.lblSplashTitle.Location = new System.Drawing.Point(49, 338);
            this.lblSplashTitle.Name = "lblSplashTitle";
            this.lblSplashTitle.Size = new System.Drawing.Size(770, 86);
            this.lblSplashTitle.TabIndex = 0;
            this.lblSplashTitle.Text = "Fields of Justice";
            this.lblSplashTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgLoading
            // 
            this.prgLoading.Location = new System.Drawing.Point(163, 427);
            this.prgLoading.Name = "prgLoading";
            this.prgLoading.Size = new System.Drawing.Size(532, 30);
            this.prgLoading.Step = 100;
            this.prgLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgLoading.TabIndex = 1;
            // 
            // tmrLoading
            // 
            this.tmrLoading.Enabled = true;
            this.tmrLoading.Interval = 50;
            this.tmrLoading.Tick += new System.EventHandler(this.tmrLoading_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fields_Of_InJustice.Properties.Resources.Splash_Screen_Pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 501);
            this.Controls.Add(this.prgLoading);
            this.Controls.Add(this.lblSplashTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSplashTitle;
        private System.Windows.Forms.ProgressBar prgLoading;
        private System.Windows.Forms.Timer tmrLoading;
    }
}