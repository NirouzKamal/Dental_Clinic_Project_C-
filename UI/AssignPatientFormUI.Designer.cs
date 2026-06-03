namespace DentalClinicProject.UI
{
    partial class AssignPatientFormUI
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tlpInputs = new System.Windows.Forms.TableLayoutPanel();
            this.lblFileNumber = new System.Windows.Forms.Label();
            this.txtFileNumber = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.lblVisitType = new System.Windows.Forms.Label();
            this.cmbVisitType = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelSideBorder = new System.Windows.Forms.Panel();
            this.lblTotalDebt = new System.Windows.Forms.Label();
            this.txtTotalDebt = new System.Windows.Forms.TextBox();
            this.btnPatientRecords = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelBottomBar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tlpInputs.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.panelHeaderBorder);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1786, 69);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(38, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(290, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إنشاء حالة جديدة";
            // 
            // panelHeaderBorder
            // 
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeaderBorder.Location = new System.Drawing.Point(0, 68);
            this.panelHeaderBorder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelHeaderBorder.Name = "panelHeaderBorder";
            this.panelHeaderBorder.Size = new System.Drawing.Size(1786, 1);
            this.panelHeaderBorder.TabIndex = 1;
            // 
            // panelBottomBar
            // 
            this.panelBottomBar.Controls.Add(this.btnSave);
            this.panelBottomBar.Controls.Add(this.panelBottomBorder);
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBar.Location = new System.Drawing.Point(0, 655);
            this.panelBottomBar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Padding = new System.Windows.Forms.Padding(26, 15, 26, 15);
            this.panelBottomBar.Size = new System.Drawing.Size(1786, 89);
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
            this.btnSave.Location = new System.Drawing.Point(1440, 16);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(320, 58);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "إنشاء الحالة";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // panelBottomBorder
            // 
            this.panelBottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panelBottomBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottomBorder.Location = new System.Drawing.Point(26, 15);
            this.panelBottomBorder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelBottomBorder.Name = "panelBottomBorder";
            this.panelBottomBorder.Size = new System.Drawing.Size(1734, 1);
            this.panelBottomBorder.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelMain);
            this.panelContent.Controls.Add(this.panelSide);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 69);
            this.panelContent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1786, 586);
            this.panelContent.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tlpInputs);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(38, 20, 26, 20);
            this.panelMain.Size = new System.Drawing.Size(1327, 586);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // tlpInputs
            // 
            this.tlpInputs.ColumnCount = 2;
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInputs.Controls.Add(this.lblFileNumber, 0, 0);
            this.tlpInputs.Controls.Add(this.txtFileNumber, 1, 0);
            this.tlpInputs.Controls.Add(this.lblPatientName, 0, 1);
            this.tlpInputs.Controls.Add(this.cmbPatient, 1, 1);
            this.tlpInputs.Controls.Add(this.lblDoctorName, 0, 2);
            this.tlpInputs.Controls.Add(this.cmbDoctor, 1, 2);
            this.tlpInputs.Controls.Add(this.lblVisitType, 0, 3);
            this.tlpInputs.Controls.Add(this.cmbVisitType, 1, 3);
            this.tlpInputs.Controls.Add(this.lblPrice, 0, 4);
            this.tlpInputs.Controls.Add(this.txtPrice, 1, 4);
            this.tlpInputs.Controls.Add(this.lblPaid, 0, 5);
            this.tlpInputs.Controls.Add(this.txtPaid, 1, 5);
            this.tlpInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInputs.Location = new System.Drawing.Point(38, 20);
            this.tlpInputs.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tlpInputs.Name = "tlpInputs";
            this.tlpInputs.RowCount = 6;
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInputs.Size = new System.Drawing.Size(1263, 546);
            this.tlpInputs.TabIndex = 0;
            // 
            // lblFileNumber
            // 
            this.lblFileNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileNumber.AutoSize = true;
            this.lblFileNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFileNumber.Location = new System.Drawing.Point(948, 22);
            this.lblFileNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFileNumber.Name = "lblFileNumber";
            this.lblFileNumber.Size = new System.Drawing.Size(310, 46);
            this.lblFileNumber.TabIndex = 0;
            this.lblFileNumber.Text = "رقم الملف";
            this.lblFileNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFileNumber
            // 
            this.txtFileNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtFileNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFileNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFileNumber.Location = new System.Drawing.Point(13, 7);
            this.txtFileNumber.Margin = new System.Windows.Forms.Padding(13, 7, 13, 7);
            this.txtFileNumber.Name = "txtFileNumber";
            this.txtFileNumber.ReadOnly = true;
            this.txtFileNumber.Size = new System.Drawing.Size(917, 52);
            this.txtFileNumber.TabIndex = 1;
            // 
            // lblPatientName
            // 
            this.lblPatientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPatientName.Location = new System.Drawing.Point(948, 113);
            this.lblPatientName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(310, 46);
            this.lblPatientName.TabIndex = 2;
            this.lblPatientName.Text = "اسم المريض";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPatient
            // 
            this.cmbPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPatient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPatient.Location = new System.Drawing.Point(13, 98);
            this.cmbPatient.Margin = new System.Windows.Forms.Padding(13, 7, 13, 7);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(917, 53);
            this.cmbPatient.TabIndex = 3;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDoctorName.Location = new System.Drawing.Point(948, 204);
            this.lblDoctorName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(310, 46);
            this.lblDoctorName.TabIndex = 4;
            this.lblDoctorName.Text = "اسم الطبيب";
            this.lblDoctorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDoctor.Location = new System.Drawing.Point(13, 189);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(13, 7, 13, 7);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(917, 53);
            this.cmbDoctor.TabIndex = 5;
            // 
            // lblVisitType
            // 
            this.lblVisitType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVisitType.AutoSize = true;
            this.lblVisitType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVisitType.Location = new System.Drawing.Point(948, 295);
            this.lblVisitType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVisitType.Name = "lblVisitType";
            this.lblVisitType.Size = new System.Drawing.Size(310, 46);
            this.lblVisitType.TabIndex = 6;
            this.lblVisitType.Text = "نوع الزيارة";
            this.lblVisitType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbVisitType
            // 
            this.cmbVisitType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbVisitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVisitType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbVisitType.Location = new System.Drawing.Point(13, 280);
            this.cmbVisitType.Margin = new System.Windows.Forms.Padding(13, 7, 13, 7);
            this.cmbVisitType.Name = "cmbVisitType";
            this.cmbVisitType.Size = new System.Drawing.Size(917, 53);
            this.cmbVisitType.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrice.Location = new System.Drawing.Point(948, 386);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(310, 46);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "السعر";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(13, 371);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(13, 7, 13, 7);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(917, 52);
            this.txtPrice.TabIndex = 9;
            // 
            // lblPaid
            // 
            this.lblPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPaid.Location = new System.Drawing.Point(948, 477);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(310, 46);
            this.lblPaid.TabIndex = 10;
            this.lblPaid.Text = "المبلغ المدفوع";
            this.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaid
            // 
            this.txtPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPaid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPaid.Location = new System.Drawing.Point(13, 462);
            this.txtPaid.Margin = new System.Windows.Forms.Padding(13, 7, 13, 7);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(917, 52);
            this.txtPaid.TabIndex = 11;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelSide.Controls.Add(this.panelSideBorder);
            this.panelSide.Controls.Add(this.lblTotalDebt);
            this.panelSide.Controls.Add(this.txtTotalDebt);
            this.panelSide.Controls.Add(this.btnPatientRecords);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSide.Location = new System.Drawing.Point(1327, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelSide.Name = "panelSide";
            this.panelSide.Padding = new System.Windows.Forms.Padding(26, 20, 26, 20);
            this.panelSide.Size = new System.Drawing.Size(459, 586);
            this.panelSide.TabIndex = 0;
            this.panelSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSide_Paint);
            // 
            // panelSideBorder
            // 
            this.panelSideBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panelSideBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBorder.Location = new System.Drawing.Point(26, 20);
            this.panelSideBorder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelSideBorder.Name = "panelSideBorder";
            this.panelSideBorder.Size = new System.Drawing.Size(2, 546);
            this.panelSideBorder.TabIndex = 0;
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.AutoSize = true;
            this.lblTotalDebt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalDebt.Location = new System.Drawing.Point(98, 66);
            this.lblTotalDebt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(306, 46);
            this.lblTotalDebt.TabIndex = 3;
            this.lblTotalDebt.Text = "رصيد الديون المتبقي";
            // 
            // txtTotalDebt
            // 
            this.txtTotalDebt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalDebt.BackColor = System.Drawing.Color.White;
            this.txtTotalDebt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtTotalDebt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTotalDebt.Location = new System.Drawing.Point(127, 127);
            this.txtTotalDebt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTotalDebt.Name = "txtTotalDebt";
            this.txtTotalDebt.ReadOnly = true;
            this.txtTotalDebt.Size = new System.Drawing.Size(207, 56);
            this.txtTotalDebt.TabIndex = 4;
            this.txtTotalDebt.Text = "0.00 د.ل";
            this.txtTotalDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPatientRecords
            // 
            this.btnPatientRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatientRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.btnPatientRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientRecords.FlatAppearance.BorderSize = 0;
            this.btnPatientRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientRecords.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientRecords.ForeColor = System.Drawing.Color.White;
            this.btnPatientRecords.Location = new System.Drawing.Point(57, 209);
            this.btnPatientRecords.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPatientRecords.Name = "btnPatientRecords";
            this.btnPatientRecords.Size = new System.Drawing.Size(375, 60);
            this.btnPatientRecords.TabIndex = 7;
            this.btnPatientRecords.Text = "سجل المريض";
            this.btnPatientRecords.UseVisualStyleBackColor = false;
            // 
            // AssignPatientFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelBottomBar);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssignPatientFormUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إنشاء حالة جديدة";
            this.Load += new System.EventHandler(this.AssignPatientFormUI_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBottomBar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.tlpInputs.ResumeLayout(false);
            this.tlpInputs.PerformLayout();
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelHeaderBorder;
        private System.Windows.Forms.Panel panelBottomBar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelBottomBorder;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tlpInputs;
        private System.Windows.Forms.Label lblFileNumber;
        private System.Windows.Forms.TextBox txtFileNumber;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label lblVisitType;
        private System.Windows.Forms.ComboBox cmbVisitType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelSideBorder;
        private System.Windows.Forms.Label lblTotalDebt;
        private System.Windows.Forms.TextBox txtTotalDebt;
        private System.Windows.Forms.Button btnPatientRecords;
    }
}
