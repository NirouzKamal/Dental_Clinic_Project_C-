namespace DentalClinicProject.UI
{
    partial class StaffManagementControlUI
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            this.panelActionBar = new System.Windows.Forms.Panel();
            this.lblTitle       = new System.Windows.Forms.Label();
            this.spacerTitle    = new System.Windows.Forms.Panel();
            this.txtSearch      = new System.Windows.Forms.TextBox();
            this.btnAddStaff    = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.panelGridArea  = new System.Windows.Forms.Panel();
            this.dgvStaff       = new System.Windows.Forms.DataGridView();

            // Create columns BEFORE BeginInit
            this.colId       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus   = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.panelActionBar.SuspendLayout();
            this.panelGridArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();

            // ── panelActionBar ────────────────────────────────────────────
            this.panelActionBar.BackColor = System.Drawing.Color.White;
            this.panelActionBar.Controls.Add(this.btnAddStaff);
            this.panelActionBar.Controls.Add(this.btnDeleteStaff);
            this.panelActionBar.Controls.Add(this.txtSearch);
            this.panelActionBar.Controls.Add(this.spacerTitle);
            this.panelActionBar.Controls.Add(this.lblTitle);
            this.panelActionBar.Dock    = System.Windows.Forms.DockStyle.Top;
            this.panelActionBar.Name    = "panelActionBar";
            this.panelActionBar.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.panelActionBar.Size    = new System.Drawing.Size(900, 60);

            this.lblTitle.AutoSize  = true;
            this.lblTitle.Dock      = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.Text      = "إدارة الموظفين";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.spacerTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.spacerTitle.Name = "spacerTitle";
            this.spacerTitle.Size = new System.Drawing.Size(18, 36);

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock        = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor   = System.Drawing.Color.FromArgb(108, 117, 125);
            this.txtSearch.Name        = "txtSearch";
            this.txtSearch.Size        = new System.Drawing.Size(220, 36);
            this.txtSearch.Text        = "ابحث بالاسم...";

            this.btnAddStaff.BackColor                 = System.Drawing.Color.FromArgb(0, 75, 155);
            this.btnAddStaff.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnAddStaff.Dock                      = System.Windows.Forms.DockStyle.Right;
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font                      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddStaff.ForeColor                 = System.Drawing.Color.White;
            this.btnAddStaff.Name                      = "btnAddStaff";
            this.btnAddStaff.Size                      = new System.Drawing.Size(130, 36);
            this.btnAddStaff.Text                      = "+ إضافة موظف";
            this.btnAddStaff.UseVisualStyleBackColor   = false;

            this.btnDeleteStaff.BackColor                 = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDeleteStaff.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStaff.Dock                      = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteStaff.FlatAppearance.BorderSize = 0;
            this.btnDeleteStaff.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.Font                      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDeleteStaff.ForeColor                 = System.Drawing.Color.White;
            this.btnDeleteStaff.Name                      = "btnDeleteStaff";
            this.btnDeleteStaff.Size                      = new System.Drawing.Size(115, 36);
            this.btnDeleteStaff.Text                      = "حذف موظف";
            this.btnDeleteStaff.UseVisualStyleBackColor   = false;
            this.btnDeleteStaff.Margin                    = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.btnDeleteStaff.Enabled                   = false;

            // ── panelGridArea ─────────────────────────────────────────────
            this.panelGridArea.Controls.Add(this.dgvStaff);
            this.panelGridArea.Dock    = System.Windows.Forms.DockStyle.Fill;
            this.panelGridArea.Name    = "panelGridArea";
            this.panelGridArea.Padding = new System.Windows.Forms.Padding(12);

            // ── dgvStaff — basic properties only (styles set in code) ─────
            this.dgvStaff.AllowUserToAddRows       = false;
            this.dgvStaff.AllowUserToDeleteRows    = false;
            this.dgvStaff.AutoSizeColumnsMode      = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.BackgroundColor          = System.Drawing.Color.White;
            this.dgvStaff.BorderStyle              = System.Windows.Forms.BorderStyle.None;
            this.dgvStaff.CellBorderStyle          = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStaff.ColumnHeadersHeight      = 38;
            this.dgvStaff.EnableHeadersVisualStyles = false;
            this.dgvStaff.GridColor                = System.Drawing.Color.FromArgb(222, 226, 230);
            this.dgvStaff.Name                     = "dgvStaff";
            this.dgvStaff.ReadOnly                 = true;
            this.dgvStaff.RightToLeft              = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStaff.RowHeadersVisible        = false;
            this.dgvStaff.RowTemplate.Height       = 38;
            this.dgvStaff.SelectionMode            = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Dock                     = System.Windows.Forms.DockStyle.Fill;

            // ── Column definitions ────────────────────────────────────────
            this.colId.HeaderText       = "المعرّف";
            this.colId.Name             = "colId";
            this.colId.ReadOnly         = true;
            this.colId.FillWeight       = 90;

            this.colName.HeaderText     = "الاسم الكامل";
            this.colName.Name           = "colName";
            this.colName.ReadOnly       = true;
            this.colName.FillWeight     = 160;

            this.colUsername.HeaderText = "اسم الدخول";
            this.colUsername.Name       = "colUsername";
            this.colUsername.ReadOnly   = true;
            this.colUsername.FillWeight = 110;

            this.colRole.HeaderText     = "الوظيفة";
            this.colRole.Name           = "colRole";
            this.colRole.ReadOnly       = true;
            this.colRole.FillWeight     = 90;

            this.colPhone.HeaderText    = "الهاتف";
            this.colPhone.Name          = "colPhone";
            this.colPhone.ReadOnly      = true;
            this.colPhone.FillWeight    = 100;

            this.colStatus.HeaderText   = "الحالة";
            this.colStatus.Name         = "colStatus";
            this.colStatus.ReadOnly     = true;
            this.colStatus.FillWeight   = 65;

            // Add columns AFTER properties are set
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.colId, this.colName, this.colUsername,
                this.colRole, this.colPhone, this.colStatus
            });

            // ── UserControl ───────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(243, 244, 246);
            this.Controls.Add(this.panelGridArea);
            this.Controls.Add(this.panelActionBar);
            this.Name        = "StaffManagementControlUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size        = new System.Drawing.Size(900, 550);

            this.panelActionBar.ResumeLayout(false);
            this.panelActionBar.PerformLayout();
            this.panelGridArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelActionBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel spacerTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Panel panelGridArea;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
