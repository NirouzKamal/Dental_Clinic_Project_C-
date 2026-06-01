namespace DentalClinicProject
{
    partial class CaseCreationFormUI
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHeaderBorder = new System.Windows.Forms.Panel();
            this.panelBottomBar = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelBottomBorder = new System.Windows.Forms.Panel();
            this.panelInputArea = new System.Windows.Forms.Panel();
            this.tlpInputs = new System.Windows.Forms.TableLayoutPanel();
            this.lblPatient = new System.Windows.Forms.Label(); this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label(); this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label(); this.cmbService = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label(); this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.Label(); this.txtPaid = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label(); this.txtNotes = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.panelBottomBar.SuspendLayout();
            this.panelInputArea.SuspendLayout();
            this.tlpInputs.SuspendLayout();
            this.SuspendLayout();
            // panelHeader
            this.panelHeader.Controls.Add(this.lblTitle); this.panelHeader.Controls.Add(this.panelHeaderBorder);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top; this.panelHeader.Name = "panelHeader"; this.panelHeader.Size = new System.Drawing.Size(600, 50);
            this.lblTitle.AutoSize = true; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41); this.lblTitle.Location = new System.Drawing.Point(20, 15); this.lblTitle.Name = "lblTitle"; this.lblTitle.Text = "إنشاء حالة / جلسة جديدة";
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(222, 226, 230); this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom; this.panelHeaderBorder.Name = "panelHeaderBorder"; this.panelHeaderBorder.Size = new System.Drawing.Size(600, 1);
            // panelBottomBar
            this.panelBottomBar.Controls.Add(this.btnSave); this.panelBottomBar.Controls.Add(this.panelBottomBorder);
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom; this.panelBottomBar.Name = "panelBottomBar"; this.panelBottomBar.Padding = new System.Windows.Forms.Padding(10); this.panelBottomBar.Size = new System.Drawing.Size(600, 60);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 75, 155); this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand; this.btnSave.Dock = System.Windows.Forms.DockStyle.Right; this.btnSave.FlatAppearance.BorderSize = 0; this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.btnSave.ForeColor = System.Drawing.Color.White; this.btnSave.Name = "btnSave"; this.btnSave.Size = new System.Drawing.Size(150, 38); this.btnSave.Text = "حفظ وإنشاء الفاتورة"; this.btnSave.UseVisualStyleBackColor = false;
            this.panelBottomBorder.BackColor = System.Drawing.Color.FromArgb(222, 226, 230); this.panelBottomBorder.Dock = System.Windows.Forms.DockStyle.Top; this.panelBottomBorder.Name = "panelBottomBorder"; this.panelBottomBorder.Size = new System.Drawing.Size(600, 1);
            // panelInputArea
            this.panelInputArea.Controls.Add(this.tlpInputs); this.panelInputArea.Dock = System.Windows.Forms.DockStyle.Fill; this.panelInputArea.Name = "panelInputArea"; this.panelInputArea.Padding = new System.Windows.Forms.Padding(30);
            // tlpInputs
            this.tlpInputs.ColumnCount = 2;
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInputs.Dock = System.Windows.Forms.DockStyle.Fill; this.tlpInputs.Name = "tlpInputs"; this.tlpInputs.RowCount = 6;
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tlpInputs.Controls.Add(this.lblPatient, 0, 0); this.tlpInputs.Controls.Add(this.cmbPatient, 1, 0);
            this.tlpInputs.Controls.Add(this.lblDoctor, 0, 1); this.tlpInputs.Controls.Add(this.cmbDoctor, 1, 1);
            this.tlpInputs.Controls.Add(this.lblService, 0, 2); this.tlpInputs.Controls.Add(this.cmbService, 1, 2);
            this.tlpInputs.Controls.Add(this.lblTotal, 0, 3); this.tlpInputs.Controls.Add(this.txtTotal, 1, 3);
            this.tlpInputs.Controls.Add(this.lblPaid, 0, 4); this.tlpInputs.Controls.Add(this.txtPaid, 1, 4);
            this.tlpInputs.Controls.Add(this.lblNotes, 0, 5); this.tlpInputs.Controls.Add(this.txtNotes, 1, 5);
            // Labels
            this.lblPatient.Text = "المريض"; this.lblPatient.AutoSize = true; this.lblPatient.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblPatient.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left; this.lblPatient.Name = "lblPatient";
            this.lblDoctor.Text = "الطبيب المعالج"; this.lblDoctor.AutoSize = true; this.lblDoctor.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblDoctor.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left; this.lblDoctor.Name = "lblDoctor";
            this.lblService.Text = "الخدمة / العلاج"; this.lblService.AutoSize = true; this.lblService.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblService.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left; this.lblService.Name = "lblService";
            this.lblTotal.Text = "التكلفة الإجمالية"; this.lblTotal.AutoSize = true; this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left; this.lblTotal.Name = "lblTotal";
            this.lblPaid.Text = "المبلغ المدفوع (مقدم)"; this.lblPaid.AutoSize = true; this.lblPaid.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblPaid.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left; this.lblPaid.Name = "lblPaid";
            this.lblNotes.Text = "ملاحظات"; this.lblNotes.AutoSize = true; this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left; this.lblNotes.Name = "lblNotes";
            // Inputs
            this.cmbPatient.Dock = System.Windows.Forms.DockStyle.Fill; this.cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbPatient.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbPatient.Margin = new System.Windows.Forms.Padding(10); this.cmbPatient.Name = "cmbPatient";
            this.cmbDoctor.Dock = System.Windows.Forms.DockStyle.Fill; this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbDoctor.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbDoctor.Margin = new System.Windows.Forms.Padding(10); this.cmbDoctor.Name = "cmbDoctor";
            this.cmbService.Dock = System.Windows.Forms.DockStyle.Fill; this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbService.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbService.Margin = new System.Windows.Forms.Padding(10); this.cmbService.Name = "cmbService";
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill; this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtTotal.Margin = new System.Windows.Forms.Padding(10); this.txtTotal.Name = "txtTotal";
            this.txtPaid.Dock = System.Windows.Forms.DockStyle.Fill; this.txtPaid.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtPaid.Margin = new System.Windows.Forms.Padding(10); this.txtPaid.Name = "txtPaid"; this.txtPaid.Text = "0";
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill; this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtNotes.Margin = new System.Windows.Forms.Padding(10); this.txtNotes.Name = "txtNotes";
            // 
            // CaseCreationFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panelInputArea); this.Controls.Add(this.panelBottomBar); this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false; this.MinimizeBox = false;
            this.Name = "CaseCreationFormUI"; this.RightToLeft = System.Windows.Forms.RightToLeft.Yes; this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; this.Text = "إنشاء حالة جديدة";
            this.panelHeader.ResumeLayout(false); this.panelHeader.PerformLayout();
            this.panelBottomBar.ResumeLayout(false);
            this.panelInputArea.ResumeLayout(false); this.tlpInputs.ResumeLayout(false); this.tlpInputs.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader; private System.Windows.Forms.Label lblTitle; private System.Windows.Forms.Panel panelHeaderBorder;
        private System.Windows.Forms.Panel panelBottomBar; private System.Windows.Forms.Button btnSave; private System.Windows.Forms.Panel panelBottomBorder;
        private System.Windows.Forms.Panel panelInputArea; private System.Windows.Forms.TableLayoutPanel tlpInputs;
        private System.Windows.Forms.Label lblPatient; private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Label lblDoctor; private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label lblService; private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Label lblTotal; private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblPaid; private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label lblNotes; private System.Windows.Forms.TextBox txtNotes;
    }
}


