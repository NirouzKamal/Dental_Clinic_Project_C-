namespace DentalClinicProject.UI
{
    partial class AddPatientFormUI
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
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelBottomBorder = new System.Windows.Forms.Panel();
            this.panelInputArea = new System.Windows.Forms.Panel();
            this.tlpInputs = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
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
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(584, 50);
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "إضافة مريض جديد";
            // panelHeaderBorder
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeaderBorder.Name = "panelHeaderBorder";
            this.panelHeaderBorder.Size = new System.Drawing.Size(584, 1);
            // 
            // panelBottomBar
            // 
            this.panelBottomBar.Controls.Add(this.btnBookAppointment);
            this.panelBottomBar.Controls.Add(this.btnSave);
            this.panelBottomBar.Controls.Add(this.panelBottomBorder);
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Padding = new System.Windows.Forms.Padding(10);
            this.panelBottomBar.Size = new System.Drawing.Size(584, 60);
            // btnBookAppointment
            this.btnBookAppointment.BackColor = System.Drawing.Color.FromArgb(62, 125, 83);
            this.btnBookAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookAppointment.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBookAppointment.FlatAppearance.BorderSize = 0;
            this.btnBookAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookAppointment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBookAppointment.ForeColor = System.Drawing.Color.White;
            this.btnBookAppointment.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(140, 38);
            this.btnBookAppointment.Text = "حجز موعد";
            this.btnBookAppointment.UseVisualStyleBackColor = false;
            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 38);
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            // panelBottomBorder
            this.panelBottomBorder.BackColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.panelBottomBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottomBorder.Name = "panelBottomBorder";
            this.panelBottomBorder.Size = new System.Drawing.Size(584, 1);
            // 
            // panelInputArea
            // 
            this.panelInputArea.Controls.Add(this.tlpInputs);
            this.panelInputArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputArea.Name = "panelInputArea";
            this.panelInputArea.Padding = new System.Windows.Forms.Padding(30);
            // 
            // tlpInputs
            // 
            this.tlpInputs.ColumnCount = 2;
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInputs.Controls.Add(this.lblName, 0, 0);
            this.tlpInputs.Controls.Add(this.txtName, 1, 0);
            this.tlpInputs.Controls.Add(this.lblPhone, 0, 1);
            this.tlpInputs.Controls.Add(this.txtPhone, 1, 1);
            this.tlpInputs.Controls.Add(this.lblAge, 0, 2);
            this.tlpInputs.Controls.Add(this.txtAge, 1, 2);
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.tlpInputs.Controls.Add(this.lblGender, 0, 3);
            this.tlpInputs.Controls.Add(this.cmbGender, 1, 3);
            this.tlpInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInputs.Name = "tlpInputs";
            this.tlpInputs.RowCount = 4;
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            // Labels
            this.lblName.Text = "الاسم الكامل"; this.lblName.AutoSize = true; this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left; this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblName.Name = "lblName";
            this.lblPhone.Text = "رقم الهاتف"; this.lblPhone.AutoSize = true; this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left; this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblPhone.Name = "lblPhone";
            this.lblAge.Text = "العمر"; this.lblAge.AutoSize = true; this.lblAge.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left; this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblAge.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblAge.Name = "lblAge";
            this.lblGender.Text = "الجنس"; this.lblGender.AutoSize = true; this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left; this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblGender.Name = "lblGender";
            // TextBoxes & Comboboxes
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill; this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtName.Margin = new System.Windows.Forms.Padding(10); this.txtName.Name = "txtName";
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill; this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtPhone.Margin = new System.Windows.Forms.Padding(10); this.txtPhone.Name = "txtPhone";
            this.txtAge.Dock = System.Windows.Forms.DockStyle.Fill; this.txtAge.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtAge.Margin = new System.Windows.Forms.Padding(10); this.txtAge.Name = "txtAge";
            this.cmbGender.Dock = System.Windows.Forms.DockStyle.Fill; this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbGender.Margin = new System.Windows.Forms.Padding(10); this.cmbGender.Name = "cmbGender"; this.cmbGender.Items.AddRange(new object[] { "ذكر", "أنثى" }); this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // AddPatientFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.panelInputArea);
            this.Controls.Add(this.panelBottomBar);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPatientFormUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة مريض جديد";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBottomBar.ResumeLayout(false);
            this.panelInputArea.ResumeLayout(false);
            this.tlpInputs.ResumeLayout(false);
            this.tlpInputs.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelHeaderBorder;
        private System.Windows.Forms.Panel panelBottomBar;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelBottomBorder;
        private System.Windows.Forms.Panel panelInputArea;
        private System.Windows.Forms.TableLayoutPanel tlpInputs;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
    }
}


