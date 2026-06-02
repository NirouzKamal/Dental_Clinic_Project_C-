namespace DentalClinicProject.UI
{
    partial class DoctorServiceFormUI
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelHeaderBorder = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.grpAddService = new System.Windows.Forms.GroupBox();
            this.tlpAddService = new System.Windows.Forms.TableLayoutPanel();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.cmbServiceName = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblToothNumber = new System.Windows.Forms.Label();
            this.txtToothNumber = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblFinalPriceTitle = new System.Windows.Forms.Label();
            this.lblFinalPriceValue = new System.Windows.Forms.Label();
            this.btnAddService = new System.Windows.Forms.Button();
            this.panelPatientDetails = new System.Windows.Forms.Panel();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblFileNumber = new System.Windows.Forms.Label();
            this.txtFileNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.patientName = new System.Windows.Forms.TextBox();
            this.colToothNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGridArea = new System.Windows.Forms.Panel();
            this.grpServices = new System.Windows.Forms.GroupBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbApptStatus = new System.Windows.Forms.ComboBox();
            this.lblApptStatus = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.grpAddService.SuspendLayout();
            this.tlpAddService.SuspendLayout();
            this.panelPatientDetails.SuspendLayout();
            this.panelGridArea.SuspendLayout();
            this.grpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.panelHeaderBorder);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(700, 45);
            this.panelHeader.TabIndex = 3;
            // 
            // panelHeaderBorder
            // 
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeaderBorder.Location = new System.Drawing.Point(0, 43);
            this.panelHeaderBorder.Name = "panelHeaderBorder";
            this.panelHeaderBorder.Size = new System.Drawing.Size(700, 2);
            this.panelHeaderBorder.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTitle.Location = new System.Drawing.Point(8, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "تسجيل خدمات المريض";
            // 
            // panelPatientDetails
            // 
            this.panelPatientDetails.Controls.Add(this.label2);
            this.panelPatientDetails.Controls.Add(this.patientName);
            this.panelPatientDetails.Controls.Add(this.label1);
            this.panelPatientDetails.Controls.Add(this.txtFileNumber);
            this.panelPatientDetails.Controls.Add(this.lblPatientName);
            this.panelPatientDetails.Controls.Add(this.txtPatientName);
            this.panelPatientDetails.Controls.Add(this.lblFileNumber);
            this.panelPatientDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPatientDetails.Location = new System.Drawing.Point(0, 45);
            this.panelPatientDetails.Name = "panelPatientDetails";
            this.panelPatientDetails.Padding = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this.panelPatientDetails.Size = new System.Drawing.Size(700, 42);
            this.panelPatientDetails.TabIndex = 1;
            // 
            // lblPatientName
            // 
            this.lblPatientName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(560, 13);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(70, 15);
            this.lblPatientName.TabIndex = 0;
            this.lblPatientName.Text = "اسم المريض:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPatientName.Location = new System.Drawing.Point(400, 10);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(155, 20);
            this.txtPatientName.TabIndex = 1;
            this.txtPatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2 (اسم الحالة)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "اسم الحالة";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // patientName (case name textbox)
            // 
            this.patientName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.patientName.Location = new System.Drawing.Point(185, 10);
            this.patientName.Name = "patientName";
            this.patientName.ReadOnly = true;
            this.patientName.Size = new System.Drawing.Size(130, 20);
            this.patientName.TabIndex = 4;
            this.patientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1 (رقم الملف)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "رقم الملف";
            // 
            // lblFileNumber
            // 
            this.lblFileNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFileNumber.AutoSize = true;
            this.lblFileNumber.Location = new System.Drawing.Point(60, 13);
            this.lblFileNumber.Name = "lblFileNumber";
            this.lblFileNumber.Size = new System.Drawing.Size(55, 15);
            this.lblFileNumber.TabIndex = 2;
            this.lblFileNumber.Text = "رقم الملف:";
            // 
            // txtFileNumber
            // 
            this.txtFileNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtFileNumber.Location = new System.Drawing.Point(8, 10);
            this.txtFileNumber.Name = "txtFileNumber";
            this.txtFileNumber.ReadOnly = true;
            this.txtFileNumber.Size = new System.Drawing.Size(48, 20);
            this.txtFileNumber.TabIndex = 3;
            this.txtFileNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.grpAddService);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 87);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.panelTop.Size = new System.Drawing.Size(700, 285);
            this.panelTop.TabIndex = 2;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // grpAddService
            // 
            this.grpAddService.Controls.Add(this.tlpAddService);
            this.grpAddService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grpAddService.Location = new System.Drawing.Point(8, 6);
            this.grpAddService.Name = "grpAddService";
            this.grpAddService.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.grpAddService.Size = new System.Drawing.Size(684, 273);
            this.grpAddService.TabIndex = 0;
            this.grpAddService.TabStop = false;
            this.grpAddService.Text = "إضافة خدمة جديدة";
            // 
            // tlpAddService
            // 
            this.tlpAddService.ColumnCount = 4;
            this.tlpAddService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpAddService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpAddService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAddService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAddService.Controls.Add(this.lblServiceName, 3, 0);
            this.tlpAddService.Controls.Add(this.cmbServiceName, 0, 0);
            this.tlpAddService.Controls.Add(this.lblPrice, 3, 1);
            this.tlpAddService.Controls.Add(this.txtPrice, 0, 1);
            this.tlpAddService.Controls.Add(this.lblToothNumber, 3, 2);
            this.tlpAddService.Controls.Add(this.txtToothNumber, 0, 2);
            this.tlpAddService.Controls.Add(this.lblDiscount, 3, 3);
            this.tlpAddService.Controls.Add(this.chkDiscount, 2, 3);
            this.tlpAddService.Controls.Add(this.txtDiscount, 0, 3);
            this.tlpAddService.Controls.Add(this.lblFinalPriceTitle, 3, 4);
            this.tlpAddService.Controls.Add(this.lblFinalPriceValue, 0, 4);
            this.tlpAddService.Controls.Add(this.btnAddService, 0, 5);
            this.tlpAddService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddService.Location = new System.Drawing.Point(6, 20);
            this.tlpAddService.Name = "tlpAddService";
            this.tlpAddService.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tlpAddService.RowCount = 6;
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddService.Size = new System.Drawing.Size(672, 245);
            this.tlpAddService.TabIndex = 0;
            this.tlpAddService.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpAddService_Paint);
            // 
            // lblServiceName
            // 
            this.lblServiceName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(540, 8);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(65, 15);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "نوع الخدمة:";
            // 
            // cmbServiceName
            // 
            this.tlpAddService.SetColumnSpan(this.cmbServiceName, 3);
            this.cmbServiceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbServiceName.Location = new System.Drawing.Point(3, 3);
            this.cmbServiceName.Name = "cmbServiceName";
            this.cmbServiceName.Size = new System.Drawing.Size(530, 21);
            this.cmbServiceName.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(555, 40);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 15);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "التكلفة:";
            // 
            // txtPrice
            // 
            this.tlpAddService.SetColumnSpan(this.txtPrice, 3);
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Location = new System.Drawing.Point(3, 35);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(530, 20);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblToothNumber
            // 
            this.lblToothNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblToothNumber.AutoSize = true;
            this.lblToothNumber.Location = new System.Drawing.Point(555, 72);
            this.lblToothNumber.Name = "lblToothNumber";
            this.lblToothNumber.Size = new System.Drawing.Size(50, 15);
            this.lblToothNumber.TabIndex = 4;
            this.lblToothNumber.Text = "رقم السن:";
            // 
            // txtToothNumber
            // 
            this.tlpAddService.SetColumnSpan(this.txtToothNumber, 3);
            this.txtToothNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtToothNumber.Location = new System.Drawing.Point(3, 67);
            this.txtToothNumber.Name = "txtToothNumber";
            this.txtToothNumber.Size = new System.Drawing.Size(530, 20);
            this.txtToothNumber.TabIndex = 5;
            this.txtToothNumber.Text = "1";
            this.txtToothNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(557, 105);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(48, 15);
            this.lblDiscount.TabIndex = 6;
            this.lblDiscount.Text = "الخصم:";
            // 
            // chkDiscount
            // 
            this.chkDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkDiscount.AutoSize = true;
            this.chkDiscount.Location = new System.Drawing.Point(405, 101);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(75, 19);
            this.chkDiscount.TabIndex = 7;
            this.chkDiscount.Text = "يوجد خصم";
            // 
            // txtDiscount
            // 
            this.tlpAddService.SetColumnSpan(this.txtDiscount, 2);
            this.txtDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Location = new System.Drawing.Point(3, 99);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(395, 20);
            this.txtDiscount.TabIndex = 8;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFinalPriceTitle
            // 
            this.lblFinalPriceTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFinalPriceTitle.AutoSize = true;
            this.lblFinalPriceTitle.Location = new System.Drawing.Point(540, 138);
            this.lblFinalPriceTitle.Name = "lblFinalPriceTitle";
            this.lblFinalPriceTitle.Size = new System.Drawing.Size(65, 15);
            this.lblFinalPriceTitle.TabIndex = 9;
            this.lblFinalPriceTitle.Text = "السعر لهذه الخدمة:";
            // 
            // lblFinalPriceValue
            // 
            this.lblFinalPriceValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tlpAddService.SetColumnSpan(this.lblFinalPriceValue, 3);
            this.lblFinalPriceValue.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lblFinalPriceValue.ForeColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.lblFinalPriceValue.Location = new System.Drawing.Point(3, 131);
            this.lblFinalPriceValue.Name = "lblFinalPriceValue";
            this.lblFinalPriceValue.Size = new System.Drawing.Size(100, 22);
            this.lblFinalPriceValue.TabIndex = 10;
            this.lblFinalPriceValue.Text = "0.00 د.ل";
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.tlpAddService.SetColumnSpan(this.btnAddService, 4);
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Location = new System.Drawing.Point(3, 163);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(666, 79);
            this.btnAddService.TabIndex = 11;
            this.btnAddService.Text = "إضافة";
            this.btnAddService.UseVisualStyleBackColor = false;
            // 
            // colToothNumber
            // 
            this.colToothNumber.HeaderText = "رقم السن";
            this.colToothNumber.MinimumWidth = 6;
            this.colToothNumber.Name = "colToothNumber";
            this.colToothNumber.ReadOnly = true;
            // 
            // panelGridArea
            // 
            this.panelGridArea.Controls.Add(this.grpServices);
            this.panelGridArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridArea.Location = new System.Drawing.Point(0, 372);
            this.panelGridArea.Name = "panelGridArea";
            this.panelGridArea.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelGridArea.Size = new System.Drawing.Size(700, 220);
            this.panelGridArea.TabIndex = 0;
            // 
            // grpServices
            // 
            this.grpServices.Controls.Add(this.dgvServices);
            this.grpServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grpServices.Location = new System.Drawing.Point(8, 4);
            this.grpServices.Name = "grpServices";
            this.grpServices.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpServices.Size = new System.Drawing.Size(684, 212);
            this.grpServices.TabIndex = 0;
            this.grpServices.TabStop = false;
            this.grpServices.Text = "الخدمات المضافة (اضغط زر Delete للحذف)";
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.BackgroundColor = System.Drawing.Color.White;
            this.dgvServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvServices.ColumnHeadersHeight = 28;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colToothNumber,
            this.colPrice,
            this.colDiscount,
            this.colFinalPrice});
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.EnableHeadersVisualStyles = false;
            this.dgvServices.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.dgvServices.Location = new System.Drawing.Point(4, 20);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.RowTemplate.Height = 24;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(676, 188);
            this.dgvServices.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.HeaderText = "نوع الخدمة";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "التكلفة";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "الخصم";
            this.colDiscount.MinimumWidth = 6;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // 
            // colFinalPrice
            // 
            this.colFinalPrice.HeaderText = "السعر النهائي";
            this.colFinalPrice.MinimumWidth = 6;
            this.colFinalPrice.Name = "colFinalPrice";
            this.colFinalPrice.ReadOnly = true;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblGrandTotal);
            this.panelBottom.Controls.Add(this.btnSave);
            this.panelBottom.Controls.Add(this.cmbApptStatus);
            this.panelBottom.Controls.Add(this.lblApptStatus);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 592);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(700, 55);
            this.panelBottom.TabIndex = 1;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.lblGrandTotal.Location = new System.Drawing.Point(8, 18);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(150, 17);
            this.lblGrandTotal.TabIndex = 0;
            this.lblGrandTotal.Text = "الإجمالي: 0.00 د.ل";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(250, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ وإصدار الفاتورة";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // cmbApptStatus
            // 
            this.cmbApptStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbApptStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApptStatus.FormattingEnabled = true;
            this.cmbApptStatus.Items.AddRange(new object[] {
            "مكتمل",
            "قيد الانتظار"});
            this.cmbApptStatus.Location = new System.Drawing.Point(520, 17);
            this.cmbApptStatus.Name = "cmbApptStatus";
            this.cmbApptStatus.Size = new System.Drawing.Size(110, 21);
            this.cmbApptStatus.TabIndex = 2;
            // 
            // lblApptStatus
            // 
            this.lblApptStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApptStatus.AutoSize = true;
            this.lblApptStatus.Location = new System.Drawing.Point(638, 21);
            this.lblApptStatus.Name = "lblApptStatus";
            this.lblApptStatus.Size = new System.Drawing.Size(55, 15);
            this.lblApptStatus.TabIndex = 3;
            this.lblApptStatus.Text = "حالة الموعد:";
            // 
            // DoctorServiceFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 647);
            this.Controls.Add(this.panelGridArea);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelPatientDetails);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 647);
            this.Name = "DoctorServiceFormUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تسجيل خدمات المريض";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.grpAddService.ResumeLayout(false);
            this.tlpAddService.ResumeLayout(false);
            this.tlpAddService.PerformLayout();
            this.panelPatientDetails.ResumeLayout(false);
            this.panelPatientDetails.PerformLayout();
            this.panelGridArea.ResumeLayout(false);
            this.grpServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelHeaderBorder;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.GroupBox grpAddService;
        private System.Windows.Forms.ComboBox cmbServiceName;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.CheckBox chkDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblFinalPriceTitle;
        private System.Windows.Forms.Label lblFinalPriceValue;
        private System.Windows.Forms.Label lblToothNumber;
        private System.Windows.Forms.TextBox txtToothNumber;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtFileNumber;
        private System.Windows.Forms.Label lblFileNumber;
        private System.Windows.Forms.Panel panelGridArea;
        private System.Windows.Forms.GroupBox grpServices;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToothNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinalPrice;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbApptStatus;
        private System.Windows.Forms.Label lblApptStatus;
        private System.Windows.Forms.TableLayoutPanel tlpAddService;
        private System.Windows.Forms.Panel panelPatientDetails;
        private System.Windows.Forms.TextBox patientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
