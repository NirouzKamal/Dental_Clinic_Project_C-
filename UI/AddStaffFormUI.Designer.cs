namespace DentalClinicProject.UI
{
    partial class AddStaffFormUI
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
            this.panelSchedule = new System.Windows.Forms.Panel();
            this.tlpInputs = new System.Windows.Forms.TableLayoutPanel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.TextBox();
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
            this.panelHeader.Size = new System.Drawing.Size(1600, 119);
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
            this.lblTitle.Size = new System.Drawing.Size(337, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إضافة موظف جديد";
            // 
            // panelHeaderBorder
            // 
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeaderBorder.Location = new System.Drawing.Point(0, 117);
            this.panelHeaderBorder.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelHeaderBorder.Name = "panelHeaderBorder";
            this.panelHeaderBorder.Size = new System.Drawing.Size(1600, 2);
            this.panelHeaderBorder.TabIndex = 1;
            // 
            // panelBottomBar
            // 
            this.panelBottomBar.Controls.Add(this.btnSave);
            this.panelBottomBar.Controls.Add(this.panelBottomBorder);
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBar.Location = new System.Drawing.Point(0, 1645);
            this.panelBottomBar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Padding = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.panelBottomBar.Size = new System.Drawing.Size(1600, 143);
            this.panelBottomBar.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1253, 26);
            this.btnSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(320, 93);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // panelBottomBorder
            // 
            this.panelBottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panelBottomBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottomBorder.Location = new System.Drawing.Point(27, 24);
            this.panelBottomBorder.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelBottomBorder.Name = "panelBottomBorder";
            this.panelBottomBorder.Size = new System.Drawing.Size(1546, 2);
            this.panelBottomBorder.TabIndex = 1;
            // 
            // panelInputArea
            // 
            this.panelInputArea.AutoScroll = true;
            this.panelInputArea.Controls.Add(this.panelSchedule);
            this.panelInputArea.Controls.Add(this.tlpInputs);
            this.panelInputArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputArea.Location = new System.Drawing.Point(0, 119);
            this.panelInputArea.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelInputArea.Name = "panelInputArea";
            this.panelInputArea.Padding = new System.Windows.Forms.Padding(80, 72, 80, 72);
            this.panelInputArea.Size = new System.Drawing.Size(1600, 1526);
            this.panelInputArea.TabIndex = 0;
            // 
            // panelSchedule
            // 
            this.panelSchedule.AutoSize = true;
            this.panelSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSchedule.Location = new System.Drawing.Point(80, 907);
            this.panelSchedule.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelSchedule.Name = "panelSchedule";
            this.panelSchedule.Padding = new System.Windows.Forms.Padding(0, 48, 0, 48);
            this.panelSchedule.Size = new System.Drawing.Size(1440, 96);
            this.panelSchedule.TabIndex = 0;
            this.panelSchedule.Visible = false;
            // 
            // tlpInputs
            // 
            this.tlpInputs.ColumnCount = 2;
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 347F));
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInputs.Controls.Add(this.lblFullName, 0, 0);
            this.tlpInputs.Controls.Add(this.txtFullName, 1, 0);
            this.tlpInputs.Controls.Add(this.lblUsername, 0, 1);
            this.tlpInputs.Controls.Add(this.txtUsername, 1, 1);
            this.tlpInputs.Controls.Add(this.lblPassword, 0, 2);
            this.tlpInputs.Controls.Add(this.txtPassword, 1, 2);
            this.tlpInputs.Controls.Add(this.lblRole, 0, 3);
            this.tlpInputs.Controls.Add(this.cmbRole, 1, 3);
            this.tlpInputs.Controls.Add(this.lblPhone, 0, 4);
            this.tlpInputs.Controls.Add(this.txtPhone, 1, 4);
            this.tlpInputs.Controls.Add(this.lblSalary, 0, 5);
            this.tlpInputs.Controls.Add(this.txtSalary, 1, 5);
            this.tlpInputs.Controls.Add(this.lblCommission, 0, 6);
            this.tlpInputs.Controls.Add(this.txtCommission, 1, 6);
            this.tlpInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpInputs.Location = new System.Drawing.Point(80, 72);
            this.tlpInputs.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tlpInputs.Name = "tlpInputs";
            this.tlpInputs.RowCount = 7;
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tlpInputs.Size = new System.Drawing.Size(1440, 835);
            this.tlpInputs.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFullName.Location = new System.Drawing.Point(1101, 36);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(331, 46);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "الاسم الكامل";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFullName
            // 
            this.txtFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(27, 24);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(1039, 52);
            this.txtFullName.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.Location = new System.Drawing.Point(1101, 155);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(331, 46);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "اسم المستخدم";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(27, 143);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(1039, 52);
            this.txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.Location = new System.Drawing.Point(1101, 274);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(331, 46);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "كلمة المرور";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(27, 262);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(1039, 52);
            this.txtPassword.TabIndex = 5;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRole.Location = new System.Drawing.Point(1101, 393);
            this.lblRole.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(331, 46);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "الدور الوظيفي";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRole
            // 
            this.cmbRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRole.Location = new System.Drawing.Point(27, 381);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(1039, 53);
            this.cmbRole.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.Location = new System.Drawing.Point(1101, 512);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(331, 46);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "رقم الهاتف";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(27, 500);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(1039, 52);
            this.txtPhone.TabIndex = 9;
            // 
            // lblSalary
            // 
            this.lblSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSalary.Location = new System.Drawing.Point(1101, 631);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(331, 46);
            this.lblSalary.TabIndex = 10;
            this.lblSalary.Text = "الراتب الأساسي";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSalary
            // 
            this.txtSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSalary.Location = new System.Drawing.Point(27, 619);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(1039, 52);
            this.txtSalary.TabIndex = 11;
            this.txtSalary.Text = "0";
            // 
            // lblCommission
            // 
            this.lblCommission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommission.AutoSize = true;
            this.lblCommission.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCommission.Location = new System.Drawing.Point(1101, 751);
            this.lblCommission.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(331, 46);
            this.lblCommission.TabIndex = 12;
            this.lblCommission.Text = "نسبة العمولة";
            this.lblCommission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCommission
            // 
            this.txtCommission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommission.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCommission.Location = new System.Drawing.Point(27, 738);
            this.txtCommission.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(1039, 52);
            this.txtCommission.TabIndex = 13;
            this.txtCommission.Text = "0";
            // 
            // AddStaffFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 1788);
            this.Controls.Add(this.panelInputArea);
            this.Controls.Add(this.panelBottomBar);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStaffFormUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة موظف جديد";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBottomBar.ResumeLayout(false);
            this.panelInputArea.ResumeLayout(false);
            this.panelInputArea.PerformLayout();
            this.tlpInputs.ResumeLayout(false);
            this.tlpInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader; private System.Windows.Forms.Label lblTitle; private System.Windows.Forms.Panel panelHeaderBorder;
        private System.Windows.Forms.Panel panelBottomBar; private System.Windows.Forms.Button btnSave; private System.Windows.Forms.Panel panelBottomBorder;
        private System.Windows.Forms.Panel panelInputArea; private System.Windows.Forms.TableLayoutPanel tlpInputs;
        private System.Windows.Forms.Panel panelSchedule;
        private System.Windows.Forms.Label lblFullName; private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblUsername; private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword; private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole; private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblPhone; private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblSalary; private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblCommission; private System.Windows.Forms.TextBox txtCommission;
    }
}


