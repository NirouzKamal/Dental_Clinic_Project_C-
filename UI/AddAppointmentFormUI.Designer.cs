namespace DentalClinicProject.UI
{
    partial class AddAppointmentFormUI
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
            this.tlpInputs = new System.Windows.Forms.TableLayoutPanel();
            this.lblPatient = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
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
            this.lblTitle.Size = new System.Drawing.Size(307, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إضافة موعد جديد";
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
            this.panelBottomBar.Location = new System.Drawing.Point(0, 1049);
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
            this.panelInputArea.Controls.Add(this.tlpInputs);
            this.panelInputArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputArea.Location = new System.Drawing.Point(0, 119);
            this.panelInputArea.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelInputArea.Name = "panelInputArea";
            this.panelInputArea.Padding = new System.Windows.Forms.Padding(80, 72, 80, 72);
            this.panelInputArea.Size = new System.Drawing.Size(1600, 930);
            this.panelInputArea.TabIndex = 0;
            // 
            // tlpInputs
            // 
            this.tlpInputs.ColumnCount = 2;
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 347F));
            this.tlpInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInputs.Controls.Add(this.lblPatient, 0, 0);
            this.tlpInputs.Controls.Add(this.cmbPatient, 1, 0);
            this.tlpInputs.Controls.Add(this.lblDoctor, 0, 1);
            this.tlpInputs.Controls.Add(this.cmbDoctor, 1, 1);
            this.tlpInputs.Controls.Add(this.lblDate, 0, 2);
            this.tlpInputs.Controls.Add(this.dtpDate, 1, 2);
            this.tlpInputs.Controls.Add(this.lblTime, 0, 3);
            this.tlpInputs.Controls.Add(this.cmbTime, 1, 3);
            this.tlpInputs.Controls.Add(this.lblNotes, 0, 4);
            this.tlpInputs.Controls.Add(this.txtNotes, 1, 4);
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
            this.tlpInputs.Size = new System.Drawing.Size(1440, 786);
            this.tlpInputs.TabIndex = 0;
            // 
            // lblPatient
            // 
            this.lblPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPatient.Location = new System.Drawing.Point(1101, 55);
            this.lblPatient.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(331, 46);
            this.lblPatient.TabIndex = 0;
            this.lblPatient.Text = "المريض";
            this.lblPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPatient
            // 
            this.cmbPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPatient.Location = new System.Drawing.Point(27, 24);
            this.cmbPatient.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(1039, 53);
            this.cmbPatient.TabIndex = 1;
            // 
            // lblDoctor
            // 
            this.lblDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDoctor.Location = new System.Drawing.Point(1101, 212);
            this.lblDoctor.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(331, 46);
            this.lblDoctor.TabIndex = 2;
            this.lblDoctor.Text = "الطبيب";
            this.lblDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDoctor.Location = new System.Drawing.Point(27, 181);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(1039, 53);
            this.cmbDoctor.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.Location = new System.Drawing.Point(1101, 369);
            this.lblDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(331, 46);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "التاريخ";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDate
            // 
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(27, 338);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(1039, 52);
            this.dtpDate.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTime.Location = new System.Drawing.Point(1101, 526);
            this.lblTime.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(331, 46);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "الوقت";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTime
            // 
            this.cmbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTime.Location = new System.Drawing.Point(27, 495);
            this.cmbTime.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(1039, 53);
            this.cmbTime.TabIndex = 7;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNotes.Location = new System.Drawing.Point(1101, 684);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(331, 46);
            this.lblNotes.TabIndex = 8;
            this.lblNotes.Text = "ملاحظات";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotes.Location = new System.Drawing.Point(27, 652);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(1039, 52);
            this.txtNotes.TabIndex = 9;
            // 
            // AddAppointmentFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 1192);
            this.Controls.Add(this.panelInputArea);
            this.Controls.Add(this.panelBottomBar);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
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

        private System.Windows.Forms.Panel panelHeader; private System.Windows.Forms.Label lblTitle; private System.Windows.Forms.Panel panelHeaderBorder;
        private System.Windows.Forms.Panel panelBottomBar; private System.Windows.Forms.Button btnSave; private System.Windows.Forms.Panel panelBottomBorder;
        private System.Windows.Forms.Panel panelInputArea; private System.Windows.Forms.TableLayoutPanel tlpInputs;
        private System.Windows.Forms.Label lblPatient; private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Label lblDoctor; private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label lblDate; private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime; private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Label lblNotes; private System.Windows.Forms.TextBox txtNotes;
    }
}


