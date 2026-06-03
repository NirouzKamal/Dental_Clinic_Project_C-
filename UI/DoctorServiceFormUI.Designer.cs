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
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panelHeaderBorder);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(950, 55);
            this.panelHeader.TabIndex = 3;
            // 
            // panelHeaderBorder
            // 
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeaderBorder.Location = new System.Drawing.Point(0, 53);
            this.panelHeaderBorder.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeaderBorder.Name = "panelHeaderBorder";
            this.panelHeaderBorder.Size = new System.Drawing.Size(950, 2);
            this.panelHeaderBorder.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(750, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "تسجيل خدمات المريض";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.grpAddService);
            this.panelTop.Controls.Add(this.panelPatientDetails);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.panelTop.Size = new System.Drawing.Size(950, 340);
            this.panelTop.TabIndex = 2;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // grpAddService
            // 
            this.grpAddService.Controls.Add(this.tlpAddService);
            this.grpAddService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpAddService.Location = new System.Drawing.Point(12, 65);
            this.grpAddService.Margin = new System.Windows.Forms.Padding(4);
            this.grpAddService.Name = "grpAddService";
            this.grpAddService.Padding = new System.Windows.Forms.Padding(6);
            this.grpAddService.Size = new System.Drawing.Size(926, 260);
            this.grpAddService.TabIndex = 0;
            this.grpAddService.TabStop = false;
            this.grpAddService.Text = "إضافة خدمة جديدة";
            // 
            // tlpAddService
            // 
            this.tlpAddService.ColumnCount = 4;
            this.tlpAddService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlpAddService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlpAddService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlpAddService.Controls.Add(this.lblServiceName, 0, 0);
            this.tlpAddService.Controls.Add(this.cmbServiceName, 1, 0);
            this.tlpAddService.Controls.Add(this.lblPrice, 0, 1);
            this.tlpAddService.Controls.Add(this.txtPrice, 1, 1);
            this.tlpAddService.Controls.Add(this.lblToothNumber, 0, 2);
            this.tlpAddService.Controls.Add(this.txtToothNumber, 1, 2);
            this.tlpAddService.Controls.Add(this.lblDiscount, 0, 3);
            this.tlpAddService.Controls.Add(this.chkDiscount, 2, 3);
            this.tlpAddService.Controls.Add(this.txtDiscount, 1, 3);
            this.tlpAddService.Controls.Add(this.lblFinalPriceTitle, 0, 4);
            this.tlpAddService.Controls.Add(this.lblFinalPriceValue, 1, 4);
            this.tlpAddService.Controls.Add(this.btnAddService, 0, 5);
            this.tlpAddService.Location = new System.Drawing.Point(15, 25);
            this.tlpAddService.Margin = new System.Windows.Forms.Padding(4);
            this.tlpAddService.Name = "tlpAddService";
            this.tlpAddService.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tlpAddService.RowCount = 6;
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpAddService.Size = new System.Drawing.Size(896, 220);
            this.tlpAddService.TabIndex = 0;
            this.tlpAddService.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpAddService_Paint);
            // 
            // lblServiceName
            // 
            this.lblServiceName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblServiceName.Location = new System.Drawing.Point(1213, 14);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(267, 55);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "نوع الخدمة:";
            // 
            // cmbServiceName
            // 
            this.tlpAddService.SetColumnSpan(this.cmbServiceName, 3);
            this.cmbServiceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbServiceName.Location = new System.Drawing.Point(8, 7);
            this.cmbServiceName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbServiceName.Name = "cmbServiceName";
            this.cmbServiceName.Size = new System.Drawing.Size(1189, 49);
            this.cmbServiceName.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrice.Location = new System.Drawing.Point(1213, 97);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(267, 55);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "التكلفة:";
            // 
            // txtPrice
            // 
            this.tlpAddService.SetColumnSpan(this.txtPrice, 3);
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Location = new System.Drawing.Point(8, 90);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(1189, 47);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblToothNumber
            // 
            this.lblToothNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblToothNumber.Location = new System.Drawing.Point(1213, 180);
            this.lblToothNumber.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblToothNumber.Name = "lblToothNumber";
            this.lblToothNumber.Size = new System.Drawing.Size(267, 55);
            this.lblToothNumber.TabIndex = 4;
            this.lblToothNumber.Text = "رقم السن:";
            // 
            // txtToothNumber
            // 
            this.tlpAddService.SetColumnSpan(this.txtToothNumber, 3);
            this.txtToothNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtToothNumber.Location = new System.Drawing.Point(8, 173);
            this.txtToothNumber.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtToothNumber.Name = "txtToothNumber";
            this.txtToothNumber.Size = new System.Drawing.Size(1189, 47);
            this.txtToothNumber.TabIndex = 5;
            this.txtToothNumber.Text = "1";
            this.txtToothNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDiscount.Location = new System.Drawing.Point(1213, 263);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(267, 55);
            this.lblDiscount.TabIndex = 6;
            this.lblDiscount.Text = "الخصم:";
            // 
            // chkDiscount
            // 
            this.chkDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkDiscount.Location = new System.Drawing.Point(411, 262);
            this.chkDiscount.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(251, 57);
            this.chkDiscount.TabIndex = 7;
            this.chkDiscount.Text = "يوجد خصم";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Location = new System.Drawing.Point(812, 256);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(385, 47);
            this.txtDiscount.TabIndex = 8;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFinalPriceTitle
            // 
            this.lblFinalPriceTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFinalPriceTitle.Location = new System.Drawing.Point(1213, 346);
            this.lblFinalPriceTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFinalPriceTitle.Name = "lblFinalPriceTitle";
            this.lblFinalPriceTitle.Size = new System.Drawing.Size(267, 55);
            this.lblFinalPriceTitle.TabIndex = 9;
            this.lblFinalPriceTitle.Text = "السعر لهذه الخدمة:";
            // 
            // lblFinalPriceValue
            // 
            this.lblFinalPriceValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tlpAddService.SetColumnSpan(this.lblFinalPriceValue, 3);
            this.lblFinalPriceValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFinalPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.lblFinalPriceValue.Location = new System.Drawing.Point(8, 346);
            this.lblFinalPriceValue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFinalPriceValue.Name = "lblFinalPriceValue";
            this.lblFinalPriceValue.Size = new System.Drawing.Size(267, 55);
            this.lblFinalPriceValue.TabIndex = 10;
            this.lblFinalPriceValue.Text = "0.00 د.ل";
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.tlpAddService.SetColumnSpan(this.btnAddService, 4);
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Location = new System.Drawing.Point(8, 422);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(1791, 103);
            this.btnAddService.TabIndex = 11;
            this.btnAddService.Text = "إضافة";
            this.btnAddService.UseVisualStyleBackColor = false;
            // 
            // 
            // panelPatientDetails
            // 
            this.panelPatientDetails.Controls.Add(this.lblTitle);
            this.panelPatientDetails.Controls.Add(this.lblPatientName);
            this.panelPatientDetails.Controls.Add(this.txtPatientName);
            this.panelPatientDetails.Controls.Add(this.lblFileNumber);
            this.panelPatientDetails.Controls.Add(this.txtFileNumber);
            this.panelPatientDetails.Location = new System.Drawing.Point(12, 10);
            this.panelPatientDetails.Margin = new System.Windows.Forms.Padding(4);
            this.panelPatientDetails.Name = "panelPatientDetails";
            this.panelPatientDetails.Size = new System.Drawing.Size(926, 45);
            this.panelPatientDetails.TabIndex = 1;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(20, 12);
            this.lblPatientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(90, 20);
            this.lblPatientName.TabIndex = 0;
            this.lblPatientName.Text = "اسم المريض:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(115, 8);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(400, 27);
            this.txtPatientName.TabIndex = 1;
            // 
            // lblFileNumber
            // 
            this.lblFileNumber.AutoSize = true;
            this.lblFileNumber.Location = new System.Drawing.Point(530, 12);
            this.lblFileNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileNumber.Name = "lblFileNumber";
            this.lblFileNumber.Size = new System.Drawing.Size(80, 20);
            this.lblFileNumber.TabIndex = 2;
            this.lblFileNumber.Text = "رقم الملف:";
            // 
            // txtFileNumber
            // 
            this.txtFileNumber.Location = new System.Drawing.Point(615, 8);
            this.txtFileNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileNumber.Name = "txtFileNumber";
            this.txtFileNumber.ReadOnly = true;
            this.txtFileNumber.Size = new System.Drawing.Size(120, 27);
            this.txtFileNumber.TabIndex = 3;
            // 
            // colToothNumber
            // 
            this.colToothNumber.HeaderText = "رقم السن";
            this.colToothNumber.MinimumWidth = 12;
            this.colToothNumber.Name = "colToothNumber";
            this.colToothNumber.ReadOnly = true;
            // 
            // 
            // panelGridArea
            // 
            this.panelGridArea.Controls.Add(this.grpServices);
            this.panelGridArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridArea.Location = new System.Drawing.Point(0, 395);
            this.panelGridArea.Margin = new System.Windows.Forms.Padding(4);
            this.panelGridArea.Name = "panelGridArea";
            this.panelGridArea.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.panelGridArea.Size = new System.Drawing.Size(950, 310);
            this.panelGridArea.TabIndex = 0;
            // 
            // grpServices
            // 
            this.grpServices.Controls.Add(this.dgvServices);
            this.grpServices.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpServices.Location = new System.Drawing.Point(12, 5);
            this.grpServices.Margin = new System.Windows.Forms.Padding(4);
            this.grpServices.Name = "grpServices";
            this.grpServices.Padding = new System.Windows.Forms.Padding(4);
            this.grpServices.Size = new System.Drawing.Size(926, 290);
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
            this.dgvServices.ColumnHeadersHeight = 40;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colToothNumber,
            this.colPrice,
            this.colDiscount,
            this.colFinalPrice});
            this.dgvServices.EnableHeadersVisualStyles = false;
            this.dgvServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvServices.Location = new System.Drawing.Point(10, 25);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(4);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.RowHeadersWidth = 102;
            this.dgvServices.RowTemplate.Height = 40;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(906, 255);
            this.dgvServices.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.HeaderText = "نوع الخدمة";
            this.colName.MinimumWidth = 12;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "التكلفة";
            this.colPrice.MinimumWidth = 12;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "الخصم";
            this.colDiscount.MinimumWidth = 12;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // 
            // colFinalPrice
            // 
            this.colFinalPrice.HeaderText = "السعر النهائي";
            this.colFinalPrice.MinimumWidth = 12;
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
            this.panelBottom.Location = new System.Drawing.Point(0, 705);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(950, 75);
            this.panelBottom.TabIndex = 1;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.lblGrandTotal.Location = new System.Drawing.Point(20, 22);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(250, 30);
            this.lblGrandTotal.TabIndex = 0;
            this.lblGrandTotal.Text = "الإجمالي: 0.00 د.ل";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(300, 15);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(250, 45);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ وإصدار الفاتورة";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // cmbApptStatus
            // 
            this.cmbApptStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApptStatus.FormattingEnabled = true;
            this.cmbApptStatus.Items.AddRange(new object[] {
            "مكتمل",
            "قيد الانتظار"});
            this.cmbApptStatus.Location = new System.Drawing.Point(680, 15);
            this.cmbApptStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbApptStatus.Name = "cmbApptStatus";
            this.cmbApptStatus.Size = new System.Drawing.Size(200, 30);
            this.cmbApptStatus.TabIndex = 2;
            // 
            // lblApptStatus
            // 
            this.lblApptStatus.AutoSize = true;
            this.lblApptStatus.Location = new System.Drawing.Point(580, 22);
            this.lblApptStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApptStatus.Name = "lblApptStatus";
            this.lblApptStatus.Size = new System.Drawing.Size(90, 20);
            this.lblApptStatus.TabIndex = 3;
            this.lblApptStatus.Text = "حالة الموعد:";
            // 
            // DoctorServiceFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 780);
            this.Controls.Add(this.panelGridArea);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorServiceFormUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تسجيل خدمات المريض";
            this.panelHeader.ResumeLayout(false);
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
    }
}
