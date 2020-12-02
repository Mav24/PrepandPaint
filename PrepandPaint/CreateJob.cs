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
    public partial class CreateJob : Form
    {
        public int jobId;
        public CreateJob()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                var selectedItems = itemsListBox.SelectedItems;
                foreach (var item in selectedItems)
                {
                    PrepAndPaintModel newJob = new PrepAndPaintModel()
                    {
                        JobNumber = txtJobNumber.Text,
                        StartDate = "",
                        Prepper = "",
                        PaintDate = "",
                        Painter = "",
                        BodyOrDoors = item.ToString(),
                        Booth = "",
                        Colour = cmboColour.Text,
                        Comments = "",
                        NewProcess = checkNewProcess.Checked
                    };

                    CheckIfExist(newJob);
                }
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

        private void CreateJob_Load(object sender, EventArgs e)
        {
            GetItemInfo();
            GetColours();
        }

        private void GetItemInfo()
        {
            List<ItemsModel> list = PrepAndPaintDB.GetItemsList();
            foreach (var item in list)
            {
                itemsListBox.Items.Add(item.ItemName);
            }
        }

        private void GetColours()
        {
            cmboColour.DisplayMember = "Colour";
            cmboColour.DataSource = PrepAndPaintDB.GetJobColours();
            cmboColour.SelectedIndex = -1;
        }

        private bool IsValidate()
        {
            return
                Validator.IsPresent(txtJobNumber) &&
                Validator.ItemSelectionBox(itemsListBox);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
