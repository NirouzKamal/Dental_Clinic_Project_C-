namespace DentalClinicProject.UI
{
    partial class MyPatientsFormUI
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
            this.panelGridArea = new System.Windows.Forms.Panel();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelActionBar.SuspendLayout();
            this.panelGridArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.colFileNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuspendLayout();
            // panelHeader
            this.panelHeader.Controls.Add(this.lblTitle); this.panelHeader.Controls.Add(this.panelHeaderBorder);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top; this.panelHeader.Name = "panelHeader"; this.panelHeader.Size = new System.Drawing.Size(800, 50);
            this.lblTitle.AutoSize = true; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41); this.lblTitle.Location = new System.Drawing.Point(20, 15); this.lblTitle.Name = "lblTitle"; this.lblTitle.Text = "مرضاي";
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(222, 226, 230); this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom; this.panelHeaderBorder.Name = "panelHeaderBorder"; this.panelHeaderBorder.Size = new System.Drawing.Size(800, 1);
            // panelActionBar
            this.panelActionBar.Controls.Add(this.txtSearch);
            this.panelActionBar.Dock = System.Windows.Forms.DockStyle.Top; this.panelActionBar.Name = "panelActionBar"; this.panelActionBar.Padding = new System.Windows.Forms.Padding(20); this.panelActionBar.Size = new System.Drawing.Size(800, 80);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left; this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125); this.txtSearch.Name = "txtSearch"; this.txtSearch.Size = new System.Drawing.Size(300, 25); this.txtSearch.Text = "ابحث باسم المريض أو رقم الملف...";
            // panelGridArea
            this.panelGridArea.Controls.Add(this.dgvPatients); this.panelGridArea.Dock = System.Windows.Forms.DockStyle.Fill; this.panelGridArea.Name = "panelGridArea"; this.panelGridArea.Padding = new System.Windows.Forms.Padding(20);
            // dgvPatients
            this.dgvPatients.AllowUserToAddRows = false; this.dgvPatients.AllowUserToDeleteRows = false; this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; this.dgvPatients.BackgroundColor = System.Drawing.Color.White; this.dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal; this.dgvPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None; this.dgvPatients.ColumnHeadersHeight = 40; this.dgvPatients.Dock = System.Windows.Forms.DockStyle.Fill; this.dgvPatients.EnableHeadersVisualStyles = false; this.dgvPatients.GridColor = System.Drawing.Color.FromArgb(222, 226, 230); this.dgvPatients.Name = "dgvPatients"; this.dgvPatients.ReadOnly = true; this.dgvPatients.RightToLeft = System.Windows.Forms.RightToLeft.Yes; this.dgvPatients.RowHeadersVisible = false; this.dgvPatients.RowTemplate.Height = 45; this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                        this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colFileNum, this.colName, this.colPhone, this.colLastVisit, this.colNotes });
            // Column Definitions
            this.colFileNum.HeaderText = "رقم الملف";
            this.colFileNum.Name = "colFileNum";
            this.colFileNum.ReadOnly = true;
            this.colName.HeaderText = "اسم المريض";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colPhone.HeaderText = "رقم الهاتف";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colLastVisit.HeaderText = "آخر زيارة";
            this.colLastVisit.Name = "colLastVisit";
            this.colLastVisit.ReadOnly = true;
            this.colNotes.HeaderText = "ملاحظات";
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;

            
            
            
            
            // 
            // MyPatientsFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelGridArea); this.Controls.Add(this.panelActionBar); this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false; this.MinimizeBox = false;
            this.Name = "MyPatientsFormUI"; this.RightToLeft = System.Windows.Forms.RightToLeft.Yes; this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; this.Text = "مرضاي";
            this.panelHeader.ResumeLayout(false); this.panelHeader.PerformLayout();
            this.panelActionBar.ResumeLayout(false); this.panelActionBar.PerformLayout();
            this.panelGridArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader; private System.Windows.Forms.Label lblTitle; private System.Windows.Forms.Panel panelHeaderBorder;
        private System.Windows.Forms.Panel panelActionBar; private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelGridArea; private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
    }
}




