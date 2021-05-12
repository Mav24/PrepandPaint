
namespace PrepandPaint
{
    partial class CreateJob
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJobNumber = new System.Windows.Forms.TextBox();
            this.cmboColour = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.BtnAddColour = new System.Windows.Forms.Button();
            this.checkNewProcess = new System.Windows.Forms.CheckBox();
            this.checkBoxWashBay = new System.Windows.Forms.CheckBox();
            this.AddItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Job #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Items To Create:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Colour:";
            // 
            // txtJobNumber
            // 
            this.txtJobNumber.Location = new System.Drawing.Point(54, 22);
            this.txtJobNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJobNumber.Name = "txtJobNumber";
            this.txtJobNumber.Size = new System.Drawing.Size(208, 21);
            this.txtJobNumber.TabIndex = 1;
            // 
            // cmboColour
            // 
            this.cmboColour.FormattingEnabled = true;
            this.cmboColour.IntegralHeight = false;
            this.cmboColour.ItemHeight = 15;
            this.cmboColour.Location = new System.Drawing.Point(60, 234);
            this.cmboColour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmboColour.MaxDropDownItems = 10;
            this.cmboColour.Name = "cmboColour";
            this.cmboColour.Size = new System.Drawing.Size(202, 23);
            this.cmboColour.TabIndex = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(227, 270);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(65, 25);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "C&reate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(158, 270);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 25);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 15;
            this.itemsListBox.Location = new System.Drawing.Point(54, 102);
            this.itemsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.itemsListBox.Size = new System.Drawing.Size(208, 109);
            this.itemsListBox.TabIndex = 4;
            this.itemsListBox.Tag = "Item";
            // 
            // BtnAddColour
            // 
            this.BtnAddColour.Image = global::PrepandPaint.Properties.Resources.Add_16x16;
            this.BtnAddColour.Location = new System.Drawing.Point(266, 234);
            this.BtnAddColour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAddColour.Name = "BtnAddColour";
            this.BtnAddColour.Size = new System.Drawing.Size(26, 21);
            this.BtnAddColour.TabIndex = 7;
            this.BtnAddColour.UseVisualStyleBackColor = true;
            this.BtnAddColour.Click += new System.EventHandler(this.BtnAddColour_Click);
            // 
            // checkNewProcess
            // 
            this.checkNewProcess.AutoSize = true;
            this.checkNewProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNewProcess.Location = new System.Drawing.Point(54, 52);
            this.checkNewProcess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkNewProcess.Name = "checkNewProcess";
            this.checkNewProcess.Size = new System.Drawing.Size(107, 20);
            this.checkNewProcess.TabIndex = 2;
            this.checkNewProcess.Text = "&New Process";
            this.checkNewProcess.UseVisualStyleBackColor = true;
            // 
            // checkBoxWashBay
            // 
            this.checkBoxWashBay.AutoSize = true;
            this.checkBoxWashBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWashBay.Location = new System.Drawing.Point(162, 52);
            this.checkBoxWashBay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxWashBay.Name = "checkBoxWashBay";
            this.checkBoxWashBay.Size = new System.Drawing.Size(89, 20);
            this.checkBoxWashBay.TabIndex = 2;
            this.checkBoxWashBay.Text = "&Wash Bay";
            this.checkBoxWashBay.UseVisualStyleBackColor = true;
            // 
            // AddItem
            // 
            this.AddItem.Image = global::PrepandPaint.Properties.Resources.Add_16x16;
            this.AddItem.Location = new System.Drawing.Point(266, 102);
            this.AddItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(26, 21);
            this.AddItem.TabIndex = 7;
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // CreateJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 316);
            this.Controls.Add(this.checkBoxWashBay);
            this.Controls.Add(this.checkNewProcess);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.BtnAddColour);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmboColour);
            this.Controls.Add(this.txtJobNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateJob";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Job";
            this.Load += new System.EventHandler(this.CreateJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJobNumber;
        private System.Windows.Forms.ComboBox cmboColour;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Button BtnAddColour;
        private System.Windows.Forms.CheckBox checkNewProcess;
        private System.Windows.Forms.CheckBox checkBoxWashBay;
        private System.Windows.Forms.Button AddItem;
    }
}