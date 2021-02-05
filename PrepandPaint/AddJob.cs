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
        string startDate;
        string paintDate;
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
            try
            {
                txtJobNumber.Text = editJob.JobNumber;
                if (editJob.StartDate == "")
                {
                    dateTimePickerStartDate.Value = DateTime.Now;
                    dateTimePickerStartDate.Checked = false;
                }
                else
                {
                    dateTimePickerStartDate.Value = DateTime.Parse(editJob.StartDate);
                }
                txtPrepper.Text = editJob.Prepper;
                if (editJob.PaintDate == "")
                {
                    dateTimePickerPaintDate.Value = DateTime.Now;
                    dateTimePickerPaintDate.Checked = false;
                }
                else
                {
                    dateTimePickerPaintDate.Value = DateTime.Parse(editJob.PaintDate);
                }
                txtPainter.Text = editJob.Painter;
                cmboBodyDoors.Text = editJob.BodyOrDoors;
                cmboBooth.SelectedItem = editJob.Booth;
                cmboColour.Text = editJob.Colour;
                checkNewProcess.Checked = editJob.NewProcess;
                checkWashBay.Checked = editJob.WashBay;
                txtComments.Text = editJob.Comments;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                if (edit)
                {
                    CheckStartDate();
                    CheckPaintDate();
                    PrepAndPaintModel edited = new PrepAndPaintModel()
                    {
                        Id = editJob.Id,
                        StartDate = startDate,
                        JobNumber = txtJobNumber.Text,
                        Prepper = txtPrepper.Text,
                        PaintDate = paintDate,
                        Painter = txtPainter.Text,
                        BodyOrDoors = cmboBodyDoors.Text,
                        Booth = cmboBooth.Text,
                        Colour = cmboColour.Text,
                        NewProcess = checkNewProcess.Checked,
                        WashBay = checkWashBay.Checked,
                        Comments = txtComments.Text
                    };
                    PrepAndPaintDB.EditnewJob(edited);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    CheckStartDate();
                    CheckPaintDate();
                    PrepAndPaintModel newJob = new PrepAndPaintModel()
                    {
                        StartDate = startDate,
                        JobNumber = txtJobNumber.Text,
                        Prepper = txtPrepper.Text,
                        PaintDate = paintDate,
                        Painter = txtPainter.Text,
                        BodyOrDoors = cmboBodyDoors.Text,
                        Booth = cmboBooth.Text,
                        Colour = cmboColour.Text,
                        NewProcess = checkNewProcess.Checked,
                        WashBay = checkWashBay.Checked,
                        Comments = txtComments.Text
                    };

                    CheckIfExist(newJob);

                }
            }
        }

        private void CheckPaintDate()
        {

            if (dateTimePickerPaintDate.Checked)
            {
                paintDate = dateTimePickerPaintDate.Value.ToShortDateString();
            }
            else
            {
                paintDate = "";
            }
        }

        private void CheckStartDate()
        {
            if (dateTimePickerStartDate.Checked)
            {
                startDate = dateTimePickerStartDate.Value.ToShortDateString();
            }
            else
            {
                startDate = "";
            }
        }

        private void CheckIfExist(PrepAndPaintModel newJob)
        {
            List<PrepAndPaintModel> prepAndPaintModels = PrepAndPaintDB.GetNewData();
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsValidate()
        {
            return
                Validator.IsPresent(txtJobNumber) &&
                Validator.ComboBoxItemSelected(cmboBodyDoors) &&
                Validator.ComboBoxItemSelected(cmboColour);
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            AddItem addNewItem = new AddItem();
            DialogResult result = addNewItem.ShowDialog();
            if (result == DialogResult.OK)
            {
                GetItemList();
                cmboBodyDoors.Text = addNewItem.itemName;
            }
            else if (result == DialogResult.Cancel)
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
            cmboColour.SelectedIndex = -1;
        }

        private void BtnAddColour_Click(object sender, EventArgs e)
        {
            AddColours addJobColour = new AddColours();
            DialogResult result = addJobColour.ShowDialog();
            if (result == DialogResult.OK)
            {
                GetColours();
                cmboColour.Text = addJobColour.colourName;
            }
            else if (result == DialogResult.Cancel)
            {
                GetColours();
                cmboColour.SelectedIndex = -1;
            }
        }

        private void BtnAddColour_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Add new Colour!", BtnAddColour);
        }
        private void BtnAddItem_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Add new item!", BtnAddItem);
        }
    }
}
