namespace DentalClinicProject.UI
{
    partial class PatientRecordsControlUI
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.panelActionBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.spacerTitle = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.spacerButtons = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panelGridArea = new System.Windows.Forms.Panel();
            this.dgvPatientRecords = new System.Windows.Forms.DataGridView();
            this.colCaseNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelActionBar.SuspendLayout();
            this.panelGridArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActionBar
            // 
            this.panelActionBar.BackColor = System.Drawing.Color.White;
            this.panelActionBar.Controls.Add(this.lblTitle);
            this.panelActionBar.Controls.Add(this.spacerTitle);
            this.panelActionBar.Controls.Add(this.txtSearch);
            this.panelActionBar.Controls.Add(this.btnPrint);
            this.panelActionBar.Controls.Add(this.spacerButtons);
            this.panelActionBar.Controls.Add(this.btnEdit);
            this.panelActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionBar.Location = new System.Drawing.Point(0, 0);
            this.panelActionBar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelActionBar.Name = "panelActionBar";
            this.panelActionBar.Padding = new System.Windows.Forms.Padding(53, 48, 53, 48);
            this.panelActionBar.Size = new System.Drawing.Size(2491, 191);
            this.panelActionBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(930, 48);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "سجل الحالات";
            // 
            // spacerTitle
            // 
            this.spacerTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.spacerTitle.Location = new System.Drawing.Point(850, 48);
            this.spacerTitle.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.spacerTitle.Name = "spacerTitle";
            this.spacerTitle.Size = new System.Drawing.Size(80, 95);
            this.spacerTitle.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.txtSearch.Location = new System.Drawing.Point(53, 48);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(797, 52);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "ابحث بالاسم أو رقم الملف...";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1585, 48);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(400, 95);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "طباعة تقارير";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // spacerButtons
            // 
            this.spacerButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacerButtons.Location = new System.Drawing.Point(1985, 48);
            this.spacerButtons.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.spacerButtons.Name = "spacerButtons";
            this.spacerButtons.Size = new System.Drawing.Size(53, 95);
            this.spacerButtons.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnEdit.Location = new System.Drawing.Point(2038, 48);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(400, 95);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "تعديل البيانات";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // panelGridArea
            // 
            this.panelGridArea.Controls.Add(this.dgvPatientRecords);
            this.panelGridArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridArea.Location = new System.Drawing.Point(0, 191);
            this.panelGridArea.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelGridArea.Name = "panelGridArea";
            this.panelGridArea.Padding = new System.Windows.Forms.Padding(53, 48, 53, 48);
            this.panelGridArea.Size = new System.Drawing.Size(2491, 1240);
            this.panelGridArea.TabIndex = 0;
            // 
            // dgvPatientRecords
            // 
            this.dgvPatientRecords.AllowUserToAddRows = false;
            this.dgvPatientRecords.AllowUserToDeleteRows = false;
            this.dgvPatientRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatientRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatientRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatientRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPatientRecords.ColumnHeadersHeight = 40;
            this.dgvPatientRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCaseNum,
            this.colDate,
            this.colTreatment,
            this.colDoctor,
            this.colPrice,
            this.colPaid,
            this.colRemaining,
            this.colNotes,
            this.colStatus});
            this.dgvPatientRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatientRecords.EnableHeadersVisualStyles = false;
            this.dgvPatientRecords.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvPatientRecords.Location = new System.Drawing.Point(53, 48);
            this.dgvPatientRecords.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvPatientRecords.Name = "dgvPatientRecords";
            this.dgvPatientRecords.ReadOnly = true;
            this.dgvPatientRecords.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPatientRecords.RowHeadersVisible = false;
            this.dgvPatientRecords.RowHeadersWidth = 102;
            this.dgvPatientRecords.RowTemplate.Height = 45;
            this.dgvPatientRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientRecords.Size = new System.Drawing.Size(2385, 1144);
            this.dgvPatientRecords.TabIndex = 0;
            // 
            // colCaseNum
            // 
            this.colCaseNum.HeaderText = "رقم الحالة";
            this.colCaseNum.MinimumWidth = 12;
            this.colCaseNum.Name = "colCaseNum";
            this.colCaseNum.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "التاريخ";
            this.colDate.MinimumWidth = 12;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colTreatment
            // 
            this.colTreatment.HeaderText = "العلاج";
            this.colTreatment.MinimumWidth = 12;
            this.colTreatment.Name = "colTreatment";
            this.colTreatment.ReadOnly = true;
            // 
            // colDoctor
            // 
            this.colDoctor.HeaderText = "الطبيب";
            this.colDoctor.MinimumWidth = 12;
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "السعر";
            this.colPrice.MinimumWidth = 12;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colPaid
            // 
            this.colPaid.HeaderText = "المدفوع";
            this.colPaid.MinimumWidth = 12;
            this.colPaid.Name = "colPaid";
            this.colPaid.ReadOnly = true;
            // 
            // colRemaining
            // 
            this.colRemaining.HeaderText = "الباقي";
            this.colRemaining.MinimumWidth = 12;
            this.colRemaining.Name = "colRemaining";
            this.colRemaining.ReadOnly = true;
            // 
            // colNotes
            // 
            this.colNotes.HeaderText = "ملاحظات";
            this.colNotes.MinimumWidth = 12;
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "الحالة";
            this.colStatus.MinimumWidth = 12;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // PatientRecordsControlUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.panelGridArea);
            this.Controls.Add(this.panelActionBar);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "PatientRecordsControlUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(2491, 1431);
            this.panelActionBar.ResumeLayout(false);
            this.panelActionBar.PerformLayout();
            this.panelGridArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelActionBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel spacerTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel spacerButtons;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panelGridArea;
        private System.Windows.Forms.DataGridView dgvPatientRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}




