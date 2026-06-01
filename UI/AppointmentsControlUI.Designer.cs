namespace DentalClinicProject.UI
{
    partial class AppointmentsControlUI
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.lblDoctorFilter = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelGridArea = new System.Windows.Forms.Panel();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTopBar.SuspendLayout();
            this.panelGridArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.White;
            this.panelTopBar.Controls.Add(this.lblTitle);
            this.panelTopBar.Controls.Add(this.lblDoctorFilter);
            this.panelTopBar.Controls.Add(this.cmbDoctor);
            this.panelTopBar.Controls.Add(this.txtSearch);
            this.panelTopBar.Controls.Add(this.btnDeleteAppointment);
            this.panelTopBar.Controls.Add(this.btnAddAppointment);
            this.panelTopBar.Controls.Add(this.btnAddPatient);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Padding = new System.Windows.Forms.Padding(20);
            this.panelTopBar.Size = new System.Drawing.Size(934, 80);
            this.panelTopBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "إدارة المواعيد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.btnAddPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPatient.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddPatient.FlatAppearance.BorderSize = 0;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddPatient.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(120, 40);
            this.btnAddPatient.Text = "مريض جديد";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.btnAddAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAppointment.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddAppointment.FlatAppearance.BorderSize = 0;
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(120, 40);
            this.btnAddAppointment.Text = "موعد جديد";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.BackColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.btnDeleteAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAppointment.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteAppointment.FlatAppearance.BorderSize = 0;
            this.btnDeleteAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAppointment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDeleteAppointment.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(120, 40);
            this.btnDeleteAppointment.Text = "حذف الموعد";
            this.btnDeleteAppointment.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.txtSearch.Location = new System.Drawing.Point(400, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 25);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "ابحث برقم أو اسم المريض...";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDoctor.Location = new System.Drawing.Point(620, 27);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(200, 25);
            this.cmbDoctor.TabIndex = 4;
            // 
            // lblDoctorFilter
            // 
            this.lblDoctorFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoctorFilter.AutoSize = true;
            this.lblDoctorFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDoctorFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblDoctorFilter.Location = new System.Drawing.Point(830, 30);
            this.lblDoctorFilter.Name = "lblDoctorFilter";
            this.lblDoctorFilter.Size = new System.Drawing.Size(41, 19);
            this.lblDoctorFilter.TabIndex = 3;
            this.lblDoctorFilter.Text = "طبيب:";
            // 
            // panelGridArea
            // 
            this.panelGridArea.Controls.Add(this.dgvAppointments);
            this.panelGridArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridArea.Location = new System.Drawing.Point(0, 80);
            this.panelGridArea.Name = "panelGridArea";
            this.panelGridArea.Padding = new System.Windows.Forms.Padding(20);
            this.panelGridArea.Size = new System.Drawing.Size(934, 520);
            this.panelGridArea.TabIndex = 1;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAppointments.ColumnHeadersHeight = 40;
            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate, this.colTime, this.colPatientName, this.colFileNum, this.colPhone, this.colStatus, this.colNotes});
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointments.EnableHeadersVisualStyles = false;
            this.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowTemplate.Height = 45;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Column Definitions
            // 
            this.colDate.HeaderText = "التاريخ"; this.colDate.Name = "colDate"; this.colDate.ReadOnly = true;
            this.colTime.HeaderText = "الوقت"; this.colTime.Name = "colTime"; this.colTime.ReadOnly = true;
            this.colPatientName.HeaderText = "إسم الحالة"; this.colPatientName.Name = "colPatientName"; this.colPatientName.ReadOnly = true;
            this.colFileNum.HeaderText = "رقم الملف"; this.colFileNum.Name = "colFileNum"; this.colFileNum.ReadOnly = true;
            this.colPhone.HeaderText = "رقم الهاتف"; this.colPhone.Name = "colPhone"; this.colPhone.ReadOnly = true;
            this.colStatus.HeaderText = "الحالة"; this.colStatus.Name = "colStatus"; this.colStatus.ReadOnly = true;
            this.colNotes.HeaderText = "ملاحظات"; this.colNotes.Name = "colNotes"; this.colNotes.ReadOnly = true;
            // 
            // AppointmentsControlUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.Controls.Add(this.panelGridArea);
            this.Controls.Add(this.panelTopBar);
            this.Name = "AppointmentsControlUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(934, 600);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelGridArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label lblDoctorFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelGridArea;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
    }
}


