
namespace PrepandPaint
{
    partial class JobInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jobInfoLabel = new System.Windows.Forms.Label();
            this.jobNumberText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modelText = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BottonPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxComplete = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnUnlockCompleteOption = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.jobInfoDataGrid = new System.Windows.Forms.DataGridView();
            this.TopPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.BottonPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobInfoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.groupBox1);
            this.TopPanel.Controls.Add(this.BtnEdit);
            this.TopPanel.Controls.Add(this.BtnDelete);
            this.TopPanel.Controls.Add(this.BtnAddItem);
            this.TopPanel.Controls.Add(this.BtnExit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1244, 125);
            this.TopPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jobInfoLabel);
            this.groupBox1.Controls.Add(this.jobNumberText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.customerText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.modelText);
            this.groupBox1.Location = new System.Drawing.Point(20, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Job Info";
            // 
            // jobInfoLabel
            // 
            this.jobInfoLabel.AutoSize = true;
            this.jobInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobInfoLabel.Location = new System.Drawing.Point(6, 17);
            this.jobInfoLabel.Name = "jobInfoLabel";
            this.jobInfoLabel.Size = new System.Drawing.Size(40, 15);
            this.jobInfoLabel.TabIndex = 0;
            this.jobInfoLabel.Text = "Job #:";
            // 
            // jobNumberText
            // 
            this.jobNumberText.AutoSize = true;
            this.jobNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNumberText.Location = new System.Drawing.Point(79, 17);
            this.jobNumberText.Name = "jobNumberText";
            this.jobNumberText.Size = new System.Drawing.Size(41, 15);
            this.jobNumberText.TabIndex = 1;
            this.jobNumberText.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer:";
            // 
            // customerText
            // 
            this.customerText.AutoSize = true;
            this.customerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerText.Location = new System.Drawing.Point(79, 49);
            this.customerText.Name = "customerText";
            this.customerText.Size = new System.Drawing.Size(41, 15);
            this.customerText.TabIndex = 3;
            this.customerText.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model:";
            // 
            // modelText
            // 
            this.modelText.AutoSize = true;
            this.modelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelText.Location = new System.Drawing.Point(79, 80);
            this.modelText.Name = "modelText";
            this.modelText.Size = new System.Drawing.Size(41, 15);
            this.modelText.TabIndex = 5;
            this.modelText.Text = "label3";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Location = new System.Drawing.Point(1025, 79);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(87, 27);
            this.BtnEdit.TabIndex = 10;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(1135, 79);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(87, 27);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddItem.Location = new System.Drawing.Point(916, 79);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(87, 27);
            this.BtnAddItem.TabIndex = 9;
            this.BtnAddItem.Text = "Add Item";
            this.BtnAddItem.UseVisualStyleBackColor = true;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Location = new System.Drawing.Point(1135, 22);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(87, 27);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BottonPanel
            // 
            this.BottonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottonPanel.Controls.Add(this.groupBox2);
            this.BottonPanel.Controls.Add(this.label4);
            this.BottonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottonPanel.Location = new System.Drawing.Point(0, 503);
            this.BottonPanel.Name = "BottonPanel";
            this.BottonPanel.Size = new System.Drawing.Size(1244, 44);
            this.BottonPanel.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxComplete);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BtnUnlockCompleteOption);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(895, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 42);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // checkBoxComplete
            // 
            this.checkBoxComplete.AutoSize = true;
            this.checkBoxComplete.Enabled = false;
            this.checkBoxComplete.Location = new System.Drawing.Point(241, 17);
            this.checkBoxComplete.Name = "checkBoxComplete";
            this.checkBoxComplete.Size = new System.Drawing.Size(86, 19);
            this.checkBoxComplete.TabIndex = 2;
            this.checkBoxComplete.Text = "Completed";
            this.checkBoxComplete.UseVisualStyleBackColor = true;
            this.checkBoxComplete.CheckedChanged += new System.EventHandler(this.checkBoxComplete_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "All Items are completed";
            // 
            // BtnUnlockCompleteOption
            // 
            this.BtnUnlockCompleteOption.Location = new System.Drawing.Point(147, 12);
            this.BtnUnlockCompleteOption.Name = "BtnUnlockCompleteOption";
            this.BtnUnlockCompleteOption.Size = new System.Drawing.Size(87, 27);
            this.BtnUnlockCompleteOption.TabIndex = 0;
            this.BtnUnlockCompleteOption.Text = "Admin Login";
            this.BtnUnlockCompleteOption.UseVisualStyleBackColor = true;
            this.BtnUnlockCompleteOption.Click += new System.EventHandler(this.BtnUnlockCompleteOption_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "* Line Items are items charged to one Job Number";
            // 
            // LeftPanel
            // 
            this.LeftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 125);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(21, 378);
            this.LeftPanel.TabIndex = 2;
            // 
            // RightPanel
            // 
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(1223, 125);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(21, 378);
            this.RightPanel.TabIndex = 3;
            // 
            // jobInfoDataGrid
            // 
            this.jobInfoDataGrid.AllowUserToAddRows = false;
            this.jobInfoDataGrid.AllowUserToDeleteRows = false;
            this.jobInfoDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.jobInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobInfoDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobInfoDataGrid.GridColor = System.Drawing.Color.Blue;
            this.jobInfoDataGrid.Location = new System.Drawing.Point(21, 125);
            this.jobInfoDataGrid.Name = "jobInfoDataGrid";
            this.jobInfoDataGrid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobInfoDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.jobInfoDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobInfoDataGrid.Size = new System.Drawing.Size(1202, 378);
            this.jobInfoDataGrid.TabIndex = 4;
            // 
            // JobInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 547);
            this.Controls.Add(this.jobInfoDataGrid);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.BottonPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "JobInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Info";
            this.TopPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BottonPanel.ResumeLayout(false);
            this.BottonPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobInfoDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label modelText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label customerText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label jobNumberText;
        private System.Windows.Forms.Label jobInfoLabel;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel BottonPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAddItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnUnlockCompleteOption;
        private System.Windows.Forms.CheckBox checkBoxComplete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView jobInfoDataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}