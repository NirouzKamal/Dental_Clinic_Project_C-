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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHeaderBorder = new System.Windows.Forms.Panel();
            
            this.panelTop = new System.Windows.Forms.Panel();
            this.grpAddService = new System.Windows.Forms.GroupBox();
            this.cmbServiceName = new System.Windows.Forms.ComboBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblFinalPriceTitle = new System.Windows.Forms.Label();
            this.lblFinalPriceValue = new System.Windows.Forms.Label();
            this.btnAddService = new System.Windows.Forms.Button();

            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtFileNumber = new System.Windows.Forms.TextBox();
            this.lblFileNumber = new System.Windows.Forms.Label();

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
            this.panelGridArea.SuspendLayout();
            this.grpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.Controls.Add(this.lblTitle); this.panelHeader.Controls.Add(this.panelHeaderBorder);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top; this.panelHeader.Name = "panelHeader"; this.panelHeader.Size = new System.Drawing.Size(800, 50);
            this.lblTitle.AutoSize = true; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41); this.lblTitle.Location = new System.Drawing.Point(20, 15); this.lblTitle.Name = "lblTitle"; this.lblTitle.Text = "تسجيل خدمات المريض";
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(222, 226, 230); this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom; this.panelHeaderBorder.Name = "panelHeaderBorder"; this.panelHeaderBorder.Size = new System.Drawing.Size(800, 1);

            // panelTop
            this.panelTop.Controls.Add(this.panelPatientDetails);
            this.panelTop.Controls.Add(this.grpAddService);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20);
            this.panelTop.Size = new System.Drawing.Size(800, 240);

            // grpAddService
            this.grpAddService.Controls.Add(this.tlpAddService);
            this.grpAddService.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAddService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpAddService.Name = "grpAddService";
            this.grpAddService.Padding = new System.Windows.Forms.Padding(10);
            this.grpAddService.Size = new System.Drawing.Size(760, 200);
            this.grpAddService.Text = "إضافة خدمة جديدة";

            // tlpAddService
            this.tlpAddService = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAddService.ColumnCount = 4;
            this.tlpAddService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F)); // Labels
            this.tlpAddService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F)); // Inputs
            this.tlpAddService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F)); // Checkbox
            this.tlpAddService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F)); // Empty/FinalPrice
            this.tlpAddService.RowCount = 5;
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpAddService.Dock = System.Windows.Forms.DockStyle.Fill;

            // Row 1
            this.lblServiceName.Text = "نوع الخدمة:"; this.lblServiceName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbServiceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddService.Controls.Add(this.lblServiceName, 0, 0);
            this.tlpAddService.Controls.Add(this.cmbServiceName, 1, 0);
            this.tlpAddService.SetColumnSpan(this.cmbServiceName, 3);

            // Row 2
            this.lblPrice.Text = "التكلفة:"; this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill; this.txtPrice.Text = "0"; this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tlpAddService.Controls.Add(this.lblPrice, 0, 1);
            this.tlpAddService.Controls.Add(this.txtPrice, 1, 1);
            this.tlpAddService.SetColumnSpan(this.txtPrice, 3);

            // Row 3
            this.lblDiscount.Text = "الخصم:"; this.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkDiscount.Text = "يوجد خصم"; this.chkDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDiscount.Dock = System.Windows.Forms.DockStyle.Fill; this.txtDiscount.Text = "0"; this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right; this.txtDiscount.Enabled = false;
            this.tlpAddService.Controls.Add(this.lblDiscount, 0, 2);
            this.tlpAddService.Controls.Add(this.chkDiscount, 2, 2);
            this.tlpAddService.Controls.Add(this.txtDiscount, 1, 2);

            // Row 4
            this.lblFinalPriceTitle.Text = "السعر لهذه الخدمة:"; this.lblFinalPriceTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFinalPriceValue.Text = "0.00 د.ل"; this.lblFinalPriceValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold); this.lblFinalPriceValue.ForeColor = System.Drawing.Color.FromArgb(0, 75, 155); this.lblFinalPriceValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tlpAddService.Controls.Add(this.lblFinalPriceTitle, 0, 3);
            this.tlpAddService.Controls.Add(this.lblFinalPriceValue, 1, 3);

            // Row 5
            this.btnAddService.Text = "إضافة الخدمة"; this.btnAddService.BackColor = System.Drawing.Color.FromArgb(0, 75, 155); this.btnAddService.ForeColor = System.Drawing.Color.White; this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnAddService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddService.Controls.Add(this.btnAddService, 0, 4);
            this.tlpAddService.SetColumnSpan(this.btnAddService, 4);

            // Patient details (below GroupBox)
            this.panelPatientDetails = new System.Windows.Forms.Panel();
            this.panelPatientDetails.Controls.Add(this.lblPatientName);
            this.panelPatientDetails.Controls.Add(this.txtPatientName);
            this.panelPatientDetails.Controls.Add(this.lblFileNumber);
            this.panelPatientDetails.Controls.Add(this.txtFileNumber);
            this.panelPatientDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPatientDetails.Height = 40;
            this.panelPatientDetails.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);

            this.lblPatientName.Text = "اسم المريض:"; this.lblPatientName.AutoSize = true; this.lblPatientName.Location = new System.Drawing.Point(670, 15);
            this.txtPatientName.Location = new System.Drawing.Point(400, 12); this.txtPatientName.ReadOnly = true; this.txtPatientName.Size = new System.Drawing.Size(260, 23);
            this.lblFileNumber.Text = "رقم الملف:"; this.lblFileNumber.AutoSize = true; this.lblFileNumber.Location = new System.Drawing.Point(320, 15);
            this.txtFileNumber.Location = new System.Drawing.Point(120, 12); this.txtFileNumber.ReadOnly = true; this.txtFileNumber.Size = new System.Drawing.Size(180, 23);

            // panelGridArea
            this.panelGridArea.Controls.Add(this.grpServices);
            this.panelGridArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridArea.Name = "panelGridArea";
            this.panelGridArea.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);

            // grpServices
            this.grpServices.Controls.Add(this.dgvServices);
            this.grpServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpServices.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpServices.Name = "grpServices";
            this.grpServices.Text = "الخدمات المضافة (اضغط زر Delete للحذف)";

            // dgvServices
            this.dgvServices.AllowUserToAddRows = false; this.dgvServices.AllowUserToDeleteRows = true; this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; this.dgvServices.BackgroundColor = System.Drawing.Color.White; this.dgvServices.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvServices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal; this.dgvServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None; this.dgvServices.ColumnHeadersHeight = 40; this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill; this.dgvServices.EnableHeadersVisualStyles = false; this.dgvServices.GridColor = System.Drawing.Color.FromArgb(222, 226, 230); this.dgvServices.Name = "dgvServices"; this.dgvServices.ReadOnly = true; this.dgvServices.RightToLeft = System.Windows.Forms.RightToLeft.Yes; this.dgvServices.RowHeadersVisible = false; this.dgvServices.RowTemplate.Height = 40; this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colName, this.colPrice, this.colDiscount, this.colFinalPrice });
            this.colName.HeaderText = "نوع الخدمة"; this.colName.Name = "colName";
            this.colPrice.HeaderText = "التكلفة"; this.colPrice.Name = "colPrice";
            this.colDiscount.HeaderText = "الخصم"; this.colDiscount.Name = "colDiscount";
            this.colFinalPrice.HeaderText = "السعر النهائي"; this.colFinalPrice.Name = "colFinalPrice";

            // panelBottom
            this.panelBottom.Controls.Add(this.lblGrandTotal);
            this.panelBottom.Controls.Add(this.btnSave);
            this.panelBottom.Controls.Add(this.cmbApptStatus);
            this.panelBottom.Controls.Add(this.lblApptStatus);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 80);

            this.lblGrandTotal.AutoSize = true; this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold); this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(0, 75, 155); this.lblGrandTotal.Location = new System.Drawing.Point(50, 25); this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Text = "الإجمالي: 0.00 د.ل";

            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 75, 155); this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand; this.btnSave.FlatAppearance.BorderSize = 0; this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.btnSave.ForeColor = System.Drawing.Color.White; this.btnSave.Location = new System.Drawing.Point(300, 20); this.btnSave.Name = "btnSave"; this.btnSave.Size = new System.Drawing.Size(200, 40); this.btnSave.Text = "حفظ وإصدار الفاتورة"; this.btnSave.UseVisualStyleBackColor = false;

            this.lblApptStatus.AutoSize = true; this.lblApptStatus.Location = new System.Drawing.Point(700, 15); this.lblApptStatus.Name = "lblApptStatus";
            this.lblApptStatus.Text = "حالة الموعد:";
            this.cmbApptStatus.FormattingEnabled = true; this.cmbApptStatus.Location = new System.Drawing.Point(550, 35); this.cmbApptStatus.Name = "cmbApptStatus"; this.cmbApptStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbApptStatus.Items.AddRange(new object[] { "مكتمل", "قيد الانتظار" });
            this.cmbApptStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // 
            // DoctorServiceFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelGridArea);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorServiceFormUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تسجيل خدمات المريض";
            this.panelHeader.ResumeLayout(false); this.panelHeader.PerformLayout();
            this.panelTop.ResumeLayout(false); this.panelTop.PerformLayout();
            this.grpAddService.ResumeLayout(false); this.grpAddService.PerformLayout();
            this.panelGridArea.ResumeLayout(false);
            this.grpServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.panelBottom.ResumeLayout(false); this.panelBottom.PerformLayout();
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
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtFileNumber;
        private System.Windows.Forms.Label lblFileNumber;
        private System.Windows.Forms.Panel panelGridArea;
        private System.Windows.Forms.GroupBox grpServices;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
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
