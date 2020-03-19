using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepandPaint
{
    public partial class PassWord : Form
    {
        public PassWord()
        {
            InitializeComponent();
        }
        public string adminLogin = "123";

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (adminLogin == txtPassWord.Text)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Sorry password wrong! Please try again", "Incorrect PassWord!");
                txtPassWord.Clear();
                txtPassWord.Focus();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
