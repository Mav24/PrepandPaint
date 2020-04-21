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

namespace PrepandPaint
{
    public partial class MainWindow : Form
    {
        List<PrepAndPaintModel> prepAndPaintModels;
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
            dataGridView.Columns[0].Visible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[1].HeaderText = "Job#";
            dataGridView.Columns[2].HeaderText = "Item";
            dataGridView.Columns[3].HeaderText = "Start Date";
            dataGridView.Columns[5].HeaderText = "Paint Date";
            dataGridView.Columns[8].HeaderText = "New-Process";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
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
            PassWord passWord = new PassWord();
            DialogResult result = passWord.ShowDialog();
            if (result == DialogResult.OK)
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
            

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            PassWord passWord = new PassWord();
            DialogResult result = passWord.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;
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
                        NewProcess = (bool)dataGridView.Rows[selectedRowIndex].Cells[8].Value,
                        Comments = dataGridView.Rows[selectedRowIndex].Cells[9].Value.ToString(),
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
            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                dataGridView.DataSource = PrepAndPaintDB.Search(txtSearch.Text);
                SetDataGridView();
            }
            else
            {
                MessageBox.Show("Enter a job number to search!", "Noting To Search!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            saveFileDialog1.FileName = "mainlog";
            saveFileDialog1.Filter = "Data base format (*.db)|*.db";
            saveFileDialog1.ShowDialog();
            PrepAndPaintDB.BackUpDataBase(saveFileDialog1.FileName);
        }

        private void BtnRestoreDataBase_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Database format (*.db)|*.db";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PrepAndPaintDB.RestoreDataBase(openFileDialog1.FileName);
                GetInfo();
            }

        }
    }
}
