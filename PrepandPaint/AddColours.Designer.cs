namespace PrepandPaint
{
    partial class AddColours
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
            this.BtnAddColour = new System.Windows.Forms.Button();
            this.colourDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColourCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.colourDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddColour
            // 
            this.BtnAddColour.Location = new System.Drawing.Point(350, 58);
            this.BtnAddColour.Name = "BtnAddColour";
            this.BtnAddColour.Size = new System.Drawing.Size(75, 23);
            this.BtnAddColour.TabIndex = 4;
            this.BtnAddColour.Text = "&Add";
            this.BtnAddColour.UseVisualStyleBackColor = true;
            this.BtnAddColour.Click += new System.EventHandler(this.BtnAddColour_Click);
            // 
            // colourDataGridView
            // 
            this.colourDataGridView.AllowUserToAddRows = false;
            this.colourDataGridView.AllowUserToDeleteRows = false;
            this.colourDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.colourDataGridView.Location = new System.Drawing.Point(15, 138);
            this.colourDataGridView.Name = "colourDataGridView";
            this.colourDataGridView.ReadOnly = true;
            this.colourDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.colourDataGridView.Size = new System.Drawing.Size(468, 150);
            this.colourDataGridView.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colour Code:";
            // 
            // txtColourCode
            // 
            this.txtColourCode.Location = new System.Drawing.Point(104, 27);
            this.txtColourCode.Name = "txtColourCode";
            this.txtColourCode.Size = new System.Drawing.Size(220, 22);
            this.txtColourCode.TabIndex = 1;
            this.txtColourCode.Tag = "Colour Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Colour To Delete:";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(327, 312);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(408, 312);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "&Exit";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Colour:";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(104, 59);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(220, 22);
            this.txtColour.TabIndex = 3;
            this.txtColour.Tag = "Colour";
            // 
            // AddColours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 347);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.txtColourCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colourDataGridView);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAddColour);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddColours";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Colour";
            ((System.ComponentModel.ISupportInitialize)(this.colourDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddColour;
        private System.Windows.Forms.DataGridView colourDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColourCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColour;
    }
}