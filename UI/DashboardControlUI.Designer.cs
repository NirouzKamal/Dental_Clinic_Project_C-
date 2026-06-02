namespace DentalClinicProject.UI
{
    partial class DashboardControlUI
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.tlpKPIs = new System.Windows.Forms.TableLayoutPanel();
            this.panelKPI1 = new System.Windows.Forms.Panel();
            this.lblTotalAppointmentsValue = new System.Windows.Forms.Label();
            this.lblTotalAppointmentsTitle = new System.Windows.Forms.Label();
            this.panelKPI2 = new System.Windows.Forms.Panel();
            this.lblWaitingCasesValue = new System.Windows.Forms.Label();
            this.lblWaitingCasesTitle = new System.Windows.Forms.Label();
            this.panelKPI3 = new System.Windows.Forms.Panel();
            this.lblCompletedCasesValue = new System.Windows.Forms.Label();
            this.lblCompletedCasesTitle = new System.Windows.Forms.Label();
            this.panelKPI4 = new System.Windows.Forms.Panel();
            this.lblTodayRevenueValue = new System.Windows.Forms.Label();
            this.lblTodayRevenueTitle = new System.Windows.Forms.Label();
            this.panelActionBar = new System.Windows.Forms.Panel();
            this.panelLeftSpacer2 = new System.Windows.Forms.Panel();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.panelLeftSpacer = new System.Windows.Forms.Panel();
            this.btnMyPatients = new System.Windows.Forms.Button();
            this.panelBtnSpacer2 = new System.Windows.Forms.Panel();
            this.btnPendingInvoices = new System.Windows.Forms.Button();
            this.panelBtnSpacer1 = new System.Windows.Forms.Panel();
            this.btnAssignPatient = new System.Windows.Forms.Button();
            this.panelGridArea = new System.Windows.Forms.Panel();
            this.dgvTodayAppointments = new System.Windows.Forms.DataGridView();
            this.colFileNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpKPIs.SuspendLayout();
            this.panelKPI1.SuspendLayout();
            this.panelKPI2.SuspendLayout();
            this.panelKPI3.SuspendLayout();
            this.panelKPI4.SuspendLayout();
            this.panelActionBar.SuspendLayout();
            this.panelGridArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpKPIs
            // 
            this.tlpKPIs.ColumnCount = 4;
            this.tlpKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKPIs.Controls.Add(this.panelKPI1, 0, 0);
            this.tlpKPIs.Controls.Add(this.panelKPI2, 1, 0);
            this.tlpKPIs.Controls.Add(this.panelKPI3, 2, 0);
            this.tlpKPIs.Controls.Add(this.panelKPI4, 3, 0);
            this.tlpKPIs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpKPIs.Location = new System.Drawing.Point(0, 0);
            this.tlpKPIs.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tlpKPIs.Name = "tlpKPIs";
            this.tlpKPIs.Padding = new System.Windows.Forms.Padding(53, 48, 53, 48);
            this.tlpKPIs.RowCount = 1;
            this.tlpKPIs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKPIs.Size = new System.Drawing.Size(2491, 358);
            this.tlpKPIs.TabIndex = 0;
            // 
            // panelKPI1
            // 
            this.panelKPI1.BackColor = System.Drawing.Color.White;
            this.panelKPI1.Controls.Add(this.lblTotalAppointmentsValue);
            this.panelKPI1.Controls.Add(this.lblTotalAppointmentsTitle);
            this.panelKPI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKPI1.Location = new System.Drawing.Point(1869, 72);
            this.panelKPI1.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.panelKPI1.Name = "panelKPI1";
            this.panelKPI1.Size = new System.Drawing.Size(542, 214);
            this.panelKPI1.TabIndex = 0;
            // 
            // lblTotalAppointmentsValue
            // 
            this.lblTotalAppointmentsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAppointmentsValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalAppointmentsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.lblTotalAppointmentsValue.Location = new System.Drawing.Point(0, 72);
            this.lblTotalAppointmentsValue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTotalAppointmentsValue.Name = "lblTotalAppointmentsValue";
            this.lblTotalAppointmentsValue.Size = new System.Drawing.Size(542, 142);
            this.lblTotalAppointmentsValue.TabIndex = 1;
            this.lblTotalAppointmentsValue.Text = "0";
            this.lblTotalAppointmentsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAppointmentsTitle
            // 
            this.lblTotalAppointmentsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalAppointmentsTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalAppointmentsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTotalAppointmentsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTotalAppointmentsTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTotalAppointmentsTitle.Name = "lblTotalAppointmentsTitle";
            this.lblTotalAppointmentsTitle.Size = new System.Drawing.Size(542, 72);
            this.lblTotalAppointmentsTitle.TabIndex = 0;
            this.lblTotalAppointmentsTitle.Text = "مواعيد اليوم";
            this.lblTotalAppointmentsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKPI2
            // 
            this.panelKPI2.BackColor = System.Drawing.Color.White;
            this.panelKPI2.Controls.Add(this.lblWaitingCasesValue);
            this.panelKPI2.Controls.Add(this.lblWaitingCasesTitle);
            this.panelKPI2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKPI2.Location = new System.Drawing.Point(1273, 72);
            this.panelKPI2.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.panelKPI2.Name = "panelKPI2";
            this.panelKPI2.Size = new System.Drawing.Size(542, 214);
            this.panelKPI2.TabIndex = 1;
            // 
            // lblWaitingCasesValue
            // 
            this.lblWaitingCasesValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWaitingCasesValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblWaitingCasesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.lblWaitingCasesValue.Location = new System.Drawing.Point(0, 72);
            this.lblWaitingCasesValue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblWaitingCasesValue.Name = "lblWaitingCasesValue";
            this.lblWaitingCasesValue.Size = new System.Drawing.Size(542, 142);
            this.lblWaitingCasesValue.TabIndex = 1;
            this.lblWaitingCasesValue.Text = "0";
            this.lblWaitingCasesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWaitingCasesTitle
            // 
            this.lblWaitingCasesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWaitingCasesTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWaitingCasesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblWaitingCasesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblWaitingCasesTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblWaitingCasesTitle.Name = "lblWaitingCasesTitle";
            this.lblWaitingCasesTitle.Size = new System.Drawing.Size(542, 72);
            this.lblWaitingCasesTitle.TabIndex = 0;
            this.lblWaitingCasesTitle.Text = "حالات الإنتظار";
            this.lblWaitingCasesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKPI3
            // 
            this.panelKPI3.BackColor = System.Drawing.Color.White;
            this.panelKPI3.Controls.Add(this.lblCompletedCasesValue);
            this.panelKPI3.Controls.Add(this.lblCompletedCasesTitle);
            this.panelKPI3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKPI3.Location = new System.Drawing.Point(677, 72);
            this.panelKPI3.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.panelKPI3.Name = "panelKPI3";
            this.panelKPI3.Size = new System.Drawing.Size(542, 214);
            this.panelKPI3.TabIndex = 2;
            // 
            // lblCompletedCasesValue
            // 
            this.lblCompletedCasesValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompletedCasesValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCompletedCasesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.lblCompletedCasesValue.Location = new System.Drawing.Point(0, 72);
            this.lblCompletedCasesValue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCompletedCasesValue.Name = "lblCompletedCasesValue";
            this.lblCompletedCasesValue.Size = new System.Drawing.Size(542, 142);
            this.lblCompletedCasesValue.TabIndex = 1;
            this.lblCompletedCasesValue.Text = "0";
            this.lblCompletedCasesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompletedCasesTitle
            // 
            this.lblCompletedCasesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompletedCasesTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCompletedCasesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCompletedCasesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblCompletedCasesTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCompletedCasesTitle.Name = "lblCompletedCasesTitle";
            this.lblCompletedCasesTitle.Size = new System.Drawing.Size(542, 72);
            this.lblCompletedCasesTitle.TabIndex = 0;
            this.lblCompletedCasesTitle.Text = "حالات اكتملت";
            this.lblCompletedCasesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKPI4
            // 
            this.panelKPI4.BackColor = System.Drawing.Color.White;
            this.panelKPI4.Controls.Add(this.lblTodayRevenueValue);
            this.panelKPI4.Controls.Add(this.lblTodayRevenueTitle);
            this.panelKPI4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKPI4.Location = new System.Drawing.Point(80, 72);
            this.panelKPI4.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.panelKPI4.Name = "panelKPI4";
            this.panelKPI4.Size = new System.Drawing.Size(543, 214);
            this.panelKPI4.TabIndex = 3;
            // 
            // lblTodayRevenueValue
            // 
            this.lblTodayRevenueValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTodayRevenueValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTodayRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.lblTodayRevenueValue.Location = new System.Drawing.Point(0, 72);
            this.lblTodayRevenueValue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTodayRevenueValue.Name = "lblTodayRevenueValue";
            this.lblTodayRevenueValue.Size = new System.Drawing.Size(543, 142);
            this.lblTodayRevenueValue.TabIndex = 1;
            this.lblTodayRevenueValue.Text = "0 د.ل";
            this.lblTodayRevenueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodayRevenueTitle
            // 
            this.lblTodayRevenueTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTodayRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTodayRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTodayRevenueTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTodayRevenueTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTodayRevenueTitle.Name = "lblTodayRevenueTitle";
            this.lblTodayRevenueTitle.Size = new System.Drawing.Size(543, 72);
            this.lblTodayRevenueTitle.TabIndex = 0;
            this.lblTodayRevenueTitle.Text = "إيرادات اليوم";
            this.lblTodayRevenueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelActionBar
            // 
            this.panelActionBar.Controls.Add(this.panelLeftSpacer2);
            this.panelActionBar.Controls.Add(this.cmbDoctor);
            this.panelActionBar.Controls.Add(this.panelLeftSpacer);
            this.panelActionBar.Controls.Add(this.btnMyPatients);
            this.panelActionBar.Controls.Add(this.panelBtnSpacer2);
            this.panelActionBar.Controls.Add(this.btnPendingInvoices);
            this.panelActionBar.Controls.Add(this.panelBtnSpacer1);
            this.panelActionBar.Controls.Add(this.btnAssignPatient);
            this.panelActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionBar.Location = new System.Drawing.Point(0, 358);
            this.panelActionBar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelActionBar.Name = "panelActionBar";
            this.panelActionBar.Padding = new System.Windows.Forms.Padding(53, 48, 53, 24);
            this.panelActionBar.Size = new System.Drawing.Size(2491, 167);
            this.panelActionBar.TabIndex = 1;
            // 
            // panelLeftSpacer2
            // 
            this.panelLeftSpacer2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSpacer2.Location = new System.Drawing.Point(633, 48);
            this.panelLeftSpacer2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelLeftSpacer2.Name = "panelLeftSpacer2";
            this.panelLeftSpacer2.Size = new System.Drawing.Size(53, 95);
            this.panelLeftSpacer2.TabIndex = 5;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.cmbDoctor.Location = new System.Drawing.Point(106, 48);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(527, 53);
            this.cmbDoctor.TabIndex = 3;
            // 
            // panelLeftSpacer
            // 
            this.panelLeftSpacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSpacer.Location = new System.Drawing.Point(53, 48);
            this.panelLeftSpacer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelLeftSpacer.Name = "panelLeftSpacer";
            this.panelLeftSpacer.Size = new System.Drawing.Size(53, 95);
            this.panelLeftSpacer.TabIndex = 6;
            // 
            // btnMyPatients
            // 
            this.btnMyPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.btnMyPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyPatients.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMyPatients.FlatAppearance.BorderSize = 0;
            this.btnMyPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyPatients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMyPatients.ForeColor = System.Drawing.Color.White;
            this.btnMyPatients.Location = new System.Drawing.Point(1317, 48);
            this.btnMyPatients.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnMyPatients.Name = "btnMyPatients";
            this.btnMyPatients.Size = new System.Drawing.Size(320, 95);
            this.btnMyPatients.TabIndex = 2;
            this.btnMyPatients.Text = "حالات الإنتظار";
            this.btnMyPatients.UseVisualStyleBackColor = false;
            // 
            // panelBtnSpacer2
            // 
            this.panelBtnSpacer2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBtnSpacer2.Location = new System.Drawing.Point(1637, 48);
            this.panelBtnSpacer2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelBtnSpacer2.Name = "panelBtnSpacer2";
            this.panelBtnSpacer2.Size = new System.Drawing.Size(27, 95);
            this.panelBtnSpacer2.TabIndex = 7;
            // 
            // btnPendingInvoices
            // 
            this.btnPendingInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnPendingInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPendingInvoices.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPendingInvoices.FlatAppearance.BorderSize = 0;
            this.btnPendingInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendingInvoices.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPendingInvoices.ForeColor = System.Drawing.Color.Black;
            this.btnPendingInvoices.Location = new System.Drawing.Point(1664, 48);
            this.btnPendingInvoices.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPendingInvoices.Name = "btnPendingInvoices";
            this.btnPendingInvoices.Size = new System.Drawing.Size(500, 95);
            this.btnPendingInvoices.TabIndex = 1;
            this.btnPendingInvoices.Text = "الحالات المحولة من الدكتور";
            this.btnPendingInvoices.UseVisualStyleBackColor = false;
            this.btnPendingInvoices.Click += new System.EventHandler(this.btnPendingInvoices_Click);
            // 
            // panelBtnSpacer1
            // 
            this.panelBtnSpacer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBtnSpacer1.Location = new System.Drawing.Point(2011, 48);
            this.panelBtnSpacer1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelBtnSpacer1.Name = "panelBtnSpacer1";
            this.panelBtnSpacer1.Size = new System.Drawing.Size(27, 95);
            this.panelBtnSpacer1.TabIndex = 8;
            // 
            // btnAssignPatient
            // 
            this.btnAssignPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.btnAssignPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignPatient.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAssignPatient.FlatAppearance.BorderSize = 0;
            this.btnAssignPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignPatient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAssignPatient.ForeColor = System.Drawing.Color.White;
            this.btnAssignPatient.Location = new System.Drawing.Point(2038, 48);
            this.btnAssignPatient.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAssignPatient.Name = "btnAssignPatient";
            this.btnAssignPatient.Size = new System.Drawing.Size(400, 95);
            this.btnAssignPatient.TabIndex = 0;
            this.btnAssignPatient.Text = "إنشاء حالة";
            this.btnAssignPatient.UseVisualStyleBackColor = false;
            // 
            // panelGridArea
            // 
            this.panelGridArea.Controls.Add(this.dgvTodayAppointments);
            this.panelGridArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridArea.Location = new System.Drawing.Point(0, 525);
            this.panelGridArea.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelGridArea.Name = "panelGridArea";
            this.panelGridArea.Padding = new System.Windows.Forms.Padding(53, 48, 53, 48);
            this.panelGridArea.Size = new System.Drawing.Size(2491, 906);
            this.panelGridArea.TabIndex = 2;
            // 
            // dgvTodayAppointments
            // 
            this.dgvTodayAppointments.AllowUserToAddRows = false;
            this.dgvTodayAppointments.AllowUserToDeleteRows = false;
            this.dgvTodayAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodayAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvTodayAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTodayAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTodayAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTodayAppointments.ColumnHeadersHeight = 40;
            this.dgvTodayAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFileNum,
            this.colPatientName,
            this.colPhone,
            this.colDoctor,
            this.colTime,
            this.colPeriod,
            this.colNotes,
            this.colStatus});
            this.dgvTodayAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodayAppointments.EnableHeadersVisualStyles = false;
            this.dgvTodayAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvTodayAppointments.Location = new System.Drawing.Point(53, 48);
            this.dgvTodayAppointments.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvTodayAppointments.Name = "dgvTodayAppointments";
            this.dgvTodayAppointments.ReadOnly = true;
            this.dgvTodayAppointments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTodayAppointments.RowHeadersVisible = false;
            this.dgvTodayAppointments.RowHeadersWidth = 102;
            this.dgvTodayAppointments.RowTemplate.Height = 45;
            this.dgvTodayAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodayAppointments.Size = new System.Drawing.Size(2385, 810);
            this.dgvTodayAppointments.TabIndex = 0;
            // 
            // colFileNum
            // 
            this.colFileNum.HeaderText = "رقم الملف";
            this.colFileNum.MinimumWidth = 12;
            this.colFileNum.Name = "colFileNum";
            this.colFileNum.ReadOnly = true;
            // 
            // colPatientName
            // 
            this.colPatientName.HeaderText = "اسم الحالة";
            this.colPatientName.MinimumWidth = 12;
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "رقم الهاتف";
            this.colPhone.MinimumWidth = 12;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colDoctor
            // 
            this.colDoctor.HeaderText = "اسم الطبيب";
            this.colDoctor.MinimumWidth = 12;
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.ReadOnly = true;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "الوقت";
            this.colTime.MinimumWidth = 12;
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colPeriod
            // 
            this.colPeriod.HeaderText = "الفترة";
            this.colPeriod.MinimumWidth = 12;
            this.colPeriod.Name = "colPeriod";
            this.colPeriod.ReadOnly = true;
            // 
            // colNotes
            // 
            this.colNotes.HeaderText = "ملاحظات";
            this.colNotes.MinimumWidth = 12;
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "الحالة";
            this.colStatus.MinimumWidth = 12;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // DashboardControlUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.panelGridArea);
            this.Controls.Add(this.panelActionBar);
            this.Controls.Add(this.tlpKPIs);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "DashboardControlUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(2491, 1431);
            this.tlpKPIs.ResumeLayout(false);
            this.panelKPI1.ResumeLayout(false);
            this.panelKPI2.ResumeLayout(false);
            this.panelKPI3.ResumeLayout(false);
            this.panelKPI4.ResumeLayout(false);
            this.panelActionBar.ResumeLayout(false);
            this.panelGridArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpKPIs;
        private System.Windows.Forms.Panel panelKPI1;
        private System.Windows.Forms.Label lblTotalAppointmentsValue;
        private System.Windows.Forms.Label lblTotalAppointmentsTitle;
        private System.Windows.Forms.Panel panelKPI2;
        private System.Windows.Forms.Label lblWaitingCasesValue;
        private System.Windows.Forms.Label lblWaitingCasesTitle;
        private System.Windows.Forms.Panel panelKPI3;
        private System.Windows.Forms.Label lblCompletedCasesValue;
        private System.Windows.Forms.Label lblCompletedCasesTitle;
        private System.Windows.Forms.Panel panelKPI4;
        private System.Windows.Forms.Label lblTodayRevenueValue;
        private System.Windows.Forms.Label lblTodayRevenueTitle;
        private System.Windows.Forms.Panel panelActionBar;
        private System.Windows.Forms.Button btnAssignPatient;
        private System.Windows.Forms.Panel panelBtnSpacer1;
        private System.Windows.Forms.Button btnPendingInvoices;
        private System.Windows.Forms.Panel panelBtnSpacer2;
        private System.Windows.Forms.Button btnMyPatients;
        private System.Windows.Forms.Panel panelLeftSpacer;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Panel panelLeftSpacer2;
        private System.Windows.Forms.Panel panelGridArea;
        private System.Windows.Forms.DataGridView dgvTodayAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}


