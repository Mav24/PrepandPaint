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

namespace PrepandPaint
{
    public partial class MainWindow : Form
    {
        List<PrepAndPaint> prepAndPaintList;
        public MainWindow()
        {
            InitializeComponent();
            GetInfo();
        }

        private void GetInfo()
        {
            using (SQLiteConnection connection = new SQLiteConnection(PrepAndPaintDB.databasePath))
            {
                connection.CreateTable<PrepAndPaint>();
                prepAndPaintList = connection.Table<PrepAndPaint>().ToList();
                dataGridView.DataSource = prepAndPaintList.OrderBy(x=>x.JobNumber).ToList();
                dataGridView.Columns[0].Visible = false;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddJob addJob = new AddJob();
            addJob.ShowDialog();
            GetInfo();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;
                int Id = (int)dataGridView.Rows[selectedRowIndex].Cells[0].Value;
                string job = dataGridView.Rows[selectedRowIndex].Cells[1].Value.ToString();
                if (MessageBox.Show($"Are you sure you want to delete job #{job}?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    

                    using (SQLiteConnection connection = new SQLiteConnection(PrepAndPaintDB.databasePath))
                    {
                        PrepAndPaint deleteId = new PrepAndPaint()
                        {
                            Id = Id
                        };
                        connection.Delete(deleteId);
                    }
                }
                GetInfo();
                int rowIndex = dataGridView.Rows.Count - 1;
                dataGridView.Rows[rowIndex].Cells[1].Selected = true;
            }
            else
            {
                MessageBox.Show("Sorry you need to select an entry to delete!", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;
                PrepAndPaint editJob = new PrepAndPaint()
                {
                    Id = (int)dataGridView.Rows[selectedRowIndex].Cells[0].Value,
                    JobNumber = dataGridView.Rows[selectedRowIndex].Cells[1].Value.ToString(),
                    StartDate = DateTime.Parse(dataGridView.Rows[selectedRowIndex].Cells[2].Value.ToString()),
                    Prepper = dataGridView.Rows[selectedRowIndex].Cells[3].Value.ToString(),
                    PaintDate = DateTime.Parse(dataGridView.Rows[selectedRowIndex].Cells[4].Value.ToString()),
                    Painter = dataGridView.Rows[selectedRowIndex].Cells[5].Value.ToString(),
                    BodyOrDoors = dataGridView.Rows[selectedRowIndex].Cells[6].Value.ToString(),
                    Booth = dataGridView.Rows[selectedRowIndex].Cells[7].Value.ToString(),
                    Comments = dataGridView.Rows[selectedRowIndex].Cells[8].Value.ToString(),
                };
                AddJob addJob = new AddJob();
                addJob.editJob = editJob;
                addJob.edit = true;
                DialogResult result = addJob.ShowDialog();
                if (result == DialogResult.OK)
                {
                    GetInfo();
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Cells[0].Value.Equals(editJob.Id))
                        {
                            row.Cells[2].Selected = true;
                        }
                    }
                }
                GetInfo();
                dataGridView.Rows[selectedRowIndex].Cells[1].Selected = true;
            }
            else
            {
                MessageBox.Show("No Record selected to edit!", "No Records selected");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(PrepAndPaintDB.databasePath))
            {
                List<PrepAndPaint> search = connection.Table<PrepAndPaint>().ToList();
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("You didn't enter a job number", "Error!");
                    txtSearch.Focus();
                }
                else
                {
                    dataGridView.DataSource = search.Where(x => x.JobNumber.Contains(txtSearch.Text)).ToList();
                }
            }
        }

        private void BtnLoadAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            GetInfo();
        }
    }
}
