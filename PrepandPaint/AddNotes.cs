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
    public partial class AddNotes : Form
    {
        public SupervisorNotes editNotes;
        public int noteId;
        public bool edit;
        public AddNotes()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNotes.Text))
            {
                SupervisorNotes editSupervisorNotes = new SupervisorNotes()
                {
                    Date = dateTimePicker1.Value.Date,
                    Comments = txtNotes.Text
                };
                SupervisorNotesDB.Save(editSupervisorNotes);
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("You didn't enter anything", "Error");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNotes_Load(object sender, EventArgs e)
        {
        }
    }
}
