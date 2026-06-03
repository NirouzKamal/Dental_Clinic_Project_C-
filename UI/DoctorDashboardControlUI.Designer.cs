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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpKPIs = new System.Windows.Forms.TableLayoutPanel();
            this.panelKPI1 = new System.Windows.Forms.Panel();
            this.lblTotalTodayValue = new System.Windows.Forms.Label();
            this.lblTotalTodayTitle = new System.Windows.Forms.Label();
            this.panelKPI2 = new System.Windows.Forms.Panel();
            this.lblWaitingValue = new System.Windows.Forms.Label();
            this.lblWaitingTitle = new System.Windows.Forms.Label();
            this.panelActionBar = new System.Windows.Forms.Panel();
            this.btnMyPatients = new System.Windows.Forms.Button();
            this.panelGridArea = new System.Windows.Forms.Panel();
            this.dgvDoctorQueue = new System.Windows.Forms.DataGridView();
            this.colFileNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tlpKPIs.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tlpKPIs.Name = "tlpKPIs";
            this.tlpKPIs.Padding = new System.Windows.Forms.Padding(53, 48, 53, 48);
            this.tlpKPIs.RowCount = 1;
            this.tlpKPIs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKPIs.Size = new System.Drawing.Size(2491, 422);
            this.tlpKPIs.TabIndex = 0;
            // 
            // panelKPI1
            // 
            this.panelKPI1.BackColor = System.Drawing.Color.White;
            this.panelKPI1.Controls.Add(this.lblTotalTodayValue);
            this.panelKPI1.Controls.Add(this.lblTotalTodayTitle);
            this.panelKPI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKPI1.Location = new System.Drawing.Point(1273, 72);
            this.panelKPI1.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.panelKPI1.Name = "panelKPI1";
            this.panelKPI1.Size = new System.Drawing.Size(1138, 278);
            this.panelKPI1.TabIndex = 0;
            // 
            // lblTotalTodayValue
            // 
            this.lblTotalTodayValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalTodayValue.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTodayValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.lblTotalTodayValue.Location = new System.Drawing.Point(0, 72);
            this.lblTotalTodayValue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTotalTodayValue.Name = "lblTotalTodayValue";
            this.lblTotalTodayValue.Size = new System.Drawing.Size(1138, 206);
            this.lblTotalTodayValue.TabIndex = 0;
            this.lblTotalTodayValue.Text = "0";
            this.lblTotalTodayValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalTodayTitle
            // 
            this.lblTotalTodayTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalTodayTitle.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTodayTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTotalTodayTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTotalTodayTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTotalTodayTitle.Name = "lblTotalTodayTitle";
            this.lblTotalTodayTitle.Size = new System.Drawing.Size(1138, 72);
            this.lblTotalTodayTitle.TabIndex = 1;
            this.lblTotalTodayTitle.Text = "إجمالي المواعيد اليوم";
            this.lblTotalTodayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKPI2
            // 
            this.panelKPI2.BackColor = System.Drawing.Color.White;
            this.panelKPI2.Controls.Add(this.lblWaitingValue);
            this.panelKPI2.Controls.Add(this.lblWaitingTitle);
            this.panelKPI2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKPI2.Location = new System.Drawing.Point(80, 72);
            this.panelKPI2.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.panelKPI2.Name = "panelKPI2";
            this.panelKPI2.Size = new System.Drawing.Size(1139, 278);
            this.panelKPI2.TabIndex = 1;
            // 
            // lblWaitingValue
            // 
            this.lblWaitingValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWaitingValue.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitingValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.lblWaitingValue.Location = new System.Drawing.Point(0, 72);
            this.lblWaitingValue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblWaitingValue.Name = "lblWaitingValue";
            this.lblWaitingValue.Size = new System.Drawing.Size(1139, 206);
            this.lblWaitingValue.TabIndex = 0;
            this.lblWaitingValue.Text = "0";
            this.lblWaitingValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWaitingTitle
            // 
            this.lblWaitingTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWaitingTitle.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblWaitingTitle.Location = new System.Drawing.Point(0, 0);
            this.lblWaitingTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblWaitingTitle.Name = "lblWaitingTitle";
            this.lblWaitingTitle.Size = new System.Drawing.Size(1139, 72);
            this.lblWaitingTitle.TabIndex = 1;
            this.lblWaitingTitle.Text = "حالات الإنتظار";
            this.lblWaitingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelActionBar
            // 
            this.panelActionBar.Controls.Add(this.btnMyPatients);
            this.panelActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionBar.Location = new System.Drawing.Point(0, 422);
            this.panelActionBar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelActionBar.Name = "panelActionBar";
            this.panelActionBar.Padding = new System.Windows.Forms.Padding(53, 48, 53, 24);
            this.panelActionBar.Size = new System.Drawing.Size(2491, 167);
            this.panelActionBar.TabIndex = 1;
            // 
            // btnMyPatients
            // 
            this.btnMyPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.btnMyPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyPatients.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMyPatients.FlatAppearance.BorderSize = 0;
            this.btnMyPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyPatients.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyPatients.ForeColor = System.Drawing.Color.White;
            this.btnMyPatients.Location = new System.Drawing.Point(1874, 48);
            this.btnMyPatients.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnMyPatients.Name = "btnMyPatients";
            this.btnMyPatients.Size = new System.Drawing.Size(564, 95);
            this.btnMyPatients.TabIndex = 0;
            this.btnMyPatients.Text = "حالات الإنتظار";
            this.btnMyPatients.UseVisualStyleBackColor = false;
            this.btnMyPatients.Click += new System.EventHandler(this.btnMyPatients_Click);
            // 
            // panelGridArea
            // 
            this.panelGridArea.Controls.Add(this.dgvDoctorQueue);
            this.panelGridArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridArea.Location = new System.Drawing.Point(0, 589);
            this.panelGridArea.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelGridArea.Name = "panelGridArea";
            this.panelGridArea.Padding = new System.Windows.Forms.Padding(53, 48, 53, 48);
            this.panelGridArea.Size = new System.Drawing.Size(2491, 842);
            this.panelGridArea.TabIndex = 2;
            // 
            // dgvDoctorQueue
            // 
            this.dgvDoctorQueue.AllowUserToAddRows = false;
            this.dgvDoctorQueue.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDoctorQueue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDoctorQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctorQueue.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoctorQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoctorQueue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDoctorQueue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctorQueue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDoctorQueue.ColumnHeadersHeight = 40;
            this.dgvDoctorQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFileNum,
            this.colPatientName,
            this.colTime,
            this.colPeriod,
            this.colStatus});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoctorQueue.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDoctorQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoctorQueue.EnableHeadersVisualStyles = false;
            this.dgvDoctorQueue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvDoctorQueue.Location = new System.Drawing.Point(53, 48);
            this.dgvDoctorQueue.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvDoctorQueue.Name = "dgvDoctorQueue";
            this.dgvDoctorQueue.ReadOnly = true;
            this.dgvDoctorQueue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDoctorQueue.RowHeadersVisible = false;
            this.dgvDoctorQueue.RowHeadersWidth = 102;
            this.dgvDoctorQueue.RowTemplate.Height = 45;
            this.dgvDoctorQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctorQueue.Size = new System.Drawing.Size(2385, 746);
            this.dgvDoctorQueue.TabIndex = 0;
            // 
            // colFileNum
            // 
            this.colFileNum.HeaderText = "رقم الملف";
            this.colFileNum.MinimumWidth = 12;
            this.colFileNum.Name = "colFileNum";
            this.colFileNum.ReadOnly = true;
            // 
            // colPatientName
            // 
            this.colPatientName.HeaderText = "اسم الحالة";
            this.colPatientName.MinimumWidth = 12;
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.ReadOnly = true;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "الوقت";
            this.colTime.MinimumWidth = 12;
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colPeriod
            // 
            this.colPeriod.HeaderText = "الفترة";
            this.colPeriod.MinimumWidth = 12;
            this.colPeriod.Name = "colPeriod";
            this.colPeriod.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "الحالة";
            this.colStatus.MinimumWidth = 12;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // DoctorDashboardControlUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.panelGridArea);
            this.Controls.Add(this.panelActionBar);
            this.Controls.Add(this.tlpKPIs);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "DoctorDashboardControlUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(2491, 1431);
            this.tlpKPIs.ResumeLayout(false);
            this.panelKPI1.ResumeLayout(false);
            this.panelKPI2.ResumeLayout(false);
            this.panelActionBar.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnMyPatients;
        private System.Windows.Forms.Panel panelGridArea;
        private System.Windows.Forms.DataGridView dgvDoctorQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}


