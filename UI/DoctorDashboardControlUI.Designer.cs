namespace DentalClinicProject.UI
{
    partial class DoctorDashboardControlUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.tlpKPIs = new System.Windows.Forms.TableLayoutPanel();
            this.panelKPI1 = new System.Windows.Forms.Panel();
            this.lblTotalTodayValue = new System.Windows.Forms.Label();
            this.lblTotalTodayTitle = new System.Windows.Forms.Label();
            this.panelKPI2 = new System.Windows.Forms.Panel();
            this.lblWaitingValue = new System.Windows.Forms.Label();
            this.lblWaitingTitle = new System.Windows.Forms.Label();
            this.panelActionBar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnMyPatients = new System.Windows.Forms.Button();
            this.panelGridArea = new System.Windows.Forms.Panel();
            this.dgvDoctorQueue = new System.Windows.Forms.DataGridView();
            this.colFileNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpKPIs.SuspendLayout();
            this.panelKPI1.SuspendLayout();
            this.panelKPI2.SuspendLayout();
            this.panelActionBar.SuspendLayout();
            this.panelGridArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpKPIs
            // 
            this.tlpKPIs.ColumnCount = 2;
            this.tlpKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKPIs.Controls.Add(this.panelKPI1, 0, 0);
            this.tlpKPIs.Controls.Add(this.panelKPI2, 1, 0);
            this.tlpKPIs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpKPIs.Location = new System.Drawing.Point(0, 0);
            this.tlpKPIs.Name = "tlpKPIs";
            this.tlpKPIs.Padding = new System.Windows.Forms.Padding(20);
            this.tlpKPIs.RowCount = 1;
            this.tlpKPIs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKPIs.Size = new System.Drawing.Size(934, 120);
            this.tlpKPIs.TabIndex = 0;
            // 
            // panelKPI1
            // 
            this.panelKPI1.BackColor = System.Drawing.Color.White;
            this.panelKPI1.Controls.Add(this.lblTotalTodayValue);
            this.panelKPI1.Controls.Add(this.lblTotalTodayTitle);
            this.panelKPI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKPI1.Margin = new System.Windows.Forms.Padding(10);
            this.panelKPI1.Name = "panelKPI1";
            // 
            // lblTotalTodayTitle
            // 
            this.lblTotalTodayTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalTodayTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalTodayTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblTotalTodayTitle.Name = "lblTotalTodayTitle";
            this.lblTotalTodayTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTotalTodayTitle.Text = "إجمالي المواعيد اليوم";
            this.lblTotalTodayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalTodayValue
            // 
            this.lblTotalTodayValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalTodayValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalTodayValue.ForeColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.lblTotalTodayValue.Name = "lblTotalTodayValue";
            this.lblTotalTodayValue.Text = "0";
            this.lblTotalTodayValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKPI2
            // 
            this.panelKPI2.BackColor = System.Drawing.Color.White;
            this.panelKPI2.Controls.Add(this.lblWaitingValue);
            this.panelKPI2.Controls.Add(this.lblWaitingTitle);
            this.panelKPI2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKPI2.Margin = new System.Windows.Forms.Padding(10);
            this.panelKPI2.Name = "panelKPI2";
            // 
            // lblWaitingTitle
            // 
            this.lblWaitingTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWaitingTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWaitingTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblWaitingTitle.Name = "lblWaitingTitle";
            this.lblWaitingTitle.Size = new System.Drawing.Size(400, 30);
            this.lblWaitingTitle.Text = "حالات الإنتظار";
            this.lblWaitingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWaitingValue
            // 
            this.lblWaitingValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWaitingValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblWaitingValue.ForeColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.lblWaitingValue.Name = "lblWaitingValue";
            this.lblWaitingValue.Text = "0";
            this.lblWaitingValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelActionBar
            // 
            this.panelActionBar.Controls.Add(this.txtSearch);
            this.panelActionBar.Controls.Add(this.btnMyPatients);
            this.panelActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionBar.Location = new System.Drawing.Point(0, 120);
            this.panelActionBar.Name = "panelActionBar";
            this.panelActionBar.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panelActionBar.Size = new System.Drawing.Size(934, 70);
            this.panelActionBar.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(550, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 29);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "ابحث عن حالة...";
            // 
            // btnMyPatients
            // 
            this.btnMyPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.btnMyPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyPatients.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMyPatients.FlatAppearance.BorderSize = 0;
            this.btnMyPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyPatients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMyPatients.ForeColor = System.Drawing.Color.White;
            this.btnMyPatients.Name = "btnMyPatients";
            this.btnMyPatients.Size = new System.Drawing.Size(120, 40);
            this.btnMyPatients.TabIndex = 0;
            this.btnMyPatients.Text = "مرضاي";
            this.btnMyPatients.UseVisualStyleBackColor = false;
            // 
            this.btnMyPatients.FlatAppearance.BorderSize = 0;
            this.btnMyPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyPatients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMyPatients.ForeColor = System.Drawing.Color.White;
            this.btnMyPatients.Name = "btnMyPatients";
            this.btnMyPatients.Size = new System.Drawing.Size(120, 40);
            this.btnMyPatients.Text = "مرضاي";
            this.btnMyPatients.UseVisualStyleBackColor = false;
            // 
            // panelGridArea
            // 
            this.panelGridArea.Controls.Add(this.dgvDoctorQueue);
            this.panelGridArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridArea.Location = new System.Drawing.Point(0, 200);
            this.panelGridArea.Name = "panelGridArea";
            this.panelGridArea.Padding = new System.Windows.Forms.Padding(20);
            this.panelGridArea.Size = new System.Drawing.Size(934, 400);
            this.panelGridArea.TabIndex = 2;
            // 
            // dgvDoctorQueue
            // 
            this.dgvDoctorQueue.AllowUserToAddRows = false;
            this.dgvDoctorQueue.AllowUserToDeleteRows = false;
            this.dgvDoctorQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctorQueue.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoctorQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoctorQueue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDoctorQueue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDoctorQueue.ColumnHeadersHeight = 40;
            this.dgvDoctorQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFileNum, this.colPatientName, this.colTime, this.colNotes, this.colStatus});
            this.dgvDoctorQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoctorQueue.EnableHeadersVisualStyles = false;
            this.dgvDoctorQueue.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.dgvDoctorQueue.Name = "dgvDoctorQueue";
            this.dgvDoctorQueue.ReadOnly = true;
            this.dgvDoctorQueue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDoctorQueue.RowHeadersVisible = false;
            this.dgvDoctorQueue.RowTemplate.Height = 45;
            this.dgvDoctorQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Column Definitions
            // 
            this.colFileNum.HeaderText = "رقم الملف"; this.colFileNum.Name = "colFileNum"; this.colFileNum.ReadOnly = true;
            this.colPatientName.HeaderText = "اسم الحالة"; this.colPatientName.Name = "colPatientName"; this.colPatientName.ReadOnly = true;
            this.colTime.HeaderText = "الوقت"; this.colTime.Name = "colTime"; this.colTime.ReadOnly = true;
            this.colNotes.HeaderText = "ملاحظات"; this.colNotes.Name = "colNotes"; this.colNotes.ReadOnly = true;
            this.colStatus.HeaderText = "الحالة"; this.colStatus.Name = "colStatus"; this.colStatus.ReadOnly = true;
            // 
            // DoctorDashboardControlUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.Controls.Add(this.panelGridArea);
            this.Controls.Add(this.panelActionBar);
            this.Controls.Add(this.tlpKPIs);
            this.Name = "DoctorDashboardControlUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(934, 600);
            this.tlpKPIs.ResumeLayout(false);
            this.panelKPI1.ResumeLayout(false);
            this.panelKPI2.ResumeLayout(false);
            this.panelActionBar.ResumeLayout(false);
            this.panelActionBar.PerformLayout();
            this.panelGridArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorQueue)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpKPIs;
        private System.Windows.Forms.Panel panelKPI1;
        private System.Windows.Forms.Label lblTotalTodayValue;
        private System.Windows.Forms.Label lblTotalTodayTitle;
        private System.Windows.Forms.Panel panelKPI2;
        private System.Windows.Forms.Label lblWaitingValue;
        private System.Windows.Forms.Label lblWaitingTitle;
        private System.Windows.Forms.Panel panelActionBar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnMyPatients;
        private System.Windows.Forms.Panel panelGridArea;
        private System.Windows.Forms.DataGridView dgvDoctorQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}


