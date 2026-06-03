namespace DentalClinicProject.UI
{
    partial class DailyRevenueControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHeaderBorder = new System.Windows.Forms.Panel();
            this.tlpSummary = new System.Windows.Forms.TableLayoutPanel();
            this.panelCasesCard = new System.Windows.Forms.Panel();
            this.lblCasesValue = new System.Windows.Forms.Label();
            this.lblCasesTitle = new System.Windows.Forms.Label();
            this.panelRevenueCard = new System.Windows.Forms.Panel();
            this.lblRevenueValue = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.panelGridContainer = new System.Windows.Forms.Panel();
            this.dgvCases = new System.Windows.Forms.DataGridView();
            this.colCaseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblFooterDoctorShare = new System.Windows.Forms.Label();
            this.lblFooterRevenue = new System.Windows.Forms.Label();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnConfirmClosure = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.tlpSummary.SuspendLayout();
            this.panelCasesCard.SuspendLayout();
            this.panelRevenueCard.SuspendLayout();
            this.panelGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.panelHeaderBorder);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(2400, 143);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(37, 43);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(372, 61);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = " إغلاق إيرادات اليوم";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelHeaderBorder
            // 
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeaderBorder.Location = new System.Drawing.Point(0, 141);
            this.panelHeaderBorder.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelHeaderBorder.Name = "panelHeaderBorder";
            this.panelHeaderBorder.Size = new System.Drawing.Size(2400, 2);
            this.panelHeaderBorder.TabIndex = 1;
            // 
            // tlpSummary
            // 
            this.tlpSummary.ColumnCount = 2;
            this.tlpSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSummary.Controls.Add(this.panelCasesCard, 0, 0);
            this.tlpSummary.Controls.Add(this.panelRevenueCard, 1, 0);
            this.tlpSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpSummary.Location = new System.Drawing.Point(0, 143);
            this.tlpSummary.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tlpSummary.Name = "tlpSummary";
            this.tlpSummary.Padding = new System.Windows.Forms.Padding(40, 36, 40, 36);
            this.tlpSummary.RowCount = 1;
            this.tlpSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSummary.Size = new System.Drawing.Size(2400, 310);
            this.tlpSummary.TabIndex = 1;
            // 
            // panelCasesCard
            // 
            this.panelCasesCard.BackColor = System.Drawing.Color.White;
            this.panelCasesCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCasesCard.Controls.Add(this.lblCasesValue);
            this.panelCasesCard.Controls.Add(this.lblCasesTitle);
            this.panelCasesCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCasesCard.Location = new System.Drawing.Point(1227, 43);
            this.panelCasesCard.Margin = new System.Windows.Forms.Padding(27, 7, 27, 7);
            this.panelCasesCard.Name = "panelCasesCard";
            this.panelCasesCard.Size = new System.Drawing.Size(1106, 224);
            this.panelCasesCard.TabIndex = 0;
            // 
            // lblCasesValue
            // 
            this.lblCasesValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCasesValue.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.lblCasesValue.Location = new System.Drawing.Point(0, 72);
            this.lblCasesValue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCasesValue.Name = "lblCasesValue";
            this.lblCasesValue.Size = new System.Drawing.Size(1104, 150);
            this.lblCasesValue.TabIndex = 1;
            this.lblCasesValue.Text = "0";
            this.lblCasesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCasesTitle
            // 
            this.lblCasesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCasesTitle.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCasesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblCasesTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCasesTitle.Name = "lblCasesTitle";
            this.lblCasesTitle.Size = new System.Drawing.Size(1104, 72);
            this.lblCasesTitle.TabIndex = 0;
            this.lblCasesTitle.Text = "إجمالي الحالات المكتملة اليوم";
            this.lblCasesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRevenueCard
            // 
            this.panelRevenueCard.BackColor = System.Drawing.Color.White;
            this.panelRevenueCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRevenueCard.Controls.Add(this.lblRevenueValue);
            this.panelRevenueCard.Controls.Add(this.lblRevenueTitle);
            this.panelRevenueCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRevenueCard.Location = new System.Drawing.Point(67, 43);
            this.panelRevenueCard.Margin = new System.Windows.Forms.Padding(27, 7, 27, 7);
            this.panelRevenueCard.Name = "panelRevenueCard";
            this.panelRevenueCard.Size = new System.Drawing.Size(1106, 224);
            this.panelRevenueCard.TabIndex = 1;
            // 
            // lblRevenueValue
            // 
            this.lblRevenueValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRevenueValue.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblRevenueValue.Location = new System.Drawing.Point(0, 72);
            this.lblRevenueValue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblRevenueValue.Name = "lblRevenueValue";
            this.lblRevenueValue.Size = new System.Drawing.Size(1104, 150);
            this.lblRevenueValue.TabIndex = 1;
            this.lblRevenueValue.Text = "0.00 د.ل";
            this.lblRevenueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblRevenueTitle.Location = new System.Drawing.Point(0, 0);
            this.lblRevenueTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(1104, 72);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "إجمالي الإيرادات المحصلة";
            this.lblRevenueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGridContainer
            // 
            this.panelGridContainer.Controls.Add(this.dgvCases);
            this.panelGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridContainer.Location = new System.Drawing.Point(0, 453);
            this.panelGridContainer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelGridContainer.Name = "panelGridContainer";
            this.panelGridContainer.Padding = new System.Windows.Forms.Padding(40, 36, 40, 36);
            this.panelGridContainer.Size = new System.Drawing.Size(2400, 621);
            this.panelGridContainer.TabIndex = 2;
            // 
            // dgvCases
            // 
            this.dgvCases.AllowUserToAddRows = false;
            this.dgvCases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCases.BackgroundColor = System.Drawing.Color.White;
            this.dgvCases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCases.ColumnHeadersHeight = 38;
            this.dgvCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCaseNumber,
            this.colPatientName,
            this.colDoctorName,
            this.colTreatment,
            this.colAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCases.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCases.EnableHeadersVisualStyles = false;
            this.dgvCases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvCases.Location = new System.Drawing.Point(40, 36);
            this.dgvCases.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvCases.Name = "dgvCases";
            this.dgvCases.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCases.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCases.RowHeadersVisible = false;
            this.dgvCases.RowHeadersWidth = 102;
            this.dgvCases.RowTemplate.Height = 38;
            this.dgvCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCases.Size = new System.Drawing.Size(2320, 549);
            this.dgvCases.TabIndex = 0;
            // 
            // colCaseNumber
            // 
            this.colCaseNumber.HeaderText = "رقم الحالة";
            this.colCaseNumber.MinimumWidth = 12;
            this.colCaseNumber.Name = "colCaseNumber";
            this.colCaseNumber.ReadOnly = true;
            // 
            // colPatientName
            // 
            this.colPatientName.HeaderText = "اسم الحالة";
            this.colPatientName.MinimumWidth = 12;
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.ReadOnly = true;
            // 
            // colDoctorName
            // 
            this.colDoctorName.HeaderText = "الطبيب المعالج";
            this.colDoctorName.MinimumWidth = 12;
            this.colDoctorName.Name = "colDoctorName";
            this.colDoctorName.ReadOnly = true;
            // 
            // colTreatment
            // 
            this.colTreatment.HeaderText = "الخدمات المقدمة";
            this.colTreatment.MinimumWidth = 12;
            this.colTreatment.Name = "colTreatment";
            this.colTreatment.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "المبلغ (د.ل)";
            this.colAmount.MinimumWidth = 12;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.White;
            this.panelFooter.Controls.Add(this.lblFooterDoctorShare);
            this.panelFooter.Controls.Add(this.lblFooterRevenue);
            this.panelFooter.Controls.Add(this.btnPrintReport);
            this.panelFooter.Controls.Add(this.btnConfirmClosure);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 1074);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(2400, 238);
            this.panelFooter.TabIndex = 3;
            // 
            // lblFooterDoctorShare
            // 
            this.lblFooterDoctorShare.AutoSize = true;
            this.lblFooterDoctorShare.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooterDoctorShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblFooterDoctorShare.Location = new System.Drawing.Point(53, 124);
            this.lblFooterDoctorShare.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFooterDoctorShare.Name = "lblFooterDoctorShare";
            this.lblFooterDoctorShare.Size = new System.Drawing.Size(644, 61);
            this.lblFooterDoctorShare.TabIndex = 3;
            this.lblFooterDoctorShare.Text = " إجمالي مستحقات الأطباء: 0.00 د.ل";
            // 
            // lblFooterRevenue
            // 
            this.lblFooterRevenue.AutoSize = true;
            this.lblFooterRevenue.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooterRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblFooterRevenue.Location = new System.Drawing.Point(53, 48);
            this.lblFooterRevenue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFooterRevenue.Name = "lblFooterRevenue";
            this.lblFooterRevenue.Size = new System.Drawing.Size(516, 61);
            this.lblFooterRevenue.TabIndex = 2;
            this.lblFooterRevenue.Text = " إجمالي الإيرادات: 0.00 د.ل";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnPrintReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintReport.FlatAppearance.BorderSize = 0;
            this.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReport.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.ForeColor = System.Drawing.Color.White;
            this.btnPrintReport.Location = new System.Drawing.Point(1653, 72);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(320, 95);
            this.btnPrintReport.TabIndex = 1;
            this.btnPrintReport.Text = " طباعة التقرير";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            // 
            // btnConfirmClosure
            // 
            this.btnConfirmClosure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmClosure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConfirmClosure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmClosure.FlatAppearance.BorderSize = 0;
            this.btnConfirmClosure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmClosure.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmClosure.ForeColor = System.Drawing.Color.White;
            this.btnConfirmClosure.Location = new System.Drawing.Point(2000, 72);
            this.btnConfirmClosure.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnConfirmClosure.Name = "btnConfirmClosure";
            this.btnConfirmClosure.Size = new System.Drawing.Size(360, 95);
            this.btnConfirmClosure.TabIndex = 0;
            this.btnConfirmClosure.Text = " تأكيد إغلاق اليوم";
            this.btnConfirmClosure.UseVisualStyleBackColor = false;
            // 
            // DailyRevenueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panelGridContainer);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.tlpSummary);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "DailyRevenueControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(2400, 1312);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tlpSummary.ResumeLayout(false);
            this.panelCasesCard.ResumeLayout(false);
            this.panelRevenueCard.ResumeLayout(false);
            this.panelGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelHeaderBorder;
        private System.Windows.Forms.TableLayoutPanel tlpSummary;
        private System.Windows.Forms.Panel panelCasesCard;
        private System.Windows.Forms.Label lblCasesValue;
        private System.Windows.Forms.Label lblCasesTitle;
        private System.Windows.Forms.Panel panelRevenueCard;
        private System.Windows.Forms.Label lblRevenueValue;
        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.Panel panelGridContainer;
        private System.Windows.Forms.DataGridView dgvCases;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooterDoctorShare;
        private System.Windows.Forms.Label lblFooterRevenue;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnConfirmClosure;
    }
}
