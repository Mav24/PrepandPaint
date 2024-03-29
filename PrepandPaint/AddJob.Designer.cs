﻿namespace PrepandPaint
{
    partial class AddJob
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJobNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrepper = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPainter = new System.Windows.Forms.TextBox();
            this.cmboBodyDoors = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmboBooth = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.checkNewProcess = new System.Windows.Forms.CheckBox();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.cmboColour = new System.Windows.Forms.ComboBox();
            this.BtnAddColour = new System.Windows.Forms.Button();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPaintDate = new System.Windows.Forms.DateTimePicker();
            this.checkWashBay = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Job #:";
            // 
            // txtJobNumber
            // 
            this.txtJobNumber.Location = new System.Drawing.Point(118, 24);
            this.txtJobNumber.Name = "txtJobNumber";
            this.txtJobNumber.Size = new System.Drawing.Size(366, 21);
            this.txtJobNumber.TabIndex = 1;
            this.txtJobNumber.Tag = "Job#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prepper:";
            // 
            // txtPrepper
            // 
            this.txtPrepper.Location = new System.Drawing.Point(117, 168);
            this.txtPrepper.Name = "txtPrepper";
            this.txtPrepper.Size = new System.Drawing.Size(367, 21);
            this.txtPrepper.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Paint Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Painter:";
            // 
            // txtPainter
            // 
            this.txtPainter.Location = new System.Drawing.Point(115, 255);
            this.txtPainter.Name = "txtPainter";
            this.txtPainter.Size = new System.Drawing.Size(369, 21);
            this.txtPainter.TabIndex = 13;
            // 
            // cmboBodyDoors
            // 
            this.cmboBodyDoors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBodyDoors.FormattingEnabled = true;
            this.cmboBodyDoors.IntegralHeight = false;
            this.cmboBodyDoors.ItemHeight = 15;
            this.cmboBodyDoors.Location = new System.Drawing.Point(116, 341);
            this.cmboBodyDoors.MaxDropDownItems = 10;
            this.cmboBodyDoors.Name = "cmboBodyDoors";
            this.cmboBodyDoors.Size = new System.Drawing.Size(369, 23);
            this.cmboBodyDoors.TabIndex = 17;
            this.cmboBodyDoors.Tag = "Item";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Item";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(377, 562);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 24;
            this.BtnSave.Text = "&Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(459, 562);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 25;
            this.BtnCancel.Text = "&Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Booth:";
            // 
            // cmboBooth
            // 
            this.cmboBooth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBooth.FormattingEnabled = true;
            this.cmboBooth.Items.AddRange(new object[] {
            "New",
            "Old"});
            this.cmboBooth.Location = new System.Drawing.Point(115, 296);
            this.cmboBooth.Name = "cmboBooth";
            this.cmboBooth.Size = new System.Drawing.Size(369, 23);
            this.cmboBooth.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Comments:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(115, 427);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(369, 114);
            this.txtComments.TabIndex = 23;
            // 
            // checkNewProcess
            // 
            this.checkNewProcess.AutoSize = true;
            this.checkNewProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNewProcess.Location = new System.Drawing.Point(119, 136);
            this.checkNewProcess.Name = "checkNewProcess";
            this.checkNewProcess.Size = new System.Drawing.Size(106, 20);
            this.checkNewProcess.TabIndex = 6;
            this.checkNewProcess.Text = "New Process";
            this.checkNewProcess.UseVisualStyleBackColor = true;
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.Image = global::PrepandPaint.Properties.Resources.Add_16x16;
            this.BtnAddItem.Location = new System.Drawing.Point(496, 340);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(38, 23);
            this.BtnAddItem.TabIndex = 18;
            this.BtnAddItem.UseVisualStyleBackColor = true;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            this.BtnAddItem.MouseHover += new System.EventHandler(this.BtnAddItem_MouseHover);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Colour:";
            // 
            // cmboColour
            // 
            this.cmboColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboColour.FormattingEnabled = true;
            this.cmboColour.IntegralHeight = false;
            this.cmboColour.Location = new System.Drawing.Point(116, 386);
            this.cmboColour.MaxDropDownItems = 10;
            this.cmboColour.Name = "cmboColour";
            this.cmboColour.Size = new System.Drawing.Size(368, 23);
            this.cmboColour.TabIndex = 20;
            this.cmboColour.Tag = "Colour";
            // 
            // BtnAddColour
            // 
            this.BtnAddColour.Image = global::PrepandPaint.Properties.Resources.Add_16x16;
            this.BtnAddColour.Location = new System.Drawing.Point(496, 386);
            this.BtnAddColour.Name = "BtnAddColour";
            this.BtnAddColour.Size = new System.Drawing.Size(38, 23);
            this.BtnAddColour.TabIndex = 21;
            this.BtnAddColour.UseVisualStyleBackColor = true;
            this.BtnAddColour.Click += new System.EventHandler(this.BtnAddColour_Click);
            this.BtnAddColour.MouseHover += new System.EventHandler(this.BtnAddColour_MouseHover);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Checked = false;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(119, 102);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.ShowCheckBox = true;
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(365, 21);
            this.dateTimePickerStartDate.TabIndex = 5;
            // 
            // dateTimePickerPaintDate
            // 
            this.dateTimePickerPaintDate.Checked = false;
            this.dateTimePickerPaintDate.Location = new System.Drawing.Point(118, 211);
            this.dateTimePickerPaintDate.Name = "dateTimePickerPaintDate";
            this.dateTimePickerPaintDate.ShowCheckBox = true;
            this.dateTimePickerPaintDate.Size = new System.Drawing.Size(367, 21);
            this.dateTimePickerPaintDate.TabIndex = 11;
            // 
            // checkWashBay
            // 
            this.checkWashBay.AutoSize = true;
            this.checkWashBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkWashBay.Location = new System.Drawing.Point(281, 136);
            this.checkWashBay.Name = "checkWashBay";
            this.checkWashBay.Size = new System.Drawing.Size(88, 20);
            this.checkWashBay.TabIndex = 7;
            this.checkWashBay.Text = "Wash Bay";
            this.checkWashBay.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Customer:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(117, 62);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(366, 21);
            this.txtCustomer.TabIndex = 3;
            this.txtCustomer.Tag = "Job#";
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 614);
            this.Controls.Add(this.dateTimePickerPaintDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnAddColour);
            this.Controls.Add(this.BtnAddItem);
            this.Controls.Add(this.checkWashBay);
            this.Controls.Add(this.checkNewProcess);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.cmboBooth);
            this.Controls.Add(this.cmboColour);
            this.Controls.Add(this.cmboBodyDoors);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtPainter);
            this.Controls.Add(this.txtPrepper);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtJobNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddJob";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit";
            this.Load += new System.EventHandler(this.AddJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJobNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrepper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPainter;
        private System.Windows.Forms.ComboBox cmboBodyDoors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmboBooth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.CheckBox checkNewProcess;
        private System.Windows.Forms.Button BtnAddItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmboColour;
        private System.Windows.Forms.Button BtnAddColour;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaintDate;
        private System.Windows.Forms.CheckBox checkWashBay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustomer;
    }
}