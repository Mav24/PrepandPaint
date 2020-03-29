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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddNotes addNotes = new AddNotes();
            DialogResult result = addNotes.ShowDialog();

            if (result == DialogResult.OK)
            {
                GetInfo();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.Equals(addNotes.noteId))
                    {
                        row.Cells[1].Selected = true;
                    }
                }
            }
        }

        private void GetInfo()
        {
            dataGridView1.DataSource = SupervisorNotesDB.GetInfo();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                int Id = (int)dataGridView1.Rows[selectedRowIndex].Cells[0].Value;
                if (MessageBox.Show("Are you sure you wanted to delete this entry?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SupervisorNotes deleteId = new SupervisorNotes()
                    {
                        Id = Id
                    };
                    SupervisorNotesDB.Delete(deleteId);
                }
                GetInfo();
            }
            else
            {
                MessageBox.Show("Sorry you need to select an entry to delete!", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
