
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Job #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Items To Create:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Colour:";
            // 
            // txtJobNumber
            // 
            this.txtJobNumber.Location = new System.Drawing.Point(70, 29);
            this.txtJobNumber.Name = "txtJobNumber";
            this.txtJobNumber.Size = new System.Drawing.Size(266, 26);
            this.txtJobNumber.TabIndex = 1;
            // 
            // cmboColour
            // 
            this.cmboColour.FormattingEnabled = true;
            this.cmboColour.Location = new System.Drawing.Point(77, 312);
            this.cmboColour.Name = "cmboColour";
            this.cmboColour.Size = new System.Drawing.Size(259, 28);
            this.cmboColour.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(253, 360);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 28);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "C&reate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(164, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(70, 136);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.itemsListBox.Size = new System.Drawing.Size(266, 144);
            this.itemsListBox.TabIndex = 3;
            this.itemsListBox.Tag = "Item";
            // 
            // BtnAddColour
            // 
            this.BtnAddColour.Image = global::PrepandPaint.Properties.Resources.Add_16x16;
            this.BtnAddColour.Location = new System.Drawing.Point(342, 312);
            this.BtnAddColour.Name = "BtnAddColour";
            this.BtnAddColour.Size = new System.Drawing.Size(34, 28);
            this.BtnAddColour.TabIndex = 6;
            this.BtnAddColour.UseVisualStyleBackColor = true;
            this.BtnAddColour.Click += new System.EventHandler(this.BtnAddColour_Click);
            // 
            // checkNewProcess
            // 
            this.checkNewProcess.AutoSize = true;
            this.checkNewProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNewProcess.Location = new System.Drawing.Point(70, 70);
            this.checkNewProcess.Name = "checkNewProcess";
            this.checkNewProcess.Size = new System.Drawing.Size(120, 24);
            this.checkNewProcess.TabIndex = 1;
            this.checkNewProcess.Text = "&New Process";
            this.checkNewProcess.UseVisualStyleBackColor = true;
            // 
            // CreateJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 432);
            this.Controls.Add(this.checkNewProcess);
            this.Controls.Add(this.BtnAddColour);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmboColour);
            this.Controls.Add(this.txtJobNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}