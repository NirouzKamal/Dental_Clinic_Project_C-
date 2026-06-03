namespace DentalClinicProject.UI
{
    partial class PatientRecordsControlUI
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelActionBar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.spacerPatientCombo = new System.Windows.Forms.Panel();
            this.cmbSelectPatient = new System.Windows.Forms.ComboBox();
            this.spacerTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.panelDebtSummary = new System.Windows.Forms.Panel();
            this.lblTotalDebt = new System.Windows.Forms.Label();
            this.crystalOpenFileDialog1 = new CrystalDecisions.Shared.Interop.CrystalOpenFileDialog();
            this.panelActionBar.SuspendLayout();
            this.panelGridArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientRecords)).BeginInit();
            this.panelDebtSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActionBar
            // 
            this.panelActionBar.BackColor = System.Drawing.Color.White;
            this.panelActionBar.Controls.Add(this.txtSearch);
            this.panelActionBar.Controls.Add(this.spacerPatientCombo);
            this.panelActionBar.Controls.Add(this.cmbSelectPatient);
            this.panelActionBar.Controls.Add(this.spacerTitle);
            this.panelActionBar.Controls.Add(this.lblTitle);
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
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.txtSearch.Location = new System.Drawing.Point(815, 48);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(647, 68);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "ابحث بالاسم أو رقم الملف...";
            // 
            // spacerPatientCombo
            // 
            this.spacerPatientCombo.Dock = System.Windows.Forms.DockStyle.Left;
            this.spacerPatientCombo.Location = new System.Drawing.Point(785, 48);
            this.spacerPatientCombo.Name = "spacerPatientCombo";
            this.spacerPatientCombo.Size = new System.Drawing.Size(30, 95);
            this.spacerPatientCombo.TabIndex = 7;
            // 
            // cmbSelectPatient
            // 
            this.cmbSelectPatient.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbSelectPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectPatient.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectPatient.Location = new System.Drawing.Point(350, 48);
            this.cmbSelectPatient.Name = "cmbSelectPatient";
            this.cmbSelectPatient.Size = new System.Drawing.Size(435, 69);
            this.cmbSelectPatient.TabIndex = 6;
            // 
            // spacerTitle
            // 
            this.spacerTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.spacerTitle.Location = new System.Drawing.Point(310, 48);
            this.spacerTitle.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.spacerTitle.Name = "spacerTitle";
            this.spacerTitle.Size = new System.Drawing.Size(40, 95);
            this.spacerTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(53, 48);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(257, 61);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "سجل الحالات";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelGridArea.Controls.Add(this.panelDebtSummary);
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
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPatientRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPatientRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatientRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatientRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatientRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientRecords.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPatientRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatientRecords.EnableHeadersVisualStyles = false;
            this.dgvPatientRecords.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvPatientRecords.Location = new System.Drawing.Point(53, 48);
            this.dgvPatientRecords.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvPatientRecords.Name = "dgvPatientRecords";
            this.dgvPatientRecords.ReadOnly = true;
            this.dgvPatientRecords.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPatientRecords.RowHeadersVisible = false;
            this.dgvPatientRecords.RowHeadersWidth = 102;
            this.dgvPatientRecords.RowTemplate.Height = 45;
            this.dgvPatientRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientRecords.Size = new System.Drawing.Size(2385, 1094);
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
            // panelDebtSummary
            // 
            this.panelDebtSummary.Controls.Add(this.lblTotalDebt);
            this.panelDebtSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDebtSummary.Location = new System.Drawing.Point(53, 1142);
            this.panelDebtSummary.Name = "panelDebtSummary";
            this.panelDebtSummary.Size = new System.Drawing.Size(2385, 50);
            this.panelDebtSummary.TabIndex = 1;
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalDebt.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDebt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblTotalDebt.Location = new System.Drawing.Point(0, 0);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(2385, 50);
            this.lblTotalDebt.TabIndex = 0;
            this.lblTotalDebt.Text = "إجمالي ديون المريض: 0.00 د.ل";
            this.lblTotalDebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // crystalOpenFileDialog1
            // 
            this.crystalOpenFileDialog1.FileName = "crystalOpenFileDialog1";
            this.crystalOpenFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.crystalOpenFileDialog1_FileOk);
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
            this.panelDebtSummary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelActionBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel spacerTitle;
        private System.Windows.Forms.ComboBox cmbSelectPatient;
        private System.Windows.Forms.Panel spacerPatientCombo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel spacerButtons;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panelGridArea;
        private System.Windows.Forms.DataGridView dgvPatientRecords;
        private System.Windows.Forms.Panel panelDebtSummary;
        private System.Windows.Forms.Label lblTotalDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private CrystalDecisions.Shared.Interop.CrystalOpenFileDialog crystalOpenFileDialog1;
    }
}




