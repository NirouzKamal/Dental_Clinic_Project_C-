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
            this.panelActionBar.SuspendLayout();
            this.panelGridArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientRecords)).BeginInit();
            this.colCaseNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelActionBar.Name = "panelActionBar";
            this.panelActionBar.Padding = new System.Windows.Forms.Padding(20);
            this.panelActionBar.Size = new System.Drawing.Size(934, 80);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "سجل الحالات";
            // 
            // spacerTitle
            // 
            this.spacerTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.spacerTitle.Name = "spacerTitle";
            this.spacerTitle.Size = new System.Drawing.Size(30, 40);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 25);
            this.txtSearch.Text = "ابحث بالاسم أو رقم الملف...";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 40);
            this.btnPrint.Text = "طباعة تقارير";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // spacerButtons
            // 
            this.spacerButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacerButtons.Name = "spacerButtons";
            this.spacerButtons.Size = new System.Drawing.Size(20, 40);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 40);
            this.btnEdit.Text = "تعديل البيانات";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // panelGridArea
            // 
            this.panelGridArea.Controls.Add(this.dgvPatientRecords);
            this.panelGridArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridArea.Location = new System.Drawing.Point(0, 80);
            this.panelGridArea.Name = "panelGridArea";
            this.panelGridArea.Padding = new System.Windows.Forms.Padding(20);
            this.panelGridArea.Size = new System.Drawing.Size(934, 520);
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
            this.dgvPatientRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatientRecords.EnableHeadersVisualStyles = false;
            this.dgvPatientRecords.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.dgvPatientRecords.Name = "dgvPatientRecords";
            this.dgvPatientRecords.ReadOnly = true;
            this.dgvPatientRecords.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPatientRecords.RowHeadersVisible = false;
            this.dgvPatientRecords.RowTemplate.Height = 45;
            this.dgvPatientRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // Add columns
                        this.dgvPatientRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colCaseNum, this.colDate, this.colTreatment, this.colDoctor, this.colPrice, this.colPaid, this.colRemaining, this.colNotes, this.colStatus });
            // Column Definitions
            this.colCaseNum.HeaderText = "رقم الحالة";
            this.colCaseNum.Name = "colCaseNum";
            this.colCaseNum.ReadOnly = true;
            this.colDate.HeaderText = "التاريخ";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colTreatment.HeaderText = "العلاج";
            this.colTreatment.Name = "colTreatment";
            this.colTreatment.ReadOnly = true;
            this.colDoctor.HeaderText = "الطبيب";
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.ReadOnly = true;
            this.colPrice.HeaderText = "السعر";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPaid.HeaderText = "المدفوع";
            this.colPaid.Name = "colPaid";
            this.colPaid.ReadOnly = true;
            this.colRemaining.HeaderText = "الباقي";
            this.colRemaining.Name = "colRemaining";
            this.colRemaining.ReadOnly = true;
            this.colNotes.HeaderText = "ملاحظات";
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            this.colStatus.HeaderText = "الحالة";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;

            
            
            
            
            
            
            
            
            // 
            // PatientRecordsControlUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.Controls.Add(this.panelGridArea);
            this.Controls.Add(this.panelActionBar);
            this.Name = "PatientRecordsControlUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(934, 600);
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




