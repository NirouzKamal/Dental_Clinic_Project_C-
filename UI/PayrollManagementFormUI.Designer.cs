namespace DentalClinicProject.UI
{
    partial class PayrollManagementFormUI
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.btnPaySelected = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelGridArea = new System.Windows.Forms.Panel();
            this.dgvPayroll = new System.Windows.Forms.DataGridView();
            this.colEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            this.panelTopBar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelGridArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.SuspendLayout();
            
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panelTopBar.Controls.Add(this.btnCalculate);
            this.panelTopBar.Controls.Add(this.cmbYear);
            this.panelTopBar.Controls.Add(this.lblYear);
            this.panelTopBar.Controls.Add(this.cmbMonth);
            this.panelTopBar.Controls.Add(this.lblMonth);
            this.panelTopBar.Controls.Add(this.btnPaySelected);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Padding = new System.Windows.Forms.Padding(20);
            this.panelTopBar.Size = new System.Drawing.Size(900, 70);
            this.panelTopBar.TabIndex = 0;
            // 
            // btnPaySelected
            // 
            this.btnPaySelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnPaySelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaySelected.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPaySelected.FlatAppearance.BorderSize = 0;
            this.btnPaySelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaySelected.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnPaySelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnPaySelected.Location = new System.Drawing.Point(630, 20);
            this.btnPaySelected.Name = "btnPaySelected";
            this.btnPaySelected.Size = new System.Drawing.Size(250, 30);
            this.btnPaySelected.TabIndex = 0;
            this.btnPaySelected.Text = "صرف الراتب للموظف المحدد";
            this.btnPaySelected.UseVisualStyleBackColor = false;
            // 
            // lblMonth
            // 
            this.lblMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblMonth.Location = new System.Drawing.Point(580, 25);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(43, 19);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "الشهر:";
            // 
            // cmbMonth
            // 
            this.cmbMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(490, 23);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(80, 21);
            this.cmbMonth.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblYear.Location = new System.Drawing.Point(440, 25);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(43, 19);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "السنة:";
            // 
            // cmbYear
            // 
            this.cmbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(330, 23);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(100, 21);
            this.cmbYear.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnCalculate.Location = new System.Drawing.Point(20, 20);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 30);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "حساب مستحقات الشهر";
            this.btnCalculate.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 70);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 60);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(680, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إدارة الرواتب والعمولات";
            // 
            // panelGridArea
            // 
            this.panelGridArea.BackColor = System.Drawing.Color.White;
            this.panelGridArea.Controls.Add(this.dgvPayroll);
            this.panelGridArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridArea.Location = new System.Drawing.Point(0, 130);
            this.panelGridArea.Name = "panelGridArea";
            this.panelGridArea.Padding = new System.Windows.Forms.Padding(20);
            this.panelGridArea.Size = new System.Drawing.Size(900, 470);
            this.panelGridArea.TabIndex = 2;
            // 
            // dgvPayroll
            // 
            this.dgvPayroll.AllowUserToAddRows = false;
            this.dgvPayroll.AllowUserToDeleteRows = false;
            this.dgvPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayroll.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayroll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayroll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayroll.ColumnHeadersHeight = 40;
            this.dgvPayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpName,
            this.colRole,
            this.colBaseSalary,
            this.colCommission,
            this.colTotal,
            this.colStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayroll.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayroll.EnableHeadersVisualStyles = false;
            this.dgvPayroll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvPayroll.Location = new System.Drawing.Point(20, 20);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.ReadOnly = true;
            this.dgvPayroll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPayroll.RowHeadersVisible = false;
            this.dgvPayroll.RowTemplate.Height = 40;
            this.dgvPayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayroll.Size = new System.Drawing.Size(860, 430);
            this.dgvPayroll.TabIndex = 0;
            // 
            // colEmpName
            // 
            this.colEmpName.HeaderText = "اسم الموظف";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.ReadOnly = true;
            // 
            // colRole
            // 
            this.colRole.HeaderText = "الدور الوظيفي";
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            // 
            // colBaseSalary
            // 
            this.colBaseSalary.HeaderText = "الراتب الأساسي";
            this.colBaseSalary.Name = "colBaseSalary";
            this.colBaseSalary.ReadOnly = true;
            // 
            // colCommission
            // 
            this.colCommission.HeaderText = "عمولة الحالات";
            this.colCommission.Name = "colCommission";
            this.colCommission.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "الإجمالي المستحق";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "حالة الصرف";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // PayrollManagementFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelGridArea);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelTopBar);
            this.Name = "PayrollManagementFormUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إدارة الرواتب";
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelGridArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Button btnPaySelected;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelGridArea;
        private System.Windows.Forms.DataGridView dgvPayroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaseSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
