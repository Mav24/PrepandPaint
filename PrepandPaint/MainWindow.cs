using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrepandPaint.Models;
using System.IO;
using OfficeOpenXml;

namespace PrepandPaint
{
    public partial class MainWindow : Form
    {
        List<PrepAndPaintModel> prepAndPaintModels;
        public bool AdminLogin;
        public MainWindow()
        {
            InitializeComponent();
            GetInfo();
        }

        private void GetInfo()
        {
            prepAndPaintModels = PrepAndPaintDB.GetNewData();
            dataGridView.DataSource = prepAndPaintModels;
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            dataGridView.Columns[0].Visible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[1].HeaderText = "Job#";
            dataGridView.Columns[2].HeaderText = "Item";
            dataGridView.Columns[3].HeaderText = "Start Date";
            dataGridView.Columns[5].HeaderText = "Paint Date";
            dataGridView.Columns[9].HeaderText = "New-Process";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CheckForAdmins();
            if (AdminLogin)
            {
                AddNewJob();
            }
            else
            {
                Login();
            }
        }

        private void AddNewJob()
        {
            AddJob addJob = new AddJob();
            DialogResult result = addJob.ShowDialog();

            if (result == DialogResult.OK)
            {
                GetInfo();
                txtSearch.Clear();
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[0].Value.Equals(addJob.jobId))
                    {
                        row.Cells[1].Selected = true;
                        dataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            CheckForAdmins();
            if (AdminLogin)
            {
                DeleteEntry();
            }
            else
            {
                PassWord passWord = new PassWord();
                DialogResult result = passWord.ShowDialog();
                if (result == DialogResult.OK)
                {
                    AdminLogin = true;
                    DeleteEntry();
                }
            }
        }

        private void DeleteEntry()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;
                int Id = (int)dataGridView.Rows[selectedRowIndex].Cells[0].Value;
                string job = dataGridView.Rows[selectedRowIndex].Cells[1].Value.ToString();
                if (MessageBox.Show($"Are you sure you want to delete job #{job}?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PrepAndPaintModel deleteId = new PrepAndPaintModel()
                    {
                        Id = Id
                    };
                    PrepAndPaintDB.Delete(deleteId);
                    GetInfo();
                    if (selectedRowIndex > 0)
                    {
                        dataGridView.Rows[selectedRowIndex - 1].Cells[1].Selected = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Sorry you need to select an entry to delete!", "Error", MessageBoxButtons.OK);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            CheckForAdmins();
            if (AdminLogin)
            {
                EditJob();
            }
            else
            {
                PassWord passWord = new PassWord();
                DialogResult result = passWord.ShowDialog();
                if (result == DialogResult.OK)
                {
                    AdminLogin = passWord.adminLogin;
                    EditJob();
                }
            }
        }
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckForAdmins();
            if (AdminLogin)
            {
                EditJob();
            }
            else
            {
                PassWord passWord = new PassWord();
                DialogResult result = passWord.ShowDialog();
                if (result == DialogResult.OK)
                {
                    AdminLogin = passWord.adminLogin;
                    EditJob();
                }
            }
        }

        private void CheckForAdmins()
        {
            List<AdminsModel> adminList = PrepAndPaintDB.GetAdmins();
            if (adminList.Count == 0)
            {
                MessageBox.Show("Currently there are no admins. Please create an admin account to protect your data", "No Admins!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AdminPage adminPage = new AdminPage();
                adminPage.ShowDialog();
            }
        }

        private void EditJob()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // This checks for null value in colour cell.
                string colourValue;
                int selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;
                if (dataGridView.Rows[selectedRowIndex].Cells[8].Value == null)
                {
                    colourValue = null;
                }
                else
                {
                    colourValue = dataGridView.Rows[selectedRowIndex].Cells[8].Value.ToString();
                }


                PrepAndPaintModel editJob = new PrepAndPaintModel()
                {
                    Id = (int)dataGridView.Rows[selectedRowIndex].Cells[0].Value,
                    JobNumber = dataGridView.Rows[selectedRowIndex].Cells[1].Value.ToString(),
                    BodyOrDoors = dataGridView.Rows[selectedRowIndex].Cells[2].Value.ToString(),
                    StartDate = dataGridView.Rows[selectedRowIndex].Cells[3].Value.ToString(),
                    Prepper = dataGridView.Rows[selectedRowIndex].Cells[4].Value.ToString(),
                    PaintDate = dataGridView.Rows[selectedRowIndex].Cells[5].Value.ToString(),
                    Painter = dataGridView.Rows[selectedRowIndex].Cells[6].Value.ToString(),
                    Booth = dataGridView.Rows[selectedRowIndex].Cells[7].Value.ToString(),
                    Colour = colourValue,
                    NewProcess = (bool)dataGridView.Rows[selectedRowIndex].Cells[9].Value,
                    WashBay = (bool)dataGridView.Rows[selectedRowIndex].Cells[10].Value,
                    Comments = dataGridView.Rows[selectedRowIndex].Cells[11].Value.ToString(),
                };
                AddJob addJob = new AddJob();
                addJob.editJob = editJob;
                addJob.edit = true;
                DialogResult results = addJob.ShowDialog();
                if (results == DialogResult.OK)
                {
                    GetInfo();
                    txtSearch.Clear();
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Cells[0].Value.Equals(editJob.Id))
                        {
                            row.Cells[1].Selected = true;
                            dataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record selected to edit!", "No Records selected");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Enter a job number to search!", "Noting To Search!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (rdoItem.Checked)
            {
                dataGridView.DataSource = PrepAndPaintDB.SearchItem(txtSearch.Text);
                if (dataGridView.Rows.Count <= 0)
                {
                    MessageBox.Show($"Nothing found with name {txtSearch.Text}", "Nothing found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SetDataGridView();
                }
                
            }
            else if (rdoJobNumber.Checked)
            {
               dataGridView.DataSource = PrepAndPaintDB.SearchJobNumber(txtSearch.Text);
                if (dataGridView.Rows.Count <= 0)
                {
                    MessageBox.Show($"Nothing found for Job# {txtSearch.Text}", "Nothing found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SetDataGridView();
                }
            }
            
        }

        private void BtnLoadAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            GetInfo();
        }

        private void BtnSupervisorNotes_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes();
            notes.ShowDialog();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                BtnSearch.PerformClick();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"For support email:\nmurrayduke@rogers.com\n\nIcons provided by:\n" +
                $"http://creativecommons.org/licenses/by-nd/3.0/", "Need Help?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnBackUpDataBase_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "PrepAndPaintDataBase_" + DateTime.Now.Date.ToString("MM-dd-yyyy");
            saveFileDialog1.Filter = "PrepAndPaint databases (*.db)|*.db";
            saveFileDialog1.ShowDialog();
            PrepAndPaintDB.BackUpDataBase(saveFileDialog1.FileName);
        }

        private void BtnRestoreDataBase_Click(object sender, EventArgs e)
        {
            PassWord passWord = new PassWord();
            DialogResult result = passWord.ShowDialog();
            if (result == DialogResult.OK)
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "PrepAndPaint databases (*.db)|*.db";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    PrepAndPaintDB.RestoreDataBase(openFileDialog1.FileName);
                    GetInfo();
                }
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void sortToolStripButton_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = PrepAndPaintDB.SortByDate();
            SetDataGridView();
            txtSearch.Clear();
        }

        private void toolStripAdminButton_Click(object sender, EventArgs e)
        {
            CheckForAdmins();
            PassWord passWord = new PassWord();
            DialogResult result = passWord.ShowDialog();
            if (result == DialogResult.OK)
            {
                AdminPage adminPage = new AdminPage();
                adminPage.ShowDialog();
            }

        }

        private void createJobToolStripButton_Click(object sender, EventArgs e)
        {
            CheckForAdmins();
            if (AdminLogin)
            {
                CreateNewJob();
            }
            else
            {
                PassWord password = new PassWord();
                DialogResult result = password.ShowDialog();
                if (result == DialogResult.OK)
                {
                    AdminLogin = password.adminLogin;
                    CreateNewJob();
                }
            }
        }

        private void Login()
        {
            PassWord password = new PassWord();
            DialogResult result = password.ShowDialog();
            if (result == DialogResult.OK)
            {
                AdminLogin = password.adminLogin;
                AddNewJob();
            }
        }

        private void CreateNewJob()
        {
            CreateJob createJob = new CreateJob();
            DialogResult result = createJob.ShowDialog();
            if (result == DialogResult.OK)
            {
                GetInfo();
                txtSearch.Clear();
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[0].Value.Equals(createJob.jobId))
                    {
                        row.Cells[1].Selected = true;
                        dataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }

        private void toolStripExportToExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var fileInfo = new FileInfo(saveFileDialog.FileName);
                        using (var package = new ExcelPackage(fileInfo))
                        {
                            ExcelWorksheet excelWorksheet = package.Workbook.Worksheets.Add("Paint");
                            excelWorksheet.Cells.LoadFromCollection<PrepAndPaintModel>(dataGridView.DataSource as List<PrepAndPaintModel>, true);
                            package.Save();
                        }
                        MessageBox.Show($"You have successfully exported your data to an excel file to {fileInfo}.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
