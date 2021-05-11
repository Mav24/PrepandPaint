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
    public partial class EditJob : Form
    {
        private JobsModel job;
        public bool adminLogin;
        public int jobId;

        public EditJob()
        {
            InitializeComponent();
        }

        public EditJob(JobsModel job)
        {
            InitializeComponent();
            this.job = job;
            Text = $"Edit Job# {job.JobNumber}";
            FillJobInfo();
        }

        private void FillJobInfo()
        {
            lblJobNumber.Text = job.JobNumber;
            txtCustomer.Text = job.Customer;
            txtModel.Text = job.Model;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            JobsModel edited = new JobsModel()
            {
                Id = job.Id,
                JobNumber = job.JobNumber,
                Customer = txtCustomer.Text,
                Model = txtModel.Text
            };
            PrepAndPaintDB.EditJob(edited);
            jobId = edited.Id;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
