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

namespace PrepandPaint
{
    public partial class JobInfo : Form
    {
        public List<PrepAndPaintModel> prepAndPaintModels;
        public JobsModel job;
        public int jobId;
        public bool adminLogin;
        public JobInfo()
        {
            InitializeComponent();
            GetInfo();
        }
        public JobInfo(JobsModel job)
        {
            InitializeComponent();
            this.job = job;
            checkBoxComplete.Checked = job.Completed;
            GetInfo();
            SetJobInfo();
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            jobInfoDataGrid.Columns[0].Visible = false;
            jobInfoDataGrid.Columns[2].Visible = false;
            ////jobInfoDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //jobInfoDataGrid.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ////jobInfoDataGrid.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //jobInfoDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            jobInfoDataGrid.Columns[1].HeaderText = "Line Item#";
            jobInfoDataGrid.Columns[3].HeaderText = "Items";
            jobInfoDataGrid.Columns[4].HeaderText = "Start Date";
            jobInfoDataGrid.Columns[6].HeaderText = "Paint Date";
            jobInfoDataGrid.Columns[10].HeaderText = "New-Process";
        }

        private void SetJobInfo()
        {
            jobNumberText.Text = job.JobNumber;
            customerText.Text = job.Customer;
            modelText.Text = job.Model;
        }

        private void GetInfo()
        {
            prepAndPaintModels = PrepAndPaintDB.GetJobLineItems(job.JobNumber);
            jobInfoDataGrid.DataSource = prepAndPaintModels;
            //SetDataGridView();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            CheckForAdmins();
            if (adminLogin)
            {
                DeleteEntry();
            }
            else
            {
                PassWord passWord = new PassWord();
                DialogResult result = passWord.ShowDialog();
                if (result == DialogResult.OK)
                {
                    adminLogin = true;
                    DeleteEntry();
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            CheckForAdmins();
            if (adminLogin)
            {
                EditJob();
            }
            else
            {
                PassWord passWord = new PassWord();
                DialogResult result = passWord.ShowDialog();
                if (result == DialogResult.OK)
                {
                    adminLogin = passWord.adminLogin;
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

        private void DeleteEntry()
        {
            if (jobInfoDataGrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = jobInfoDataGrid.SelectedCells[0].RowIndex;
                int Id = (int)jobInfoDataGrid.Rows[selectedRowIndex].Cells[0].Value;
                string jobNumber = jobInfoDataGrid.Rows[selectedRowIndex].Cells[2].Value.ToString();
                string item = jobInfoDataGrid.Rows[selectedRowIndex].Cells[3].Value.ToString();
                if (MessageBox.Show($"Are you sure you want to delete line Item {item} for Job# {jobNumber}", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PrepAndPaintModel deleteId = new PrepAndPaintModel()
                    {
                        Id = Id
                    };
                    PrepAndPaintDB.Delete(deleteId);

                    GetInfo();
                    //if (selectedRowIndex > 0)
                    //{
                    //    jobInfoDataGrid.Rows[selectedRowIndex - 1].Cells[1].Selected = true;
                    //}
                }
            }
            else
            {
                MessageBox.Show("Sorry you need to select an entry to delete!", "Error", MessageBoxButtons.OK);
            }
        }

        private void EditJob()
        {
            if (jobInfoDataGrid.SelectedRows.Count > 0)
            {
                // This checks for null value in colour cell.
                string colourValue;
                int selectedRowIndex = jobInfoDataGrid.SelectedCells[0].RowIndex;
                if (jobInfoDataGrid.Rows[selectedRowIndex].Cells[8].Value == null)
                {
                    colourValue = null;
                }
                else
                {
                    colourValue = jobInfoDataGrid.Rows[selectedRowIndex].Cells[9].Value.ToString();
                }


                PrepAndPaintModel editJob = new PrepAndPaintModel()
                {
                    Id = (int)jobInfoDataGrid.Rows[selectedRowIndex].Cells[0].Value,
                    ItemNumber = jobInfoDataGrid.Rows[selectedRowIndex].Cells[1].Value.ToString(),
                    JobNumber = jobInfoDataGrid.Rows[selectedRowIndex].Cells[2].Value.ToString(),
                    BodyOrDoors = jobInfoDataGrid.Rows[selectedRowIndex].Cells[3].Value.ToString(),
                    StartDate = jobInfoDataGrid.Rows[selectedRowIndex].Cells[4].Value.ToString(),
                    Prepper = jobInfoDataGrid.Rows[selectedRowIndex].Cells[5].Value.ToString(),
                    PaintDate = jobInfoDataGrid.Rows[selectedRowIndex].Cells[6].Value.ToString(),
                    Painter = jobInfoDataGrid.Rows[selectedRowIndex].Cells[7].Value.ToString(),
                    Booth = jobInfoDataGrid.Rows[selectedRowIndex].Cells[8].Value.ToString(),
                    Colour = colourValue,
                    NewProcess = (bool)jobInfoDataGrid.Rows[selectedRowIndex].Cells[10].Value,
                    WashBay = (bool)jobInfoDataGrid.Rows[selectedRowIndex].Cells[11].Value,
                    Comments = jobInfoDataGrid.Rows[selectedRowIndex].Cells[12].Value.ToString(),
                };
                AddJob addJob = new AddJob();
                addJob.editJob = editJob;
                addJob.edit = true;
                DialogResult results = addJob.ShowDialog();
                if (results == DialogResult.OK)
                {
                    GetInfo();
                    foreach (DataGridViewRow row in jobInfoDataGrid.Rows)
                    {
                        if (row.Cells[0].Value.Equals(editJob.Id))
                        {
                            row.Cells[1].Selected = true;
                            jobInfoDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record selected to edit!", "No Records selected");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            jobId = job.Id;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            CheckForAdmins();
            if (adminLogin)
            {
                AddItem();
            }
            else
            {
                PassWord passWord = new PassWord();
                DialogResult result = passWord.ShowDialog();
                if (result == DialogResult.OK)
                {
                    adminLogin = passWord.adminLogin;
                    AddItem();
                }

            }
        }

        private void AddItem()
        {
            AddJob addItem = new AddJob();
            addItem.edit = false;
            addItem.jobNumber = this.job.JobNumber;
            DialogResult result = addItem.ShowDialog();
            if (result == DialogResult.OK)
            {
                GetInfo();
            }
        }

        private void MarkJobCompleted(bool completed)
        {
            JobsModel editJob = new JobsModel()
            {
                Id = job.Id,
                JobNumber = job.JobNumber,
                Customer = job.Customer,
                Model = job.Model,
                Completed = completed
            };

            PrepAndPaintDB.EditJob(editJob);
        }

        private void BtnUnlockCompleteOption_Click(object sender, EventArgs e)
        {
            CheckForAdmins();
            if (adminLogin)
            {
                checkBoxComplete.Enabled = true;
            }
            else
            {
                PassWord passWord = new PassWord();
                DialogResult result = passWord.ShowDialog();
                if (result == DialogResult.OK)
                {
                    adminLogin = passWord.adminLogin;
                    checkBoxComplete.Enabled = true;
                }

            }
        }

        private void checkBoxComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxComplete.Checked)
            {
                MarkJobCompleted(true);
            }
            else
            {
                MarkJobCompleted(false);
            }
        }
    }
}
