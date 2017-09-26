using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fields_Of_InJustice
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            prgLoading.Step = 1;
            prgLoading.PerformStep();

            if (prgLoading.Value + 1 == 101)
            {
                tmrLoading.Enabled = false;
                Form main = new frmMain();
                main.Show();
                this.Hide();
            }
        }
    }
}
