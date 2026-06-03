namespace DentalClinicProject.UI
{
    partial class EditPatientRecordFormUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaseNumber = new System.Windows.Forms.Label();
            this.txtCaseNumber = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblFileNumber = new System.Windows.Forms.Label();
            this.txtFileNumber = new System.Windows.Forms.TextBox();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.cmbTreatment = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(580, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(580, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "تعديل بيانات سجل المريض";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.tableLayoutPanel);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 70);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panelContent.Size = new System.Drawing.Size(580, 510);
            this.panelContent.TabIndex = 1;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel.Controls.Add(this.lblCaseNumber, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtCaseNumber, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblPatientName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtPatientName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblFileNumber, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.txtFileNumber, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblDoctorName, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.txtDoctorName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lblPrice, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.txtPrice, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.lblPaid, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.txtPaid, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.lblRemaining, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.txtRemaining, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.lblDate, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.dtpDate, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.lblTreatment, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.cmbTreatment, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.lblStatus, 0, 9);
            this.tableLayoutPanel.Controls.Add(this.cmbStatus, 1, 9);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(30, 20);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 10;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(520, 470);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lblCaseNumber
            // 
            this.lblCaseNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaseNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCaseNumber.Location = new System.Drawing.Point(341, 0);
            this.lblCaseNumber.Name = "lblCaseNumber";
            this.lblCaseNumber.Size = new System.Drawing.Size(176, 47);
            this.lblCaseNumber.TabIndex = 0;
            this.lblCaseNumber.Text = "رقم الحالة:";
            this.lblCaseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCaseNumber
            // 
            this.txtCaseNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCaseNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCaseNumber.Location = new System.Drawing.Point(3, 3);
            this.txtCaseNumber.Name = "txtCaseNumber";
            this.txtCaseNumber.ReadOnly = true;
            this.txtCaseNumber.Size = new System.Drawing.Size(332, 30);
            this.txtCaseNumber.TabIndex = 1;
            // 
            // lblPatientName
            // 
            this.lblPatientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPatientName.Location = new System.Drawing.Point(341, 47);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(176, 47);
            this.lblPatientName.TabIndex = 2;
            this.lblPatientName.Text = "اسم المريض:";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatientName.Location = new System.Drawing.Point(3, 50);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(332, 30);
            this.txtPatientName.TabIndex = 3;
            // 
            // lblFileNumber
            // 
            this.lblFileNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFileNumber.Location = new System.Drawing.Point(341, 94);
            this.lblFileNumber.Name = "lblFileNumber";
            this.lblFileNumber.Size = new System.Drawing.Size(176, 47);
            this.lblFileNumber.TabIndex = 4;
            this.lblFileNumber.Text = "رقم الملف:";
            this.lblFileNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFileNumber
            // 
            this.txtFileNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFileNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFileNumber.Location = new System.Drawing.Point(3, 97);
            this.txtFileNumber.Name = "txtFileNumber";
            this.txtFileNumber.ReadOnly = true;
            this.txtFileNumber.Size = new System.Drawing.Size(332, 30);
            this.txtFileNumber.TabIndex = 5;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoctorName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDoctorName.Location = new System.Drawing.Point(341, 141);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(176, 47);
            this.lblDoctorName.TabIndex = 6;
            this.lblDoctorName.Text = "الطبيب:";
            this.lblDoctorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDoctorName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDoctorName.Location = new System.Drawing.Point(3, 144);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.ReadOnly = true;
            this.txtDoctorName.Size = new System.Drawing.Size(332, 30);
            this.txtDoctorName.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(341, 188);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(176, 47);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "السعر:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(3, 191);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(332, 30);
            this.txtPrice.TabIndex = 9;
            // 
            // lblPaid
            // 
            this.lblPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaid.Location = new System.Drawing.Point(341, 235);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(176, 47);
            this.lblPaid.TabIndex = 10;
            this.lblPaid.Text = "المدفوع:";
            this.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaid
            // 
            this.txtPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPaid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPaid.Location = new System.Drawing.Point(3, 238);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.ReadOnly = true;
            this.txtPaid.Size = new System.Drawing.Size(332, 30);
            this.txtPaid.TabIndex = 11;
            // 
            // lblRemaining
            // 
            this.lblRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRemaining.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemaining.Location = new System.Drawing.Point(341, 282);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(176, 47);
            this.lblRemaining.TabIndex = 12;
            this.lblRemaining.Text = "الباقي:";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRemaining
            // 
            this.txtRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemaining.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRemaining.Location = new System.Drawing.Point(3, 285);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.ReadOnly = true;
            this.txtRemaining.Size = new System.Drawing.Size(332, 30);
            this.txtRemaining.TabIndex = 13;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(341, 329);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(176, 47);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "التاريخ:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDate
            // 
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(3, 332);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(332, 30);
            this.dtpDate.TabIndex = 15;
            // 
            // lblTreatment
            // 
            this.lblTreatment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTreatment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTreatment.Location = new System.Drawing.Point(341, 376);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(176, 47);
            this.lblTreatment.TabIndex = 16;
            this.lblTreatment.Text = "العلاج:";
            this.lblTreatment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTreatment
            // 
            this.cmbTreatment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTreatment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTreatment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTreatment.FormattingEnabled = true;
            this.cmbTreatment.Location = new System.Drawing.Point(3, 379);
            this.cmbTreatment.Name = "cmbTreatment";
            this.cmbTreatment.Size = new System.Drawing.Size(332, 31);
            this.cmbTreatment.TabIndex = 17;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(341, 423);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(176, 47);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "الحالة:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(3, 426);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(332, 31);
            this.cmbStatus.TabIndex = 19;
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.btnSave);
            this.panelActions.Controls.Add(this.btnCancel);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 580);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(580, 70);
            this.panelActions.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(150, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(300, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // EditPatientRecordFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 650);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPatientRecordFormUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعديل بيانات سجل المريض";
            this.panelHeader.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblCaseNumber;
        private System.Windows.Forms.TextBox txtCaseNumber;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblFileNumber;
        private System.Windows.Forms.TextBox txtFileNumber;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.TextBox txtRemaining;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.ComboBox cmbTreatment;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
