namespace PrepandPaint
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
            this.maskStartDate = new System.Windows.Forms.MaskedTextBox();
            this.maskPaintDate = new System.Windows.Forms.MaskedTextBox();
            this.checkNewProcess = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Job #:";
            // 
            // txtJobNumber
            // 
            this.txtJobNumber.Location = new System.Drawing.Point(118, 24);
            this.txtJobNumber.Name = "txtJobNumber";
            this.txtJobNumber.Size = new System.Drawing.Size(239, 21);
            this.txtJobNumber.TabIndex = 2;
            this.txtJobNumber.Tag = "Job#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prepper:";
            // 
            // txtPrepper
            // 
            this.txtPrepper.Location = new System.Drawing.Point(118, 130);
            this.txtPrepper.Name = "txtPrepper";
            this.txtPrepper.Size = new System.Drawing.Size(239, 21);
            this.txtPrepper.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Paint Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Painter:";
            // 
            // txtPainter
            // 
            this.txtPainter.Location = new System.Drawing.Point(118, 217);
            this.txtPainter.Name = "txtPainter";
            this.txtPainter.Size = new System.Drawing.Size(238, 21);
            this.txtPainter.TabIndex = 11;
            // 
            // cmboBodyDoors
            // 
            this.cmboBodyDoors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBodyDoors.FormattingEnabled = true;
            this.cmboBodyDoors.Items.AddRange(new object[] {
            "Doors",
            "Body",
            "Parts"});
            this.cmboBodyDoors.Location = new System.Drawing.Point(118, 259);
            this.cmboBodyDoors.Name = "cmboBodyDoors";
            this.cmboBodyDoors.Size = new System.Drawing.Size(238, 23);
            this.cmboBodyDoors.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Item";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(197, 449);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 18;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(278, 449);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 19;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 301);
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
            this.cmboBooth.Location = new System.Drawing.Point(119, 301);
            this.cmboBooth.Name = "cmboBooth";
            this.cmboBooth.Size = new System.Drawing.Size(238, 23);
            this.cmboBooth.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Comments:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(118, 350);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(238, 78);
            this.txtComments.TabIndex = 17;
            // 
            // maskStartDate
            // 
            this.maskStartDate.Location = new System.Drawing.Point(119, 66);
            this.maskStartDate.Mask = "00/00/0000";
            this.maskStartDate.Name = "maskStartDate";
            this.maskStartDate.Size = new System.Drawing.Size(120, 21);
            this.maskStartDate.TabIndex = 4;
            this.maskStartDate.Tag = "Start Date";
            this.maskStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskPaintDate
            // 
            this.maskPaintDate.Location = new System.Drawing.Point(119, 174);
            this.maskPaintDate.Mask = "00/00/0000";
            this.maskPaintDate.Name = "maskPaintDate";
            this.maskPaintDate.Size = new System.Drawing.Size(120, 21);
            this.maskPaintDate.TabIndex = 9;
            this.maskPaintDate.Tag = "Paint Date";
            this.maskPaintDate.ValidatingType = typeof(System.DateTime);
            // 
            // checkNewProcess
            // 
            this.checkNewProcess.AutoSize = true;
            this.checkNewProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNewProcess.Location = new System.Drawing.Point(119, 100);
            this.checkNewProcess.Name = "checkNewProcess";
            this.checkNewProcess.Size = new System.Drawing.Size(120, 24);
            this.checkNewProcess.TabIndex = 5;
            this.checkNewProcess.Text = "New Process";
            this.checkNewProcess.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(255, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "dd/mm/yyyy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(255, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "dd/mm/yyyy";
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 489);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkNewProcess);
            this.Controls.Add(this.maskPaintDate);
            this.Controls.Add(this.maskStartDate);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.cmboBooth);
            this.Controls.Add(this.cmboBodyDoors);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtPainter);
            this.Controls.Add(this.txtPrepper);
            this.Controls.Add(this.txtJobNumber);
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
            this.Text = "Add Job";
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
        private System.Windows.Forms.MaskedTextBox maskStartDate;
        private System.Windows.Forms.MaskedTextBox maskPaintDate;
        private System.Windows.Forms.CheckBox checkNewProcess;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}