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
            this.lblPatient = new System.Windows.Forms.Label();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.panelHeader.SuspendLayout();
            this.panelBottomBar.SuspendLayout();
            this.panelInputArea.SuspendLayout();
            this.tlpInputs.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(1333, 119);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(53, 36);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "دفع فاتورة";
            // 
            // panelHeaderBorder
            // 
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeaderBorder.Location = new System.Drawing.Point(0, 117);
            this.panelHeaderBorder.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelHeaderBorder.Name = "panelHeaderBorder";
            this.panelHeaderBorder.Size = new System.Drawing.Size(1333, 2);
            this.panelHeaderBorder.TabIndex = 1;
            // 
            // panelBottomBar
            // 
            this.panelBottomBar.Controls.Add(this.btnConfirm);
            this.panelBottomBar.Controls.Add(this.panelBottomBorder);
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBar.Location = new System.Drawing.Point(0, 811);
            this.panelBottomBar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Padding = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.panelBottomBar.Size = new System.Drawing.Size(1333, 143);
            this.panelBottomBar.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(986, 26);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(320, 93);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "تأكيد الدفع";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // panelBottomBorder
            // 
            this.panelBottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panelBottomBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottomBorder.Location = new System.Drawing.Point(27, 24);
            this.panelBottomBorder.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelBottomBorder.Name = "panelBottomBorder";
            this.panelBottomBorder.Size = new System.Drawing.Size(1279, 2);
            this.panelBottomBorder.TabIndex = 1;
            // 
            // panelInputArea
            // 
            this.panelInputArea.Controls.Add(this.tlpInputs);
            this.panelInputArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputArea.Location = new System.Drawing.Point(0, 119);
            this.panelInputArea.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelInputArea.Name = "panelInputArea";
            this.panelInputArea.Padding = new System.Windows.Forms.Padding(80, 72, 80, 72);
            this.panelInputArea.Size = new System.Drawing.Size(1333, 692);
            this.panelInputArea.TabIndex = 0;
            // 
            // tlpInputs
            // 
            this.tlpInputs.ColumnCount = 2;
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInputs.Controls.Add(this.lblPatient, 0, 0);
            this.tlpInputs.Controls.Add(this.txtPatient, 1, 0);
            this.tlpInputs.Controls.Add(this.lblTotal, 0, 1);
            this.tlpInputs.Controls.Add(this.txtTotal, 1, 1);
            this.tlpInputs.Controls.Add(this.lblPaid, 0, 2);
            this.tlpInputs.Controls.Add(this.txtPaid, 1, 2);
            this.tlpInputs.Controls.Add(this.lblRemaining, 0, 3);
            this.tlpInputs.Controls.Add(this.txtRemaining, 1, 3);
            this.tlpInputs.Controls.Add(this.lblMethod, 0, 4);
            this.tlpInputs.Controls.Add(this.cmbMethod, 1, 4);
            this.tlpInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInputs.Location = new System.Drawing.Point(80, 72);
            this.tlpInputs.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tlpInputs.Name = "tlpInputs";
            this.tlpInputs.RowCount = 5;
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.Size = new System.Drawing.Size(1173, 548);
            this.tlpInputs.TabIndex = 0;
            // 
            // lblPatient
            // 
            this.lblPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPatient.Location = new System.Drawing.Point(861, 31);
            this.lblPatient.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(304, 46);
            this.lblPatient.TabIndex = 0;
            this.lblPatient.Text = "اسم المريض";
            this.lblPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatient
            // 
            this.txtPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPatient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatient.Location = new System.Drawing.Point(27, 24);
            this.txtPatient.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.ReadOnly = true;
            this.txtPatient.Size = new System.Drawing.Size(799, 52);
            this.txtPatient.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotal.Location = new System.Drawing.Point(861, 140);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(304, 46);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "الإجمالي المستحق";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotal.Location = new System.Drawing.Point(27, 133);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(799, 52);
            this.txtTotal.TabIndex = 3;
            // 
            // lblPaid
            // 
            this.lblPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPaid.Location = new System.Drawing.Point(861, 249);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(304, 46);
            this.lblPaid.TabIndex = 4;
            this.lblPaid.Text = "المبلغ المدفوع";
            this.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaid
            // 
            this.txtPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPaid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPaid.Location = new System.Drawing.Point(27, 242);
            this.txtPaid.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(799, 52);
            this.txtPaid.TabIndex = 5;
            // 
            // lblRemaining
            // 
            this.lblRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRemaining.Location = new System.Drawing.Point(861, 358);
            this.lblRemaining.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(304, 46);
            this.lblRemaining.TabIndex = 6;
            this.lblRemaining.Text = "المبلغ المتبقي";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRemaining
            // 
            this.txtRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemaining.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRemaining.Location = new System.Drawing.Point(27, 351);
            this.txtRemaining.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.ReadOnly = true;
            this.txtRemaining.Size = new System.Drawing.Size(799, 52);
            this.txtRemaining.TabIndex = 7;
            // 
            // lblMethod
            // 
            this.lblMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMethod.Location = new System.Drawing.Point(861, 469);
            this.lblMethod.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(304, 46);
            this.lblMethod.TabIndex = 8;
            this.lblMethod.Text = "طريقة الدفع";
            this.lblMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMethod
            // 
            this.cmbMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMethod.Location = new System.Drawing.Point(27, 460);
            this.cmbMethod.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(799, 53);
            this.cmbMethod.TabIndex = 9;
            // 
            // InvoicePaymentFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 954);
            this.Controls.Add(this.panelInputArea);
            this.Controls.Add(this.panelBottomBar);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoicePaymentFormUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "دفع فاتورة";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBottomBar.ResumeLayout(false);
            this.panelInputArea.ResumeLayout(false);
            this.tlpInputs.ResumeLayout(false);
            this.tlpInputs.PerformLayout();
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


