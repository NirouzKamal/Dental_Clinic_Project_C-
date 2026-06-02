namespace DentalClinicProject.UI
{
    partial class RevenuesControlUI
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.tlpKPIs = new System.Windows.Forms.TableLayoutPanel();
            this.panelKPI1 = new System.Windows.Forms.Panel();
            this.lblTotalIncomeValue = new System.Windows.Forms.Label();
            this.lblTotalIncomeTitle = new System.Windows.Forms.Label();
            this.panelKPI2 = new System.Windows.Forms.Panel();
            this.lblTotalExpensesValue = new System.Windows.Forms.Label();
            this.lblTotalExpensesTitle = new System.Windows.Forms.Label();
            this.panelKPI3 = new System.Windows.Forms.Panel();
            this.lblNetProfitValue = new System.Windows.Forms.Label();
            this.lblNetProfitTitle = new System.Windows.Forms.Label();
            this.panelKPI4 = new System.Windows.Forms.Panel();
            this.lblPendingDuesValue = new System.Windows.Forms.Label();
            this.lblPendingDuesTitle = new System.Windows.Forms.Label();
            this.panelFilterBar = new System.Windows.Forms.Panel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelToggles = new System.Windows.Forms.Panel();
            this.rdoIncome = new System.Windows.Forms.RadioButton();
            this.rdoExpenses = new System.Windows.Forms.RadioButton();
            this.panelGridArea = new System.Windows.Forms.Panel();
            this.dgvRevenues = new System.Windows.Forms.DataGridView();
            this.tlpKPIs.SuspendLayout();
            this.panelKPI1.SuspendLayout();
            this.panelKPI2.SuspendLayout();
            this.panelKPI3.SuspendLayout();
            this.panelKPI4.SuspendLayout();
            this.panelFilterBar.SuspendLayout();
            this.panelToggles.SuspendLayout();
            this.panelGridArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenues)).BeginInit();
            this.colFileNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuspendLayout();
            // 
            // tlpKPIs - same pattern as DashboardControlUI but with revenue labels
            // 
            this.tlpKPIs.ColumnCount = 4;
            this.tlpKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKPIs.Controls.Add(this.panelKPI1, 0, 0);
            this.tlpKPIs.Controls.Add(this.panelKPI2, 1, 0);
            this.tlpKPIs.Controls.Add(this.panelKPI3, 2, 0);
            this.tlpKPIs.Controls.Add(this.panelKPI4, 3, 0);
            this.tlpKPIs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpKPIs.Name = "tlpKPIs";
            this.tlpKPIs.Padding = new System.Windows.Forms.Padding(20);
            this.tlpKPIs.RowCount = 1;
            this.tlpKPIs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKPIs.Size = new System.Drawing.Size(934, 150);
            // panelKPI1
            this.panelKPI1.BackColor = System.Drawing.Color.White; this.panelKPI1.Dock = System.Windows.Forms.DockStyle.Fill; this.panelKPI1.Margin = new System.Windows.Forms.Padding(10); this.panelKPI1.Name = "panelKPI1";
            this.panelKPI1.Controls.Add(this.lblTotalIncomeValue); this.panelKPI1.Controls.Add(this.lblTotalIncomeTitle);
            this.lblTotalIncomeTitle.Dock = System.Windows.Forms.DockStyle.Top; this.lblTotalIncomeTitle.Font = new System.Drawing.Font("Times New Roman", 12F); this.lblTotalIncomeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125))))); this.lblTotalIncomeTitle.Size = new System.Drawing.Size(180, 30); this.lblTotalIncomeTitle.Text = "إجمالي الإيرادات"; this.lblTotalIncomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; this.lblTotalIncomeTitle.Name = "lblTotalIncomeTitle";
            this.lblTotalIncomeValue.Dock = System.Windows.Forms.DockStyle.Fill; this.lblTotalIncomeValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold); this.lblTotalIncomeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155))))); this.lblTotalIncomeValue.Text = "0 د.ل"; this.lblTotalIncomeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; this.lblTotalIncomeValue.Name = "lblTotalIncomeValue";
            // panelKPI2
            this.panelKPI2.BackColor = System.Drawing.Color.White; this.panelKPI2.Dock = System.Windows.Forms.DockStyle.Fill; this.panelKPI2.Margin = new System.Windows.Forms.Padding(10); this.panelKPI2.Name = "panelKPI2";
            this.panelKPI2.Controls.Add(this.lblTotalExpensesValue); this.panelKPI2.Controls.Add(this.lblTotalExpensesTitle);
            this.lblTotalExpensesTitle.Dock = System.Windows.Forms.DockStyle.Top; this.lblTotalExpensesTitle.Font = new System.Drawing.Font("Times New Roman", 12F); this.lblTotalExpensesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125))))); this.lblTotalExpensesTitle.Size = new System.Drawing.Size(180, 30); this.lblTotalExpensesTitle.Text = "إجمالي المصروفات (الرواتب)"; this.lblTotalExpensesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; this.lblTotalExpensesTitle.Name = "lblTotalExpensesTitle";
            this.lblTotalExpensesValue.Dock = System.Windows.Forms.DockStyle.Fill; this.lblTotalExpensesValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold); this.lblTotalExpensesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155))))); this.lblTotalExpensesValue.Text = "0 د.ل"; this.lblTotalExpensesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; this.lblTotalExpensesValue.Name = "lblTotalExpensesValue";
            // panelKPI3
            this.panelKPI3.BackColor = System.Drawing.Color.White; this.panelKPI3.Dock = System.Windows.Forms.DockStyle.Fill; this.panelKPI3.Margin = new System.Windows.Forms.Padding(10); this.panelKPI3.Name = "panelKPI3";
            this.panelKPI3.Controls.Add(this.lblNetProfitValue); this.panelKPI3.Controls.Add(this.lblNetProfitTitle);
            this.lblNetProfitTitle.Dock = System.Windows.Forms.DockStyle.Top; this.lblNetProfitTitle.Font = new System.Drawing.Font("Times New Roman", 12F); this.lblNetProfitTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125); this.lblNetProfitTitle.Size = new System.Drawing.Size(180, 30); this.lblNetProfitTitle.Text = "صافي أرباح العيادة"; this.lblNetProfitTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; this.lblNetProfitTitle.Name = "lblNetProfitTitle";
            this.lblNetProfitValue.Dock = System.Windows.Forms.DockStyle.Fill; this.lblNetProfitValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold); this.lblNetProfitValue.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69); this.lblNetProfitValue.Text = "0 د.ل"; this.lblNetProfitValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; this.lblNetProfitValue.Name = "lblNetProfitValue";
            // panelKPI4
            this.panelKPI4.BackColor = System.Drawing.Color.White; this.panelKPI4.Dock = System.Windows.Forms.DockStyle.Fill; this.panelKPI4.Margin = new System.Windows.Forms.Padding(10); this.panelKPI4.Name = "panelKPI4";
            this.panelKPI4.Controls.Add(this.lblPendingDuesValue); this.panelKPI4.Controls.Add(this.lblPendingDuesTitle);
            this.lblPendingDuesTitle.Dock = System.Windows.Forms.DockStyle.Top; this.lblPendingDuesTitle.Font = new System.Drawing.Font("Times New Roman", 12F); this.lblPendingDuesTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125); this.lblPendingDuesTitle.Size = new System.Drawing.Size(180, 30); this.lblPendingDuesTitle.Text = "مستحقات الأطباء (قيد الانتظار)"; this.lblPendingDuesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; this.lblPendingDuesTitle.Name = "lblPendingDuesTitle";
            this.lblPendingDuesValue.Dock = System.Windows.Forms.DockStyle.Fill; this.lblPendingDuesValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold); this.lblPendingDuesValue.ForeColor = System.Drawing.Color.FromArgb(0, 75, 155); this.lblPendingDuesValue.Text = "0 د.ل"; this.lblPendingDuesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; this.lblPendingDuesValue.Name = "lblPendingDuesValue";
            // 
            // panelFilterBar
            // 
            this.panelFilterBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterBar.Location = new System.Drawing.Point(0, 150);
            this.panelFilterBar.Name = "panelFilterBar";
            this.panelFilterBar.Padding = new System.Windows.Forms.Padding(20);
            this.panelFilterBar.Size = new System.Drawing.Size(934, 80);
            
            this.flowLayoutPanelInputs = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelInputs.Name = "flowLayoutPanelInputs";
            this.flowLayoutPanelInputs.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            
            this.flowLayoutPanelInputs.Controls.Add(this.lblFrom);
            this.flowLayoutPanelInputs.Controls.Add(this.dtpFrom);
            this.flowLayoutPanelInputs.Controls.Add(this.lblTo);
            this.flowLayoutPanelInputs.Controls.Add(this.dtpTo);
            this.flowLayoutPanelInputs.Controls.Add(this.cmbDoctor);
            this.flowLayoutPanelInputs.Controls.Add(this.txtSearch);
            
            this.panelFilterBar.Controls.Add(this.flowLayoutPanelInputs);
            this.panelFilterBar.Controls.Add(this.panelToggles);
            
            // lblFrom
            this.lblFrom.AutoSize = true; this.lblFrom.Font = new System.Drawing.Font("Times New Roman", 12F); this.lblFrom.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0); this.lblFrom.Text = "من تاريخ:"; this.lblFrom.Name = "lblFrom";
            // dtpFrom
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpFrom.Name = "dtpFrom"; this.dtpFrom.Size = new System.Drawing.Size(110, 25);
            // lblTo
            this.lblTo.AutoSize = true; this.lblTo.Font = new System.Drawing.Font("Times New Roman", 12F); this.lblTo.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0); this.lblTo.Text = "إلى تاريخ:"; this.lblTo.Name = "lblTo";
            // dtpTo
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpTo.Name = "dtpTo"; this.dtpTo.Size = new System.Drawing.Size(110, 25);
            // cmbDoctor
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbDoctor.Font = new System.Drawing.Font("Times New Roman", 12F); this.cmbDoctor.Name = "cmbDoctor"; this.cmbDoctor.Size = new System.Drawing.Size(150, 25);
            // txtSearch
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F); this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125))))); this.txtSearch.Name = "txtSearch"; this.txtSearch.Size = new System.Drawing.Size(180, 25); this.txtSearch.Text = "ابحث بالرقم أو الاسم...";
            // panelToggles
            this.panelToggles.Dock = System.Windows.Forms.DockStyle.Right; this.panelToggles.Name = "panelToggles"; this.panelToggles.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5); this.panelToggles.Size = new System.Drawing.Size(200, 40);
            this.panelToggles.Controls.Add(this.rdoExpenses);
            this.panelToggles.Controls.Add(this.rdoIncome);
            // rdoIncome
            this.rdoIncome.Checked = true; this.rdoIncome.Cursor = System.Windows.Forms.Cursors.Hand; this.rdoIncome.Dock = System.Windows.Forms.DockStyle.Right; this.rdoIncome.Font = new System.Drawing.Font("Times New Roman", 12F); this.rdoIncome.Name = "rdoIncome"; this.rdoIncome.Text = "عرض الإيرادات"; this.rdoIncome.Size = new System.Drawing.Size(100, 30);
            // rdoExpenses
            this.rdoExpenses.Cursor = System.Windows.Forms.Cursors.Hand; this.rdoExpenses.Dock = System.Windows.Forms.DockStyle.Right; this.rdoExpenses.Font = new System.Drawing.Font("Times New Roman", 12F); this.rdoExpenses.Name = "rdoExpenses"; this.rdoExpenses.Text = "عرض المصروفات"; this.rdoExpenses.Size = new System.Drawing.Size(100, 30);
            // 
            // panelGridArea
            // 
            this.panelGridArea.Controls.Add(this.dgvRevenues);
            this.panelGridArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridArea.Location = new System.Drawing.Point(0, 200);
            this.panelGridArea.Name = "panelGridArea";
            this.panelGridArea.Padding = new System.Windows.Forms.Padding(20);
            // 
            // dgvRevenues
            // 
            this.dgvRevenues.AllowUserToAddRows = false; this.dgvRevenues.AllowUserToDeleteRows = false;
            this.dgvRevenues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevenues.BackgroundColor = System.Drawing.Color.White; this.dgvRevenues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRevenues.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRevenues.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRevenues.ColumnHeadersHeight = 40; this.dgvRevenues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRevenues.EnableHeadersVisualStyles = false; this.dgvRevenues.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.dgvRevenues.Name = "dgvRevenues"; this.dgvRevenues.ReadOnly = true;
            this.dgvRevenues.RightToLeft = System.Windows.Forms.RightToLeft.Yes; this.dgvRevenues.RowHeadersVisible = false;
            this.dgvRevenues.RowTemplate.Height = 45; this.dgvRevenues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // Income default columns
                        this.dgvRevenues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colFileNum, this.colPatientName, this.colDoctor, this.colTreatment, this.colPaid });
            // Column Definitions
            this.colFileNum.HeaderText = "رقم الملف";
            this.colFileNum.Name = "colFileNum";
            this.colFileNum.ReadOnly = true;
            this.colPatientName.HeaderText = "اسم الحالة";
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.ReadOnly = true;
            this.colDoctor.HeaderText = "اسم الطبيب";
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.ReadOnly = true;
            this.colTreatment.HeaderText = "العلاج";
            this.colTreatment.Name = "colTreatment";
            this.colTreatment.ReadOnly = true;
            this.colPaid.HeaderText = "المدفوع";
            this.colPaid.Name = "colPaid";
            this.colPaid.ReadOnly = true;

            
            
            
            
            // 
            // RevenuesControlUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.Controls.Add(this.panelGridArea);
            this.Controls.Add(this.panelFilterBar);
            this.Controls.Add(this.tlpKPIs);
            this.Name = "RevenuesControlUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(934, 600);
            this.tlpKPIs.ResumeLayout(false);
            this.panelKPI1.ResumeLayout(false); this.panelKPI2.ResumeLayout(false);
            this.panelKPI3.ResumeLayout(false); this.panelKPI4.ResumeLayout(false);
            this.panelFilterBar.ResumeLayout(false); this.panelFilterBar.PerformLayout();
            this.panelToggles.ResumeLayout(false);
            this.panelGridArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenues)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpKPIs;
        private System.Windows.Forms.Panel panelKPI1; private System.Windows.Forms.Label lblTotalIncomeValue; private System.Windows.Forms.Label lblTotalIncomeTitle;
        private System.Windows.Forms.Panel panelKPI2; private System.Windows.Forms.Label lblTotalExpensesValue; private System.Windows.Forms.Label lblTotalExpensesTitle;
        private System.Windows.Forms.Panel panelKPI3; private System.Windows.Forms.Label lblNetProfitValue; private System.Windows.Forms.Label lblNetProfitTitle;
        private System.Windows.Forms.Panel panelKPI4; private System.Windows.Forms.Label lblPendingDuesValue; private System.Windows.Forms.Label lblPendingDuesTitle;
        private System.Windows.Forms.Panel panelFilterBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelInputs;
        private System.Windows.Forms.Label lblFrom; private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo; private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cmbDoctor; private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelToggles;
        private System.Windows.Forms.RadioButton rdoIncome; private System.Windows.Forms.RadioButton rdoExpenses;
        private System.Windows.Forms.Panel panelGridArea;
        private System.Windows.Forms.DataGridView dgvRevenues;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaid;
    }
}




