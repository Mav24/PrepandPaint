using PrepandPaint.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepandPaint
{
    public partial class PassWord : Form
    {
        public bool adminLogin;
        public PassWord()
        {
            InitializeComponent();
        }
        //public string adminLogin = "Maverick";

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassWord.Text;
            List<AdminsModel> adminList = PrepAndPaintDB.GetAdmins();
            foreach (var name in adminList)
            {
                if (login == name.Name && password == name.Password)
                {
                    adminLogin = true;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Sorry password wrong! Please try again", "Incorrect PassWord!");
                    txtPassWord.Clear();
                    txtPassWord.Focus();
                    return;
                }
            }
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
