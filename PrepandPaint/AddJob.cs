using PrepandPaint.Models;
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

namespace PrepandPaint
{
    public partial class AddJob : Form
    {
        public PrepAndPaint editJob;
        public bool edit;
        public int jobId;
        public AddJob()
        {
            InitializeComponent();
        }

        private void AddJob_Load(object sender, EventArgs e)
        {
            if (edit)
            {
                Text = $"Edit Job {editJob.JobNumber}";
                FillTextBoxes();
            }
        }


        private void FillTextBoxes()
        {
            txtJobNumber.Text = editJob.JobNumber;
            startDateTimePicker.Value = editJob.StartDate;
            txtPrepper.Text = editJob.Prepper;
            paintDateTimePicker.Value = editJob.PaintDate;
            txtPainter.Text = editJob.Painter;
            cmboBodyDoors.SelectedItem = editJob.BodyOrDoors;
            cmboBooth.SelectedItem = editJob.Booth;
            txtComments.Text = editJob.Comments;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                PrepAndPaint edited = new PrepAndPaint()
                {
                    Id = editJob.Id,
                    StartDate = startDateTimePicker.Value.Date,
                    JobNumber = txtJobNumber.Text,
                    Prepper = txtPrepper.Text,
                    PaintDate = paintDateTimePicker.Value.Date,
                    Painter = txtPainter.Text,
                    BodyOrDoors = cmboBodyDoors.Text,
                    Booth = cmboBooth.Text,
                    Comments = txtComments.Text
                };
                PrepAndPaintDB.EditJob(edited);
                Close();


            }
            else if (!string.IsNullOrWhiteSpace(txtJobNumber.Text))
            {
                PrepAndPaint newJob = new PrepAndPaint()
                {
                    StartDate = startDateTimePicker.Value.Date,
                    JobNumber = txtJobNumber.Text,
                    Prepper = txtPrepper.Text,
                    PaintDate = paintDateTimePicker.Value.Date,
                    Painter = txtPainter.Text,
                    BodyOrDoors = cmboBodyDoors.Text,
                    Booth = cmboBooth.Text,
                    Comments = txtComments.Text
                };
                PrepAndPaintDB.AddJob(newJob);
                jobId = newJob.Id;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("You need to fill in values!", "Error");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
