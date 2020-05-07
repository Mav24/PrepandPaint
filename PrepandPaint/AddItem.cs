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
        List<ItemsModel> itemsList;
        public AddItem()
        {
            InitializeComponent();
            PopulateListView();
        }

        private void PopulateListView()
        {
            itemDataGridView.DataSource = PrepAndPaintDB.GetItemsList();
            itemDataGridView.Columns[0].Visible = false;
            
        }

        private void BtnAddNewItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                char[] a = txtItemName.Text.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                ItemsModel newItem = new ItemsModel()
                {
                    ItemName = new string(a)
                };
                itemsList = PrepAndPaintDB.GetItemsList();
                foreach (var item in itemsList)
                {
                    if (item.ItemName == newItem.ItemName)
                    {
                        MessageBox.Show($" Item: {newItem.ItemName} already exist", "Exit already!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtItemName.Focus();
                        return;
                    }
                }
                PrepAndPaintDB.AddItem(newItem);
                DialogResult = DialogResult.OK;
            }
            MessageBox.Show("Please enter an item in the text box!", "Error no value!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = itemDataGridView.SelectedCells[0].RowIndex;
            int id = (int)itemDataGridView.Rows[selectedRowIndex].Cells[0].Value;
            string itemname = itemDataGridView.Rows[selectedRowIndex].Cells[1].Value.ToString();
            if (MessageBox.Show($"Are you sure you wanted to delete Item: {itemname}?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ItemsModel deleteId = new ItemsModel()
                {
                    Id = id
                };
                PrepAndPaintDB.DeleteItem(deleteId);
                PopulateListView();
            }

        }
    }
}
