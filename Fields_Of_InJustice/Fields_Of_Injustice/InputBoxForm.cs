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
    public partial class InputBoxForm : Form
    {
        public string text;

        public InputBoxForm()
        {
            InitializeComponent();
        }

        private void InputBoxForm_Load(object sender, EventArgs e)
        {
            txtText.Text = "";
            txtText.Focus();
        }

        public void show(string promptText)
        {
            lblPrompt.Text = promptText;
            this.ShowDialog();
        }

        public void setBtn(string OK, string Cancel)
        {
            btnSubmit.Text = OK;
            btnCancel.Text = Cancel;
        }

        void getNum()
        {
            text = txtText.Text;
            txtText.Text = "";
            txtText.Focus();
        }

        private void txtOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getNum();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            getNum();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtText.Focus();
            DialogResult = DialogResult.Cancel;
        }



    }
}
