namespace PrepandPaint
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchBySelectedYear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoJobNumber = new System.Windows.Forms.RadioButton();
            this.yearSelection = new System.Windows.Forms.DateTimePicker();
            this.rdoItem = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.createJobToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BtnBackUpDataBase = new System.Windows.Forms.ToolStripButton();
            this.BtnRestoreDataBase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripAdminButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripExportToExcel = new System.Windows.Forms.ToolStripButton();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLoadAll = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(498, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prep and Paint Details";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.Blue;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1538, 708);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchBySelectedYear);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnLoadAll);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1538, 124);
            this.panel1.TabIndex = 3;
            // 
            // btnSearchBySelectedYear
            // 
            this.btnSearchBySelectedYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSearchBySelectedYear.Image = global::PrepandPaint.Properties.Resources.Search_24x24;
            this.btnSearchBySelectedYear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchBySelectedYear.Location = new System.Drawing.Point(613, 78);
            this.btnSearchBySelectedYear.Name = "btnSearchBySelectedYear";
            this.btnSearchBySelectedYear.Size = new System.Drawing.Size(281, 34);
            this.btnSearchBySelectedYear.TabIndex = 8;
            this.btnSearchBySelectedYear.Text = "Search By Selected Year";
            this.btnSearchBySelectedYear.UseVisualStyleBackColor = true;
            this.btnSearchBySelectedYear.Click += new System.EventHandler(this.btnSearchBySelectedYear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoJobNumber);
            this.groupBox1.Controls.Add(this.yearSelection);
            this.groupBox1.Controls.Add(this.rdoItem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By:";
            // 
            // rdoJobNumber
            // 
            this.rdoJobNumber.AutoSize = true;
            this.rdoJobNumber.Checked = true;
            this.rdoJobNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoJobNumber.Location = new System.Drawing.Point(93, 32);
            this.rdoJobNumber.Name = "rdoJobNumber";
            this.rdoJobNumber.Size = new System.Drawing.Size(69, 28);
            this.rdoJobNumber.TabIndex = 0;
            this.rdoJobNumber.TabStop = true;
            this.rdoJobNumber.Text = "Job#";
            this.rdoJobNumber.UseVisualStyleBackColor = true;
            this.rdoJobNumber.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // yearSelection
            // 
            this.yearSelection.CustomFormat = "yyyy";
            this.yearSelection.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearSelection.Location = new System.Drawing.Point(6, 30);
            this.yearSelection.Name = "yearSelection";
            this.yearSelection.ShowUpDown = true;
            this.yearSelection.Size = new System.Drawing.Size(75, 29);
            this.yearSelection.TabIndex = 7;
            // 
            // rdoItem
            // 
            this.rdoItem.AutoSize = true;
            this.rdoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoItem.Location = new System.Drawing.Point(168, 32);
            this.rdoItem.Name = "rdoItem";
            this.rdoItem.Size = new System.Drawing.Size(63, 28);
            this.rdoItem.TabIndex = 0;
            this.rdoItem.Text = "Item";
            this.rdoItem.UseVisualStyleBackColor = true;
            this.rdoItem.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createJobToolStripButton,
            this.openToolStripButton,
            this.pasteToolStripButton,
            this.toolStripButton1,
            this.toolStripSeparator,
            this.BtnBackUpDataBase,
            this.BtnRestoreDataBase,
            this.toolStripSeparator1,
            this.helpToolStripButton,
            this.toolStripAdminButton,
            this.toolStripExportToExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1538, 32);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // createJobToolStripButton
            // 
            this.createJobToolStripButton.Image = global::PrepandPaint.Properties.Resources.Add_16x161;
            this.createJobToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createJobToolStripButton.Name = "createJobToolStripButton";
            this.createJobToolStripButton.Size = new System.Drawing.Size(121, 29);
            this.createJobToolStripButton.Text = "Create Job";
            this.createJobToolStripButton.Click += new System.EventHandler(this.createJobToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.Image = global::PrepandPaint.Properties.Resources.Delete_16x16;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(86, 29);
            this.openToolStripButton.Text = "&Delete";
            this.openToolStripButton.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.Image = global::PrepandPaint.Properties.Resources.Edit_16x16;
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(64, 29);
            this.pasteToolStripButton.Text = "&Edit";
            this.pasteToolStripButton.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::PrepandPaint.Properties.Resources.Text_Document_16x16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(81, 29);
            this.toolStripButton1.Text = "Notes";
            this.toolStripButton1.Click += new System.EventHandler(this.BtnSupervisorNotes_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 32);
            // 
            // BtnBackUpDataBase
            // 
            this.BtnBackUpDataBase.Image = global::PrepandPaint.Properties.Resources.Archive_16x16;
            this.BtnBackUpDataBase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBackUpDataBase.Name = "BtnBackUpDataBase";
            this.BtnBackUpDataBase.Size = new System.Drawing.Size(95, 29);
            this.BtnBackUpDataBase.Text = "Back&Up";
            this.BtnBackUpDataBase.Click += new System.EventHandler(this.BtnBackUpDataBase_Click);
            // 
            // BtnRestoreDataBase
            // 
            this.BtnRestoreDataBase.Image = global::PrepandPaint.Properties.Resources.Flash_Disk_16x16;
            this.BtnRestoreDataBase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRestoreDataBase.Name = "BtnRestoreDataBase";
            this.BtnRestoreDataBase.Size = new System.Drawing.Size(177, 29);
            this.BtnRestoreDataBase.Text = "&Restore Database";
            this.BtnRestoreDataBase.Click += new System.EventHandler(this.BtnRestoreDataBase_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(71, 29);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // toolStripAdminButton
            // 
            this.toolStripAdminButton.Image = global::PrepandPaint.Properties.Resources.Administrator_icon;
            this.toolStripAdminButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAdminButton.Name = "toolStripAdminButton";
            this.toolStripAdminButton.Size = new System.Drawing.Size(87, 29);
            this.toolStripAdminButton.Text = "Admin";
            this.toolStripAdminButton.Click += new System.EventHandler(this.toolStripAdminButton_Click);
            // 
            // toolStripExportToExcel
            // 
            this.toolStripExportToExcel.Image = global::PrepandPaint.Properties.Resources.Save_16x16;
            this.toolStripExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExportToExcel.Name = "toolStripExportToExcel";
            this.toolStripExportToExcel.Size = new System.Drawing.Size(158, 29);
            this.toolStripExportToExcel.Text = "Export To Excel";
            this.toolStripExportToExcel.Click += new System.EventHandler(this.toolStripExportToExcel_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Image = global::PrepandPaint.Properties.Resources.Log_Out_48x48;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(1429, 35);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(97, 62);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnLoadAll
            // 
            this.BtnLoadAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadAll.Image = global::PrepandPaint.Properties.Resources.Search_24x24;
            this.BtnLoadAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLoadAll.Location = new System.Drawing.Point(900, 78);
            this.BtnLoadAll.Name = "BtnLoadAll";
            this.BtnLoadAll.Size = new System.Drawing.Size(141, 34);
            this.BtnLoadAll.TabIndex = 3;
            this.BtnLoadAll.Text = "&Load All";
            this.BtnLoadAll.UseVisualStyleBackColor = true;
            this.BtnLoadAll.Click += new System.EventHandler(this.BtnLoadAll_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Image = global::PrepandPaint.Properties.Resources.Search_24x24;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.Location = new System.Drawing.Point(457, 78);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(150, 34);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search All";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.btnSearchAnyYear_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(255, 80);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 29);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1538, 708);
            this.panel2.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 832);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prep & Paint Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button BtnLoadAll;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripButton BtnBackUpDataBase;
        private System.Windows.Forms.ToolStripButton BtnRestoreDataBase;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoJobNumber;
        private System.Windows.Forms.RadioButton rdoItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripButton toolStripAdminButton;
        private System.Windows.Forms.ToolStripButton createJobToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripExportToExcel;
        private System.Windows.Forms.DateTimePicker yearSelection;
        private System.Windows.Forms.Button btnSearchBySelectedYear;
    }
}

