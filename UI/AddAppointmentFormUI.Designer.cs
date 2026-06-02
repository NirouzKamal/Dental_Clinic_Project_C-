namespace DentalClinicProject.UI
{
    partial class AddAppointmentFormUI
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHeaderBorder = new System.Windows.Forms.Panel();
            this.panelBottomBar = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelBottomBorder = new System.Windows.Forms.Panel();
            this.panelInputArea = new System.Windows.Forms.Panel();
            this.tlpInputs = new System.Windows.Forms.TableLayoutPanel();
            this.lblPatient = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTimeSlots = new System.Windows.Forms.Label();
            this.cmbTimeSlots = new System.Windows.Forms.ComboBox();
            this.lblVisitType = new System.Windows.Forms.Label();
            this.cmbVisitType = new System.Windows.Forms.ComboBox();
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
            this.panelHeader.Size = new System.Drawing.Size(640, 56);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTitle.Location = new System.Drawing.Point(24, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "إضافة موعد جديد";
            // 
            // panelHeaderBorder
            // 
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeaderBorder.Name = "panelHeaderBorder";
            this.panelHeaderBorder.Size = new System.Drawing.Size(640, 1);
            // 
            // panelBottomBar
            // 
            this.panelBottomBar.Controls.Add(this.btnSave);
            this.panelBottomBar.Controls.Add(this.panelBottomBorder);
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.panelBottomBar.Size = new System.Drawing.Size(640, 64);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 40);
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // panelBottomBorder
            // 
            this.panelBottomBorder.BackColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.panelBottomBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottomBorder.Name = "panelBottomBorder";
            this.panelBottomBorder.Size = new System.Drawing.Size(608, 1);
            // 
            // panelInputArea
            // 
            this.panelInputArea.Controls.Add(this.tlpInputs);
            this.panelInputArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputArea.Name = "panelInputArea";
            this.panelInputArea.Padding = new System.Windows.Forms.Padding(32, 24, 32, 24);
            // 
            // tlpInputs
            // 
            this.tlpInputs.ColumnCount = 2;
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInputs.Controls.Add(this.lblPatient, 0, 0);
            this.tlpInputs.Controls.Add(this.cmbPatient, 1, 0);
            this.tlpInputs.Controls.Add(this.lblDoctor, 0, 1);
            this.tlpInputs.Controls.Add(this.cmbDoctor, 1, 1);
            this.tlpInputs.Controls.Add(this.lblDate, 0, 2);
            this.tlpInputs.Controls.Add(this.dtpDate, 1, 2);
            this.tlpInputs.Controls.Add(this.lblTimeSlots, 0, 3);
            this.tlpInputs.Controls.Add(this.cmbTimeSlots, 1, 3);
            this.tlpInputs.Controls.Add(this.lblVisitType, 0, 4);
            this.tlpInputs.Controls.Add(this.cmbVisitType, 1, 4);
            this.tlpInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInputs.Name = "tlpInputs";
            this.tlpInputs.RowCount = 5;
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            // 
            // lblPatient
            // 
            this.lblPatient.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Text = "المريض";
            this.lblPatient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPatient
            // 
            this.cmbPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatient.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbPatient.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.cmbPatient.Name = "cmbPatient";
            // 
            // lblDoctor
            // 
            this.lblDoctor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Text = "الطبيب";
            this.lblDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.cmbDoctor.Name = "cmbDoctor";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDate.Name = "lblDate";
            this.lblDate.Text = "تاريخ الموعد";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDate
            // 
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.dtpDate.Name = "dtpDate";
            // 
            // lblTimeSlots
            // 
            this.lblTimeSlots.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTimeSlots.AutoSize = true;
            this.lblTimeSlots.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTimeSlots.Name = "lblTimeSlots";
            this.lblTimeSlots.Text = "الوقت المتاح";
            this.lblTimeSlots.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTimeSlots
            // 
            this.cmbTimeSlots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTimeSlots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeSlots.Enabled = false;
            this.cmbTimeSlots.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbTimeSlots.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.cmbTimeSlots.Name = "cmbTimeSlots";
            // 
            // lblVisitType
            // 
            this.lblVisitType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVisitType.AutoSize = true;
            this.lblVisitType.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblVisitType.Name = "lblVisitType";
            this.lblVisitType.Text = "نوع الزيارة";
            this.lblVisitType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbVisitType
            // 
            this.cmbVisitType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbVisitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVisitType.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbVisitType.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.cmbVisitType.Name = "cmbVisitType";
            // 
            // AddAppointmentFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.panelInputArea);
            this.Controls.Add(this.panelBottomBar);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAppointmentFormUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة موعد جديد";
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelBottomBorder;
        private System.Windows.Forms.Panel panelInputArea;
        private System.Windows.Forms.TableLayoutPanel tlpInputs;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTimeSlots;
        private System.Windows.Forms.ComboBox cmbTimeSlots;
        private System.Windows.Forms.Label lblVisitType;
        private System.Windows.Forms.ComboBox cmbVisitType;
    }
}
