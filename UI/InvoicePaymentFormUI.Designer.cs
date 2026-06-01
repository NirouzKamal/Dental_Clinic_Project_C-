namespace DentalClinicProject.UI
{
    partial class InvoicePaymentFormUI
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panelBottomBorder = new System.Windows.Forms.Panel();
            this.panelInputArea = new System.Windows.Forms.Panel();
            this.tlpInputs = new System.Windows.Forms.TableLayoutPanel();
            this.lblPatient = new System.Windows.Forms.Label(); this.txtPatient = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label(); this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.Label(); this.txtPaid = new System.Windows.Forms.TextBox();
            this.lblRemaining = new System.Windows.Forms.Label(); this.txtRemaining = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label(); this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.panelHeader.SuspendLayout();
            this.panelBottomBar.SuspendLayout();
            this.panelInputArea.SuspendLayout();
            this.tlpInputs.SuspendLayout();
            this.SuspendLayout();
            // panelHeader
            this.panelHeader.Controls.Add(this.lblTitle); this.panelHeader.Controls.Add(this.panelHeaderBorder);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top; this.panelHeader.Name = "panelHeader"; this.panelHeader.Size = new System.Drawing.Size(484, 50);
            this.lblTitle.AutoSize = true; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41); this.lblTitle.Location = new System.Drawing.Point(20, 15); this.lblTitle.Name = "lblTitle"; this.lblTitle.Text = "دفع فاتورة";
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(222, 226, 230); this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom; this.panelHeaderBorder.Name = "panelHeaderBorder"; this.panelHeaderBorder.Size = new System.Drawing.Size(484, 1);
            // panelBottomBar
            this.panelBottomBar.Controls.Add(this.btnConfirm); this.panelBottomBar.Controls.Add(this.panelBottomBorder);
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom; this.panelBottomBar.Name = "panelBottomBar"; this.panelBottomBar.Padding = new System.Windows.Forms.Padding(10); this.panelBottomBar.Size = new System.Drawing.Size(484, 60);
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand; this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Right; this.btnConfirm.FlatAppearance.BorderSize = 0; this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.btnConfirm.ForeColor = System.Drawing.Color.White; this.btnConfirm.Name = "btnConfirm"; this.btnConfirm.Size = new System.Drawing.Size(120, 38); this.btnConfirm.Text = "تأكيد الدفع"; this.btnConfirm.UseVisualStyleBackColor = false;
            this.panelBottomBorder.BackColor = System.Drawing.Color.FromArgb(222, 226, 230); this.panelBottomBorder.Dock = System.Windows.Forms.DockStyle.Top; this.panelBottomBorder.Name = "panelBottomBorder"; this.panelBottomBorder.Size = new System.Drawing.Size(484, 1);
            // panelInputArea
            this.panelInputArea.Controls.Add(this.tlpInputs); this.panelInputArea.Dock = System.Windows.Forms.DockStyle.Fill; this.panelInputArea.Name = "panelInputArea"; this.panelInputArea.Padding = new System.Windows.Forms.Padding(30);
            // tlpInputs
            this.tlpInputs.ColumnCount = 2;
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInputs.Dock = System.Windows.Forms.DockStyle.Fill; this.tlpInputs.Name = "tlpInputs"; this.tlpInputs.RowCount = 5;
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.Controls.Add(this.lblPatient, 0, 0); this.tlpInputs.Controls.Add(this.txtPatient, 1, 0);
            this.tlpInputs.Controls.Add(this.lblTotal, 0, 1); this.tlpInputs.Controls.Add(this.txtTotal, 1, 1);
            this.tlpInputs.Controls.Add(this.lblPaid, 0, 2); this.tlpInputs.Controls.Add(this.txtPaid, 1, 2);
            this.tlpInputs.Controls.Add(this.lblRemaining, 0, 3); this.tlpInputs.Controls.Add(this.txtRemaining, 1, 3);
            this.tlpInputs.Controls.Add(this.lblMethod, 0, 4); this.tlpInputs.Controls.Add(this.cmbMethod, 1, 4);
            // Labels
            this.lblPatient.Text = "اسم المريض"; this.lblPatient.AutoSize = true; this.lblPatient.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblPatient.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left; this.lblPatient.Name = "lblPatient";
            this.lblTotal.Text = "الإجمالي المستحق"; this.lblTotal.AutoSize = true; this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left; this.lblTotal.Name = "lblTotal";
            this.lblPaid.Text = "المبلغ المدفوع"; this.lblPaid.AutoSize = true; this.lblPaid.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblPaid.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left; this.lblPaid.Name = "lblPaid";
            this.lblRemaining.Text = "المبلغ المتبقي"; this.lblRemaining.AutoSize = true; this.lblRemaining.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblRemaining.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left; this.lblRemaining.Name = "lblRemaining";
            this.lblMethod.Text = "طريقة الدفع"; this.lblMethod.AutoSize = true; this.lblMethod.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblMethod.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left; this.lblMethod.Name = "lblMethod";
            // Inputs
            this.txtPatient.Dock = System.Windows.Forms.DockStyle.Fill; this.txtPatient.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtPatient.Margin = new System.Windows.Forms.Padding(10); this.txtPatient.ReadOnly = true; this.txtPatient.Name = "txtPatient";
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill; this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtTotal.Margin = new System.Windows.Forms.Padding(10); this.txtTotal.ReadOnly = true; this.txtTotal.Name = "txtTotal";
            this.txtPaid.Dock = System.Windows.Forms.DockStyle.Fill; this.txtPaid.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtPaid.Margin = new System.Windows.Forms.Padding(10); this.txtPaid.Name = "txtPaid";
            this.txtRemaining.Dock = System.Windows.Forms.DockStyle.Fill; this.txtRemaining.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtRemaining.Margin = new System.Windows.Forms.Padding(10); this.txtRemaining.ReadOnly = true; this.txtRemaining.Name = "txtRemaining";
            this.cmbMethod.Dock = System.Windows.Forms.DockStyle.Fill; this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbMethod.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbMethod.Margin = new System.Windows.Forms.Padding(10); this.cmbMethod.Name = "cmbMethod";
            // 
            // InvoicePaymentFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.panelInputArea); this.Controls.Add(this.panelBottomBar); this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false; this.MinimizeBox = false;
            this.Name = "InvoicePaymentFormUI"; this.RightToLeft = System.Windows.Forms.RightToLeft.Yes; this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; this.Text = "دفع فاتورة";
            this.panelHeader.ResumeLayout(false); this.panelHeader.PerformLayout();
            this.panelBottomBar.ResumeLayout(false);
            this.panelInputArea.ResumeLayout(false); this.tlpInputs.ResumeLayout(false); this.tlpInputs.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader; private System.Windows.Forms.Label lblTitle; private System.Windows.Forms.Panel panelHeaderBorder;
        private System.Windows.Forms.Panel panelBottomBar; private System.Windows.Forms.Button btnConfirm; private System.Windows.Forms.Panel panelBottomBorder;
        private System.Windows.Forms.Panel panelInputArea; private System.Windows.Forms.TableLayoutPanel tlpInputs;
        private System.Windows.Forms.Label lblPatient; private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.Label lblTotal; private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblPaid; private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label lblRemaining; private System.Windows.Forms.TextBox txtRemaining;
        private System.Windows.Forms.Label lblMethod; private System.Windows.Forms.ComboBox cmbMethod;
    }
}


