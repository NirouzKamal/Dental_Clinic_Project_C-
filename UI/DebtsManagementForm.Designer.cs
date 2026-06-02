namespace DentalClinicProject.UI
{
    partial class DebtsManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelSummary = new System.Windows.Forms.Panel();
            this.lblSummary = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvDebts = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRegisterPayment = new System.Windows.Forms.Button();
            this.colSessionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSummary.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebts)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.flowButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.lblSummary);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSummary.Location = new System.Drawing.Point(0, 0);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Padding = new System.Windows.Forms.Padding(16, 12, 16, 8);
            this.panelSummary.Size = new System.Drawing.Size(1490, 95);
            this.panelSummary.TabIndex = 0;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSummary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblSummary.Location = new System.Drawing.Point(719, 12);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(755, 50);
            this.lblSummary.TabIndex = 0;
            this.lblSummary.Text = "عدد الحالات المدينة: 0 | إجمالي الديون: 0.00 د.ل";
            this.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dgvDebts);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 95);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(16);
            this.panelGrid.Size = new System.Drawing.Size(1490, 724);
            this.panelGrid.TabIndex = 1;
            // 
            // dgvDebts
            // 
            this.dgvDebts.AllowUserToAddRows = false;
            this.dgvDebts.AllowUserToDeleteRows = false;
            this.dgvDebts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDebts.BackgroundColor = System.Drawing.Color.White;
            this.dgvDebts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDebts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDebts.ColumnHeadersHeight = 40;
            this.dgvDebts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDebts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSessionNumber,
            this.colPatient,
            this.colDoctor,
            this.colTotal,
            this.colPaid,
            this.colRemaining});
            this.dgvDebts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDebts.EnableHeadersVisualStyles = false;
            this.dgvDebts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvDebts.Location = new System.Drawing.Point(16, 16);
            this.dgvDebts.MultiSelect = false;
            this.dgvDebts.Name = "dgvDebts";
            this.dgvDebts.ReadOnly = true;
            this.dgvDebts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDebts.RowHeadersVisible = false;
            this.dgvDebts.RowHeadersWidth = 102;
            this.dgvDebts.RowTemplate.Height = 40;
            this.dgvDebts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDebts.Size = new System.Drawing.Size(1458, 692);
            this.dgvDebts.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.flowButtons);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 819);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(16, 10, 16, 12);
            this.panelBottom.Size = new System.Drawing.Size(1490, 104);
            this.panelBottom.TabIndex = 2;
            // 
            // flowButtons
            // 
            this.flowButtons.Controls.Add(this.btnClose);
            this.flowButtons.Controls.Add(this.btnRefresh);
            this.flowButtons.Controls.Add(this.btnRegisterPayment);
            this.flowButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowButtons.Location = new System.Drawing.Point(962, 10);
            this.flowButtons.Name = "flowButtons";
            this.flowButtons.Size = new System.Drawing.Size(512, 82);
            this.flowButtons.TabIndex = 0;
            this.flowButtons.WrapContents = false;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnClose.Location = new System.Drawing.Point(0, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 55);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(117, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(124, 55);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "تحديث";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnRegisterPayment
            // 
            this.btnRegisterPayment.AutoSize = true;
            this.btnRegisterPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(83)))));
            this.btnRegisterPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterPayment.FlatAppearance.BorderSize = 0;
            this.btnRegisterPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterPayment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegisterPayment.ForeColor = System.Drawing.Color.White;
            this.btnRegisterPayment.Location = new System.Drawing.Point(249, 3);
            this.btnRegisterPayment.Margin = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.btnRegisterPayment.Name = "btnRegisterPayment";
            this.btnRegisterPayment.Size = new System.Drawing.Size(203, 56);
            this.btnRegisterPayment.TabIndex = 0;
            this.btnRegisterPayment.Text = "تسجيل دفعة";
            this.btnRegisterPayment.UseVisualStyleBackColor = false;
            // 
            // colSessionNumber
            // 
            this.colSessionNumber.HeaderText = "رقم الجلسة";
            this.colSessionNumber.MinimumWidth = 100;
            this.colSessionNumber.Name = "colSessionNumber";
            this.colSessionNumber.ReadOnly = true;
            // 
            // colPatient
            // 
            this.colPatient.HeaderText = "اسم الحالة";
            this.colPatient.MinimumWidth = 120;
            this.colPatient.Name = "colPatient";
            this.colPatient.ReadOnly = true;
            // 
            // colDoctor
            // 
            this.colDoctor.HeaderText = "الطبيب";
            this.colDoctor.MinimumWidth = 120;
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "الإجمالي";
            this.colTotal.MinimumWidth = 90;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colPaid
            // 
            this.colPaid.HeaderText = "المدفوع";
            this.colPaid.MinimumWidth = 90;
            this.colPaid.Name = "colPaid";
            this.colPaid.ReadOnly = true;
            // 
            // colRemaining
            // 
            this.colRemaining.HeaderText = "المتبقي";
            this.colRemaining.MinimumWidth = 90;
            this.colRemaining.Name = "colRemaining";
            this.colRemaining.ReadOnly = true;
            // 
            // DebtsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1490, 923);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelSummary);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebtsManagementForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إدارة الديون";
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebts)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.flowButtons.ResumeLayout(false);
            this.flowButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvDebts;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button btnRegisterPayment;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSessionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemaining;
    }
}
