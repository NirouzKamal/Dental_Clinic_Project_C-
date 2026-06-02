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
            this.panelGridArea = new System.Windows.Forms.Panel();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.panelActionBar = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colFileNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.panelGridArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.panelActionBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.panelHeaderBorder);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1980, 119);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(1690, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "حالات الإنتظار";
            // 
            // panelHeaderBorder
            // 
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeaderBorder.Location = new System.Drawing.Point(0, 117);
            this.panelHeaderBorder.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelHeaderBorder.Name = "panelHeaderBorder";
            this.panelHeaderBorder.Size = new System.Drawing.Size(1980, 2);
            this.panelHeaderBorder.TabIndex = 1;
            // 
            // panelGridArea
            // 
            this.panelGridArea.Controls.Add(this.dgvPatients);
            this.panelGridArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridArea.Location = new System.Drawing.Point(0, 226);
            this.panelGridArea.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelGridArea.Name = "panelGridArea";
            this.panelGridArea.Padding = new System.Windows.Forms.Padding(53, 48, 53, 48);
            this.panelGridArea.Size = new System.Drawing.Size(1980, 966);
            this.panelGridArea.TabIndex = 0;
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPatients.ColumnHeadersHeight = 40;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFileNum,
            this.colName,
            this.colNotes,
            this.colLastVisit});
            this.dgvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatients.EnableHeadersVisualStyles = false;
            this.dgvPatients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvPatients.Location = new System.Drawing.Point(53, 48);
            this.dgvPatients.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPatients.RowHeadersVisible = false;
            this.dgvPatients.RowHeadersWidth = 102;
            this.dgvPatients.RowTemplate.Height = 45;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(1874, 870);
            this.dgvPatients.TabIndex = 0;
            // 
            // panelActionBar
            // 
            this.panelActionBar.Controls.Add(this.textBox1);
            this.panelActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionBar.Location = new System.Drawing.Point(0, 119);
            this.panelActionBar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelActionBar.Name = "panelActionBar";
            this.panelActionBar.Padding = new System.Windows.Forms.Padding(53, 48, 53, 48);
            this.panelActionBar.Size = new System.Drawing.Size(1980, 107);
            this.panelActionBar.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1189, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(531, 38);
            this.textBox1.TabIndex = 1;
            // 
            // colFileNum
            // 
            this.colFileNum.HeaderText = "رقم الملف";
            this.colFileNum.MinimumWidth = 12;
            this.colFileNum.Name = "colFileNum";
            this.colFileNum.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "اسم المريض";
            this.colName.MinimumWidth = 12;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colNotes
            // 
            this.colNotes.HeaderText = "نوع الزيارة";
            this.colNotes.MinimumWidth = 12;
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            // 
            // colLastVisit
            // 
            this.colLastVisit.HeaderText = "الحالة";
            this.colLastVisit.MinimumWidth = 12;
            this.colLastVisit.Name = "colLastVisit";
            this.colLastVisit.ReadOnly = true;
            // 
            // MyPatientsFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1980, 1192);
            this.Controls.Add(this.panelGridArea);
            this.Controls.Add(this.panelActionBar);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyPatientsFormUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مرضاي";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelGridArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.panelActionBar.ResumeLayout(false);
            this.panelActionBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader; private System.Windows.Forms.Label lblTitle; private System.Windows.Forms.Panel panelHeaderBorder;
        private System.Windows.Forms.Panel panelGridArea; private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Panel panelActionBar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastVisit;
    }
}




