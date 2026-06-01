namespace DentalClinicProject.UI
{
    partial class PendingInvoicesFormUI
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHeaderBorder = new System.Windows.Forms.Panel();
            this.panelActionBar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.panelGridArea = new System.Windows.Forms.Panel();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelActionBar.SuspendLayout();
            this.panelGridArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.colInvNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuspendLayout();
            // panelHeader
            this.panelHeader.Controls.Add(this.lblTitle); this.panelHeader.Controls.Add(this.panelHeaderBorder);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top; this.panelHeader.Name = "panelHeader"; this.panelHeader.Size = new System.Drawing.Size(800, 50);
            this.lblTitle.AutoSize = true; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41); this.lblTitle.Location = new System.Drawing.Point(20, 15); this.lblTitle.Name = "lblTitle"; this.lblTitle.Text = "الفواتير المعلقة";
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(222, 226, 230); this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom; this.panelHeaderBorder.Name = "panelHeaderBorder"; this.panelHeaderBorder.Size = new System.Drawing.Size(800, 1);
            // panelActionBar
            this.panelActionBar.Controls.Add(this.txtSearch); this.panelActionBar.Controls.Add(this.btnPay);
            this.panelActionBar.Dock = System.Windows.Forms.DockStyle.Top; this.panelActionBar.Name = "panelActionBar"; this.panelActionBar.Padding = new System.Windows.Forms.Padding(20); this.panelActionBar.Size = new System.Drawing.Size(800, 80);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left; this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125); this.txtSearch.Name = "txtSearch"; this.txtSearch.Size = new System.Drawing.Size(300, 25); this.txtSearch.Text = "ابحث باسم المريض أو رقم الفاتورة...";
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand; this.btnPay.Dock = System.Windows.Forms.DockStyle.Right; this.btnPay.FlatAppearance.BorderSize = 0; this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnPay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.btnPay.ForeColor = System.Drawing.Color.White; this.btnPay.Name = "btnPay"; this.btnPay.Size = new System.Drawing.Size(120, 40); this.btnPay.Text = "دفع الفاتورة"; this.btnPay.UseVisualStyleBackColor = false;
            // panelGridArea
            this.panelGridArea.Controls.Add(this.dgvInvoices); this.panelGridArea.Dock = System.Windows.Forms.DockStyle.Fill; this.panelGridArea.Name = "panelGridArea"; this.panelGridArea.Padding = new System.Windows.Forms.Padding(20);
            // dgvInvoices
            this.dgvInvoices.AllowUserToAddRows = false; this.dgvInvoices.AllowUserToDeleteRows = false; this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; this.dgvInvoices.BackgroundColor = System.Drawing.Color.White; this.dgvInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvInvoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal; this.dgvInvoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None; this.dgvInvoices.ColumnHeadersHeight = 40; this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill; this.dgvInvoices.EnableHeadersVisualStyles = false; this.dgvInvoices.GridColor = System.Drawing.Color.FromArgb(222, 226, 230); this.dgvInvoices.Name = "dgvInvoices"; this.dgvInvoices.ReadOnly = true; this.dgvInvoices.RightToLeft = System.Windows.Forms.RightToLeft.Yes; this.dgvInvoices.RowHeadersVisible = false; this.dgvInvoices.RowTemplate.Height = 45; this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                        this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colInvNum, this.colDate, this.colPatient, this.colTotal, this.colPaid, this.colRemaining });
            // Column Definitions
            this.colInvNum.HeaderText = "رقم الفاتورة";
            this.colInvNum.Name = "colInvNum";
            this.colInvNum.ReadOnly = true;
            this.colDate.HeaderText = "التاريخ";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colPatient.HeaderText = "اسم المريض";
            this.colPatient.Name = "colPatient";
            this.colPatient.ReadOnly = true;
            this.colTotal.HeaderText = "الإجمالي";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colPaid.HeaderText = "المدفوع";
            this.colPaid.Name = "colPaid";
            this.colPaid.ReadOnly = true;
            this.colRemaining.HeaderText = "المتبقي";
            this.colRemaining.Name = "colRemaining";
            this.colRemaining.ReadOnly = true;

            
            
            
            
            
            // 
            // PendingInvoicesFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelGridArea); this.Controls.Add(this.panelActionBar); this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false; this.MinimizeBox = false;
            this.Name = "PendingInvoicesFormUI"; this.RightToLeft = System.Windows.Forms.RightToLeft.Yes; this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; this.Text = "الفواتير المعلقة";
            this.panelHeader.ResumeLayout(false); this.panelHeader.PerformLayout();
            this.panelActionBar.ResumeLayout(false); this.panelActionBar.PerformLayout();
            this.panelGridArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader; private System.Windows.Forms.Label lblTitle; private System.Windows.Forms.Panel panelHeaderBorder;
        private System.Windows.Forms.Panel panelActionBar; private System.Windows.Forms.TextBox txtSearch; private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel panelGridArea; private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemaining;
    }
}




