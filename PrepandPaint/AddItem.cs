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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void BtnAddNewItem_Click(object sender, EventArgs e)
        {
            ItemsModel item = new ItemsModel()
            {
                ItemName = txtItemName.Text
            };
            PrepAndPaintDB.AddItem(item);
            DialogResult = DialogResult.OK;
        }
    }
}
