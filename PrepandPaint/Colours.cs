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
    public partial class Colours : Form
    {
        public Colours()
        {
            InitializeComponent();
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            colourDataGridView.DataSource = PrepAndPaintDB.GetJobColours();
            colourDataGridView.Columns[0].Visible = false;
            colourDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void BtnAddColour_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtColourCode.Text) && string.IsNullOrWhiteSpace(txtColour.Text))
            {
                MessageBox.Show("Please fill in all values!", "Error no value!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string colourAndCode = $"{txtColourCode.Text} - {txtColour.Text}";
                JobColours newJobColour = new JobColours()
                {
                    Colour = colourAndCode
                };
                List<JobColours> colours = PrepAndPaintDB.GetJobColours();
                foreach (var item in colours)
                {
                    if (item.Colour == newJobColour.Colour)
                    {
                        MessageBox.Show($" Colour: {newJobColour.Colour} already exist", "Exit already!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtColourCode.Focus();
                        return;
                    }
                }
                PrepAndPaintDB.AddColour(newJobColour);
                DialogResult = DialogResult.OK;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (colourDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = colourDataGridView.SelectedCells[0].RowIndex;
                int id = (int)colourDataGridView.Rows[selectedRowIndex].Cells[0].Value;
                string itemname = colourDataGridView.Rows[selectedRowIndex].Cells[1].Value.ToString();
                if (MessageBox.Show($"Are you sure you wanted to delete Item: {itemname}?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    JobColours deleteId = new JobColours()
                    {
                        Id = id
                    };
                    PrepAndPaintDB.DeleteColour(deleteId);
                    PopulateDataGrid();
                } 
            }
            else
            {
                MessageBox.Show("Sorry you need to select an entry to delete!", "Error", MessageBoxButtons.OK);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
