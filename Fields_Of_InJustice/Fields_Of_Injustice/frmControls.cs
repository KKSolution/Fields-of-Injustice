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
    public partial class frmControls : Form
    {
        public frmControls()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form moreControls = new frmMoreControls();
            moreControls.Show();
            this.Close();
        }
    }
}
