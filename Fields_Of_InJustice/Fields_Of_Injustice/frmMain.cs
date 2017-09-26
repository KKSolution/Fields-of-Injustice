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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form about = new frmAbout();
            about.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnControls_Click(object sender, EventArgs e)
        {
            Form controls = new frmControls();
            controls.Show();
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            Form game = new frmGameForm();
            game.Show();
        }
    }
}
