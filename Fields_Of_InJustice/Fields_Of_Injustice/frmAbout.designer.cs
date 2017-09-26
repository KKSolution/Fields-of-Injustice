namespace Fields_Of_InJustice
{
    partial class frmAbout
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
            this.lblAboutOne = new System.Windows.Forms.Label();
            this.lblAboutTwo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAboutOne
            // 
            this.lblAboutOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutOne.ForeColor = System.Drawing.Color.Lime;
            this.lblAboutOne.Location = new System.Drawing.Point(12, 9);
            this.lblAboutOne.Name = "lblAboutOne";
            this.lblAboutOne.Size = new System.Drawing.Size(358, 104);
            this.lblAboutOne.TabIndex = 0;
            this.lblAboutOne.Text = "Fields of  Justice is an intense version of the previous game called Bomberman. B" +
                "ut of  course our version is better since it reolves around the theme of League " +
                "of Legends.";
            // 
            // lblAboutTwo
            // 
            this.lblAboutTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutTwo.ForeColor = System.Drawing.Color.Lime;
            this.lblAboutTwo.Location = new System.Drawing.Point(12, 129);
            this.lblAboutTwo.Name = "lblAboutTwo";
            this.lblAboutTwo.Size = new System.Drawing.Size(358, 104);
            this.lblAboutTwo.TabIndex = 1;
            this.lblAboutTwo.Text = "Crimson Emblem TM is a eco-friendly company that supports cancer research. Please" +
                " support he official release and play our game Fields of Justice.";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(166, 261);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(389, 296);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAboutTwo);
            this.Controls.Add(this.lblAboutOne);
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAbout";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAboutOne;
        private System.Windows.Forms.Label lblAboutTwo;
        private System.Windows.Forms.Button btnBack;
    }
}