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
        public PrepAndPaintModel editJob;
        public bool edit;
        public int jobId;
        public AddJob()
        {
            InitializeComponent();
            GetItemList();
            GetColours();
        }

        private void AddJob_Load(object sender, EventArgs e)
        {
            if (edit)
            {
                Text = $"Edit Job {editJob.JobNumber}";
                FillTextBoxes();
            }
            else
            {
                cmboBodyDoors.SelectedIndex = -1;
                cmboColour.SelectedIndex = -1;
            }
            
        }

        private void FillTextBoxes()
        {
            txtJobNumber.Text = editJob.JobNumber;
            maskStartDate.Text = editJob.StartDate;
            txtPrepper.Text = editJob.Prepper;
            maskPaintDate.Text = editJob.PaintDate;
            txtPainter.Text = editJob.Painter;
            cmboBodyDoors.Text = editJob.BodyOrDoors;
            cmboBooth.SelectedItem = editJob.Booth;
            cmboColour.Text = editJob.Colour;
            checkNewProcess.Checked = editJob.NewProcess;
            txtComments.Text = editJob.Comments;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                if (edit)
                {
                    PrepAndPaintModel edited = new PrepAndPaintModel()
                    {
                        Id = editJob.Id,
                        StartDate = maskStartDate.Text,
                        JobNumber = txtJobNumber.Text,
                        Prepper = txtPrepper.Text,
                        PaintDate = maskPaintDate.Text,
                        Painter = txtPainter.Text,
                        BodyOrDoors = cmboBodyDoors.Text,
                        Booth = cmboBooth.Text,
                        Colour = cmboColour.Text,
                        NewProcess = checkNewProcess.Checked,
                        Comments = txtComments.Text
                    };
                    PrepAndPaintDB.EditnewJob(edited);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    List<PrepAndPaintModel> prepAndPaintModels = PrepAndPaintDB.GetNewData();
                    PrepAndPaintModel newJob = new PrepAndPaintModel()
                    {
                        StartDate = maskStartDate.Text,
                        JobNumber = txtJobNumber.Text,
                        Prepper = txtPrepper.Text,
                        PaintDate = maskPaintDate.Text,
                        Painter = txtPainter.Text,
                        BodyOrDoors = cmboBodyDoors.Text,
                        Booth = cmboBooth.Text,
                        Colour = cmboColour.Text,
                        NewProcess = checkNewProcess.Checked,
                        Comments = txtComments.Text
                    };
                    foreach (var item in prepAndPaintModels)
                    {
                        if (item.JobNumber == newJob.JobNumber && item.BodyOrDoors == newJob.BodyOrDoors)
                        {
                            MessageBox.Show($"Item: {newJob.BodyOrDoors} already exist for Job# {newJob.JobNumber} in the database!",
                            "Entry Exist!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    PrepAndPaintDB.AddnewJob(newJob);
                    jobId = newJob.Id;
                    DialogResult = DialogResult.OK;
                    Close();

                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsValidate()
        {
            return
                Validator.IsPresent(txtJobNumber);
                //Validator.DateFormat(maskStartDate);
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            AddItem addNewItem = new AddItem();
            DialogResult result = addNewItem.ShowDialog();
            if (result == DialogResult.OK)
            {
                GetItemList();
                cmboBodyDoors.SelectedIndex = -1;
            }
        }

        private void GetItemList()
        {
            cmboBodyDoors.DisplayMember = "ItemName";
            cmboBodyDoors.DataSource = PrepAndPaintDB.GetItemsList();
        }

        private void GetColours()
        {
            cmboColour.DisplayMember = "Colour";
            cmboColour.DataSource = PrepAndPaintDB.GetJobColours();
        }

        private void BtnAddItem_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Add new item!", BtnAddItem);
        }

        private void BtnAddColour_Click(object sender, EventArgs e)
        {
            AddColours addJobColour = new AddColours();
            DialogResult result = addJobColour.ShowDialog();
            if (result == DialogResult.OK)
            {
                GetColours();
                cmboColour.SelectedIndex = -1;
            }
        }
    }
}
