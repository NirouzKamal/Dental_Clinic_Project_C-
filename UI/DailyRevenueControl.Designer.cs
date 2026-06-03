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
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(14, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 21);
            this.lblTitle.Text = "📊 إغلاق إيرادات اليوم";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelHeaderBorder
            // 
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeaderBorder.Location = new System.Drawing.Point(0, 59);
            this.panelHeaderBorder.Name = "panelHeaderBorder";
            this.panelHeaderBorder.Size = new System.Drawing.Size(900, 1);
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
            this.tlpSummary.Location = new System.Drawing.Point(0, 60);
            this.tlpSummary.Name = "tlpSummary";
            this.tlpSummary.Padding = new System.Windows.Forms.Padding(15);
            this.tlpSummary.RowCount = 1;
            this.tlpSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSummary.Size = new System.Drawing.Size(900, 130);
            this.tlpSummary.TabIndex = 1;
            // 
            // panelCasesCard
            // 
            this.panelCasesCard.BackColor = System.Drawing.Color.White;
            this.panelCasesCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCasesCard.Controls.Add(this.lblCasesValue);
            this.panelCasesCard.Controls.Add(this.lblCasesTitle);
            this.panelCasesCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCasesCard.Location = new System.Drawing.Point(453, 18);
            this.panelCasesCard.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panelCasesCard.Name = "panelCasesCard";
            this.panelCasesCard.Size = new System.Drawing.Size(412, 94);
            this.panelCasesCard.TabIndex = 0;
            // 
            // lblCasesValue
            // 
            this.lblCasesValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCasesValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCasesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.lblCasesValue.Location = new System.Drawing.Point(0, 30);
            this.lblCasesValue.Name = "lblCasesValue";
            this.lblCasesValue.Size = new System.Drawing.Size(410, 62);
            this.lblCasesValue.TabIndex = 1;
            this.lblCasesValue.Text = "0";
            this.lblCasesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCasesTitle
            // 
            this.lblCasesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCasesTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCasesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCasesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblCasesTitle.Name = "lblCasesTitle";
            this.lblCasesTitle.Size = new System.Drawing.Size(410, 30);
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
            this.panelRevenueCard.Location = new System.Drawing.Point(25, 18);
            this.panelRevenueCard.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panelRevenueCard.Name = "panelRevenueCard";
            this.panelRevenueCard.Size = new System.Drawing.Size(408, 94);
            this.panelRevenueCard.TabIndex = 1;
            // 
            // lblRevenueValue
            // 
            this.lblRevenueValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRevenueValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblRevenueValue.Location = new System.Drawing.Point(0, 30);
            this.lblRevenueValue.Name = "lblRevenueValue";
            this.lblRevenueValue.Size = new System.Drawing.Size(406, 62);
            this.lblRevenueValue.TabIndex = 1;
            this.lblRevenueValue.Text = "0.00 د.ل";
            this.lblRevenueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblRevenueTitle.Location = new System.Drawing.Point(0, 0);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(406, 30);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "إجمالي الإيرادات المحصلة";
            this.lblRevenueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGridContainer
            // 
            this.panelGridContainer.Controls.Add(this.dgvCases);
            this.panelGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridContainer.Location = new System.Drawing.Point(0, 190);
            this.panelGridContainer.Name = "panelGridContainer";
            this.panelGridContainer.Padding = new System.Windows.Forms.Padding(15);
            this.panelGridContainer.Size = new System.Drawing.Size(900, 260);
            this.panelGridContainer.TabIndex = 2;
            // 
            // dgvCases
            // 
            this.dgvCases.AllowUserToAddRows = false;
            this.dgvCases.AllowUserToDeleteRows = false;
            this.dgvCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCases.BackgroundColor = System.Drawing.Color.White;
            this.dgvCases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCases.ColumnHeadersHeight = 38;
            this.dgvCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCaseNumber,
            this.colPatientName,
            this.colDoctorName,
            this.colTreatment,
            this.colAmount});
            this.dgvCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCases.EnableHeadersVisualStyles = false;
            this.dgvCases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvCases.Location = new System.Drawing.Point(15, 15);
            this.dgvCases.Name = "dgvCases";
            this.dgvCases.ReadOnly = true;
            this.dgvCases.RowHeadersVisible = false;
            this.dgvCases.RowTemplate.Height = 38;
            this.dgvCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCases.Size = new System.Drawing.Size(870, 230);
            this.dgvCases.TabIndex = 0;
            // 
            // colCaseNumber
            // 
            this.colCaseNumber.HeaderText = "رقم الحالة";
            this.colCaseNumber.Name = "colCaseNumber";
            this.colCaseNumber.ReadOnly = true;
            // 
            // colPatientName
            // 
            this.colPatientName.HeaderText = "اسم الحالة";
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.ReadOnly = true;
            // 
            // colDoctorName
            // 
            this.colDoctorName.HeaderText = "الطبيب المعالج";
            this.colDoctorName.Name = "colDoctorName";
            this.colDoctorName.ReadOnly = true;
            // 
            // colTreatment
            // 
            this.colTreatment.HeaderText = "الخدمات المقدمة";
            this.colTreatment.Name = "colTreatment";
            this.colTreatment.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "المبلغ (د.ل)";
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
            this.panelFooter.Location = new System.Drawing.Point(0, 450);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(900, 100);
            this.panelFooter.TabIndex = 3;
            // 
            // lblFooterDoctorShare
            // 
            this.lblFooterDoctorShare.AutoSize = true;
            this.lblFooterDoctorShare.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFooterDoctorShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblFooterDoctorShare.Location = new System.Drawing.Point(20, 52);
            this.lblFooterDoctorShare.Name = "lblFooterDoctorShare";
            this.lblFooterDoctorShare.Size = new System.Drawing.Size(225, 19);
            this.lblFooterDoctorShare.TabIndex = 3;
            this.lblFooterDoctorShare.Text = "👨‍⚕️ إجمالي مستحقات الأطباء: 0.00 د.ل";
            // 
            // lblFooterRevenue
            // 
            this.lblFooterRevenue.AutoSize = true;
            this.lblFooterRevenue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFooterRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblFooterRevenue.Location = new System.Drawing.Point(20, 20);
            this.lblFooterRevenue.Name = "lblFooterRevenue";
            this.lblFooterRevenue.Size = new System.Drawing.Size(206, 20);
            this.lblFooterRevenue.TabIndex = 2;
            this.lblFooterRevenue.Text = "📈 إجمالي الإيرادات: 0.00 د.ل";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnPrintReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintReport.FlatAppearance.BorderSize = 0;
            this.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrintReport.ForeColor = System.Drawing.Color.White;
            this.btnPrintReport.Location = new System.Drawing.Point(620, 30);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(120, 40);
            this.btnPrintReport.TabIndex = 1;
            this.btnPrintReport.Text = "🖨 طباعة التقرير";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            // 
            // btnConfirmClosure
            // 
            this.btnConfirmClosure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmClosure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConfirmClosure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmClosure.FlatAppearance.BorderSize = 0;
            this.btnConfirmClosure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmClosure.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmClosure.ForeColor = System.Drawing.Color.White;
            this.btnConfirmClosure.Location = new System.Drawing.Point(750, 30);
            this.btnConfirmClosure.Name = "btnConfirmClosure";
            this.btnConfirmClosure.Size = new System.Drawing.Size(135, 40);
            this.btnConfirmClosure.TabIndex = 0;
            this.btnConfirmClosure.Text = "✅ تأكيد إغلاق اليوم";
            this.btnConfirmClosure.UseVisualStyleBackColor = false;
            // 
            // DailyRevenueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panelGridContainer);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.tlpSummary);
            this.Controls.Add(this.panelHeader);
            this.Name = "DailyRevenueControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(900, 550);
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
