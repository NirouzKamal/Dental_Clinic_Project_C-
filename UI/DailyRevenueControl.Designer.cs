namespace DentalClinicProject.UI
{
    partial class DailyRevenueControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpSummaryCards = new System.Windows.Forms.TableLayoutPanel();
            this.panelCardCases = new System.Windows.Forms.Panel();
            this.lblTotalCasesValue = new System.Windows.Forms.Label();
            this.lblTotalCasesTitle = new System.Windows.Forms.Label();
            this.panelCardRevenue = new System.Windows.Forms.Panel();
            this.lblTotalRevenueValue = new System.Windows.Forms.Label();
            this.lblTotalRevenueTitle = new System.Windows.Forms.Label();
            this.panelFilterBar = new System.Windows.Forms.Panel();
            this.flowFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvDailyCases = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.flowFooterButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConfirmClosure = new System.Windows.Forms.Button();
            this.btnPrintFooter = new System.Windows.Forms.Button();
            this.flowFooterTotals = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFooterTotalRevenue = new System.Windows.Forms.Label();
            this.lblFooterDoctorShares = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.tlpSummaryCards.SuspendLayout();
            this.panelCardCases.SuspendLayout();
            this.panelCardRevenue.SuspendLayout();
            this.panelFilterBar.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyCases)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.flowFooterButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(27, 20, 27, 10);
            this.panelHeader.Size = new System.Drawing.Size(1245, 69);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(27, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(1191, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📊 إغلاق إيرادات اليوم";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlpSummaryCards
            // 
            this.tlpSummaryCards.ColumnCount = 2;
            this.tlpSummaryCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSummaryCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSummaryCards.Controls.Add(this.panelCardCases, 0, 0);
            this.tlpSummaryCards.Controls.Add(this.panelCardRevenue, 1, 0);
            this.tlpSummaryCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpSummaryCards.Location = new System.Drawing.Point(0, 69);
            this.tlpSummaryCards.Margin = new System.Windows.Forms.Padding(4);
            this.tlpSummaryCards.Name = "tlpSummaryCards";
            this.tlpSummaryCards.Padding = new System.Windows.Forms.Padding(21, 10, 21, 10);
            this.tlpSummaryCards.RowCount = 1;
            this.tlpSummaryCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSummaryCards.Size = new System.Drawing.Size(1245, 160);
            this.tlpSummaryCards.TabIndex = 1;
            // 
            // panelCardCases
            // 
            this.panelCardCases.BackColor = System.Drawing.Color.White;
            this.panelCardCases.Controls.Add(this.lblTotalCasesValue);
            this.panelCardCases.Controls.Add(this.lblTotalCasesTitle);
            this.panelCardCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardCases.Location = new System.Drawing.Point(634, 20);
            this.panelCardCases.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panelCardCases.Name = "panelCardCases";
            this.panelCardCases.Padding = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.panelCardCases.Size = new System.Drawing.Size(579, 120);
            this.panelCardCases.TabIndex = 0;
            // 
            // lblTotalCasesValue
            // 
            this.lblTotalCasesValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCasesValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalCasesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.lblTotalCasesValue.Location = new System.Drawing.Point(16, 49);
            this.lblTotalCasesValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCasesValue.Name = "lblTotalCasesValue";
            this.lblTotalCasesValue.Size = new System.Drawing.Size(547, 56);
            this.lblTotalCasesValue.TabIndex = 1;
            this.lblTotalCasesValue.Text = "0";
            this.lblTotalCasesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCasesTitle
            // 
            this.lblTotalCasesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalCasesTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalCasesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTotalCasesTitle.Location = new System.Drawing.Point(16, 15);
            this.lblTotalCasesTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCasesTitle.Name = "lblTotalCasesTitle";
            this.lblTotalCasesTitle.Size = new System.Drawing.Size(547, 34);
            this.lblTotalCasesTitle.TabIndex = 0;
            this.lblTotalCasesTitle.Text = "📋 إجمالي الحالات";
            this.lblTotalCasesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCardRevenue
            // 
            this.panelCardRevenue.BackColor = System.Drawing.Color.White;
            this.panelCardRevenue.Controls.Add(this.lblTotalRevenueValue);
            this.panelCardRevenue.Controls.Add(this.lblTotalRevenueTitle);
            this.panelCardRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardRevenue.Location = new System.Drawing.Point(32, 20);
            this.panelCardRevenue.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panelCardRevenue.Name = "panelCardRevenue";
            this.panelCardRevenue.Padding = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.panelCardRevenue.Size = new System.Drawing.Size(580, 120);
            this.panelCardRevenue.TabIndex = 1;
            // 
            // lblTotalRevenueValue
            // 
            this.lblTotalRevenueValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalRevenueValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.lblTotalRevenueValue.Location = new System.Drawing.Point(16, 49);
            this.lblTotalRevenueValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            this.lblTotalRevenueValue.Size = new System.Drawing.Size(548, 56);
            this.lblTotalRevenueValue.TabIndex = 1;
            this.lblTotalRevenueValue.Text = "0.00 د.ل";
            this.lblTotalRevenueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalRevenueTitle
            // 
            this.lblTotalRevenueTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTotalRevenueTitle.Location = new System.Drawing.Point(16, 15);
            this.lblTotalRevenueTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRevenueTitle.Name = "lblTotalRevenueTitle";
            this.lblTotalRevenueTitle.Size = new System.Drawing.Size(548, 34);
            this.lblTotalRevenueTitle.TabIndex = 0;
            this.lblTotalRevenueTitle.Text = "💰 إجمالي الإيرادات";
            this.lblTotalRevenueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFilterBar
            // 
            this.panelFilterBar.Controls.Add(this.flowFilter);
            this.panelFilterBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterBar.Location = new System.Drawing.Point(0, 229);
            this.panelFilterBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelFilterBar.Name = "panelFilterBar";
            this.panelFilterBar.Padding = new System.Windows.Forms.Padding(27, 6, 27, 6);
            this.panelFilterBar.Size = new System.Drawing.Size(1245, 44);
            this.panelFilterBar.TabIndex = 2;
            // 
            // flowFilter
            // 
            this.flowFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowFilter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowFilter.Location = new System.Drawing.Point(27, 6);
            this.flowFilter.Margin = new System.Windows.Forms.Padding(4);
            this.flowFilter.Name = "flowFilter";
            this.flowFilter.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowFilter.Size = new System.Drawing.Size(1191, 32);
            this.flowFilter.TabIndex = 0;
            this.flowFilter.WrapContents = false;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dgvDailyCases);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 273);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(4);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(27, 0, 27, 10);
            this.panelGrid.Size = new System.Drawing.Size(1245, 376);
            this.panelGrid.TabIndex = 3;
            // 
            // dgvDailyCases
            // 
            this.dgvDailyCases.AllowUserToAddRows = false;
            this.dgvDailyCases.AllowUserToDeleteRows = false;
            this.dgvDailyCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDailyCases.BackgroundColor = System.Drawing.Color.White;
            this.dgvDailyCases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDailyCases.ColumnHeadersHeight = 42;
            this.dgvDailyCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDailyCases.EnableHeadersVisualStyles = false;
            this.dgvDailyCases.Location = new System.Drawing.Point(27, 0);
            this.dgvDailyCases.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDailyCases.Name = "dgvDailyCases";
            this.dgvDailyCases.ReadOnly = true;
            this.dgvDailyCases.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDailyCases.RowHeadersVisible = false;
            this.dgvDailyCases.RowHeadersWidth = 51;
            this.dgvDailyCases.RowTemplate.Height = 40;
            this.dgvDailyCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDailyCases.Size = new System.Drawing.Size(1191, 366);
            this.dgvDailyCases.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.flowFooterButtons);
            this.panelFooter.Controls.Add(this.flowFooterTotals);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 649);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(27, 15, 27, 20);
            this.panelFooter.Size = new System.Drawing.Size(1245, 89);
            this.panelFooter.TabIndex = 4;
            // 
            // flowFooterButtons
            // 
            this.flowFooterButtons.Controls.Add(this.btnConfirmClosure);
            this.flowFooterButtons.Controls.Add(this.btnPrintFooter);
            this.flowFooterButtons.Controls.Add(this.lblFooterDoctorShares);
            this.flowFooterButtons.Controls.Add(this.lblFooterTotalRevenue);
            this.flowFooterButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowFooterButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowFooterButtons.Location = new System.Drawing.Point(27, 15);
            this.flowFooterButtons.Margin = new System.Windows.Forms.Padding(4);
            this.flowFooterButtons.Name = "flowFooterButtons";
            this.flowFooterButtons.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowFooterButtons.Size = new System.Drawing.Size(1191, 54);
            this.flowFooterButtons.TabIndex = 1;
            this.flowFooterButtons.WrapContents = false;
            // 
            // btnConfirmClosure
            // 
            this.btnConfirmClosure.Location = new System.Drawing.Point(0, 4);
            this.btnConfirmClosure.Margin = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btnConfirmClosure.Name = "btnConfirmClosure";
            this.btnConfirmClosure.Size = new System.Drawing.Size(213, 34);
            this.btnConfirmClosure.TabIndex = 0;
            this.btnConfirmClosure.Text = "✅ تأكيد إغلاق اليوم";
            this.btnConfirmClosure.UseVisualStyleBackColor = true;
            // 
            // btnPrintFooter
            // 
            this.btnPrintFooter.Location = new System.Drawing.Point(224, 4);
            this.btnPrintFooter.Margin = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btnPrintFooter.Name = "btnPrintFooter";
            this.btnPrintFooter.Size = new System.Drawing.Size(187, 34);
            this.btnPrintFooter.TabIndex = 1;
            this.btnPrintFooter.Text = "🖨️ طباعة التقرير";
            this.btnPrintFooter.UseVisualStyleBackColor = true;
            // 
            // flowFooterTotals
            // 
            this.flowFooterTotals.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowFooterTotals.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowFooterTotals.Location = new System.Drawing.Point(27, 15);
            this.flowFooterTotals.Margin = new System.Windows.Forms.Padding(4);
            this.flowFooterTotals.Name = "flowFooterTotals";
            this.flowFooterTotals.Size = new System.Drawing.Size(1191, 0);
            this.flowFooterTotals.TabIndex = 0;
            this.flowFooterTotals.Visible = false;
            // 
            // lblFooterTotalRevenue
            // 
            this.lblFooterTotalRevenue.AutoSize = true;
            this.lblFooterTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFooterTotalRevenue.Location = new System.Drawing.Point(724, 2);
            this.lblFooterTotalRevenue.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblFooterTotalRevenue.Name = "lblFooterTotalRevenue";
            this.lblFooterTotalRevenue.Size = new System.Drawing.Size(226, 23);
            this.lblFooterTotalRevenue.TabIndex = 0;
            this.lblFooterTotalRevenue.Text = "📈 إجمالي الإيرادات: 0.00 د.ل";
            // 
            // lblFooterDoctorShares
            // 
            this.lblFooterDoctorShares.AutoSize = true;
            this.lblFooterDoctorShares.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFooterDoctorShares.Location = new System.Drawing.Point(422, 2);
            this.lblFooterDoctorShares.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblFooterDoctorShares.Name = "lblFooterDoctorShares";
            this.lblFooterDoctorShares.Size = new System.Drawing.Size(286, 23);
            this.lblFooterDoctorShares.TabIndex = 1;
            this.lblFooterDoctorShares.Text = "👨‍⚕️ إجمالي مستحقات الأطباء: 0.00 د.ل";
            // 
            // DailyRevenueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelFilterBar);
            this.Controls.Add(this.tlpSummaryCards);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DailyRevenueControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1245, 738);
            this.panelHeader.ResumeLayout(false);
            this.tlpSummaryCards.ResumeLayout(false);
            this.panelCardCases.ResumeLayout(false);
            this.panelCardRevenue.ResumeLayout(false);
            this.panelFilterBar.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyCases)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.flowFooterButtons.ResumeLayout(false);
            this.flowFooterButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpSummaryCards;
        private System.Windows.Forms.Panel panelCardCases;
        private System.Windows.Forms.Label lblTotalCasesValue;
        private System.Windows.Forms.Label lblTotalCasesTitle;
        private System.Windows.Forms.Panel panelCardRevenue;
        private System.Windows.Forms.Label lblTotalRevenueValue;
        private System.Windows.Forms.Label lblTotalRevenueTitle;
        private System.Windows.Forms.Panel panelFilterBar;
        private System.Windows.Forms.FlowLayoutPanel flowFilter;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvDailyCases;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.FlowLayoutPanel flowFooterTotals;
        private System.Windows.Forms.FlowLayoutPanel flowFooterButtons;
        private System.Windows.Forms.Button btnPrintFooter;
        private System.Windows.Forms.Button btnConfirmClosure;
        private System.Windows.Forms.Label lblFooterDoctorShares;
        private System.Windows.Forms.Label lblFooterTotalRevenue;
    }
}
