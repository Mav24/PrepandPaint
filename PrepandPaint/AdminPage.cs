using PrepandPaint.Models;
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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            adminDataGridView.DataSource = PrepAndPaintDB.GetAdmins();
            adminDataGridView.Columns[0].Visible = false;
            adminDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                AdminsModel newAdmin = new AdminsModel()
                {
                    Name = txtAdminName.Text,
                    Password = txtAdminPassWord.Text
                };
                List<AdminsModel> admins = PrepAndPaintDB.GetAdmins();
                foreach (var name in admins)
                {
                    if (name.Name == newAdmin.Name)
                    {
                        MessageBox.Show($"Name: {newAdmin.Name} already exist", "Exist Already!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAdminName.Focus();
                        return;
                    }
                }
                PrepAndPaintDB.AddAdmin(newAdmin);
                txtAdminName.Clear();
                txtAdminPassWord.Clear();
                PopulateDataGrid();
            }
        }

        private bool IsValidate()
        {
            return
                Validator.IsPresent(txtAdminName) &&
                Validator.IsPresent(txtAdminPassWord);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = adminDataGridView.SelectedCells[0].RowIndex;
                int id = (int)adminDataGridView.Rows[selectedRowIndex].Cells[0].Value;
                string itemname = adminDataGridView.Rows[selectedRowIndex].Cells[1].Value.ToString();
                if (MessageBox.Show($"Are you sure you want to delete Admin: {itemname}?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    AdminsModel deleteAdmin = new AdminsModel()
                    {
                        Id = id
                    };
                    PrepAndPaintDB.DeleteAdmin(deleteAdmin);
                    PopulateDataGrid();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing selected to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            List<AdminsModel> adminList = PrepAndPaintDB.GetAdmins();
            if (adminList.Count == 0)
            {
                MessageBox.Show("Currently there are no admins. Please create an admin account to protect your data", "No Admins!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Close();
            }
        }
    }
}
