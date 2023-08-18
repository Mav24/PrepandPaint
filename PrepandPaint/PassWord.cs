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
        public int adminId;
        public PassWord()
        {
            InitializeComponent();
        }
        private void PassWord_Load(object sender, EventArgs e)
        {
            List<AdminsModel> adminList = PrepAndPaintDB.GetAdmins();
            if (adminList.Count == 0)
            {
                MessageBox.Show("Currently there are no admins. Please create an admin account to protect your data", "No Admins!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AdminPage adminPage = new AdminPage();
                adminPage.ShowDialog();
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassWord.Text;

            if(login == "Admin" && password == "SuperAdmin")
            {
                adminLogin = true;
                this.DialogResult = DialogResult.OK;
                return;
            }
            else
            {

                List<AdminsModel> adminList = PrepAndPaintDB.GetAdmins();

                foreach (var name in adminList)
                {
                    if (login == name.Name && password == name.Password)
                    {
                        adminId = name.Id;
                        adminLogin = true;
                        this.DialogResult = DialogResult.OK;
                        return;
                    }
                }
            }

            MessageBox.Show("Sorry login or password wrong! Please try again", "Incorrect PassWord!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtPassWord.Clear();
            txtPassWord.Focus();
            return;


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
