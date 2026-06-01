namespace DentalClinicProject
{
    partial class todayAppointmentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(todayAppointmentsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.doctorNameCmb = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.searchCmb = new System.Windows.Forms.ComboBox();
            this.todayAppointmentsDgv = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TreatmentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayAppointmentsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.doctorNameCmb);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.searchCmb);
            this.panel4.Controls.Add(this.todayAppointmentsDgv);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(5, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3216, 1419);
            this.panel4.TabIndex = 25;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // doctorNameCmb
            // 
            this.doctorNameCmb.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNameCmb.FormattingEnabled = true;
            this.doctorNameCmb.ItemHeight = 53;
            this.doctorNameCmb.Location = new System.Drawing.Point(1456, 33);
            this.doctorNameCmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doctorNameCmb.Name = "doctorNameCmb";
            this.doctorNameCmb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.doctorNameCmb.Size = new System.Drawing.Size(612, 61);
            this.doctorNameCmb.TabIndex = 27;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3077, 36);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // searchCmb
            // 
            this.searchCmb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchCmb.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCmb.FormattingEnabled = true;
            this.searchCmb.ItemHeight = 53;
            this.searchCmb.Location = new System.Drawing.Point(2229, 31);
            this.searchCmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchCmb.Name = "searchCmb";
            this.searchCmb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchCmb.Size = new System.Drawing.Size(839, 61);
            this.searchCmb.TabIndex = 23;
            // 
            // todayAppointmentsDgv
            // 
            this.todayAppointmentsDgv.AllowUserToAddRows = false;
            this.todayAppointmentsDgv.AllowUserToResizeColumns = false;
            this.todayAppointmentsDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayAppointmentsDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.todayAppointmentsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.todayAppointmentsDgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.todayAppointmentsDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.todayAppointmentsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.todayAppointmentsDgv.ColumnHeadersHeight = 60;
            this.todayAppointmentsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.todayAppointmentsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileID,
            this.patientNameColumn,
            this.doctorNameColumn,
            this.timeColumn,
            this.TreatmentCol,
            this.phoneNumberColumn,
            this.notesColumn,
            this.stateColumn,
            this.PatientID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.todayAppointmentsDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.todayAppointmentsDgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.todayAppointmentsDgv.GridColor = System.Drawing.SystemColors.ControlLight;
            this.todayAppointmentsDgv.Location = new System.Drawing.Point(27, 126);
            this.todayAppointmentsDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todayAppointmentsDgv.MultiSelect = false;
            this.todayAppointmentsDgv.Name = "todayAppointmentsDgv";
            this.todayAppointmentsDgv.ReadOnly = true;
            this.todayAppointmentsDgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.todayAppointmentsDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.todayAppointmentsDgv.RowHeadersVisible = false;
            this.todayAppointmentsDgv.RowHeadersWidth = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.todayAppointmentsDgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.todayAppointmentsDgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.todayAppointmentsDgv.RowTemplate.Height = 80;
            this.todayAppointmentsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.todayAppointmentsDgv.Size = new System.Drawing.Size(3101, 1252);
            this.todayAppointmentsDgv.TabIndex = 21;
            this.todayAppointmentsDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todayAppointmentsDgv_CellContentClick);
            this.todayAppointmentsDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todayAppointmentsDgv_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 41);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(138, 57);
            this.label7.TabIndex = 20;
            this.label7.Text = "التاريخ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2080, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 53);
            this.label12.TabIndex = 26;
            this.label12.Text = "الطبيب";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 57);
            this.label6.TabIndex = 20;
            this.label6.Text = "مواعيد اليوم";
            // 
            // FileID
            // 
            this.FileID.FillWeight = 48.73097F;
            this.FileID.HeaderText = "رقم الملف";
            this.FileID.MinimumWidth = 12;
            this.FileID.Name = "FileID";
            this.FileID.ReadOnly = true;
            // 
            // patientNameColumn
            // 
            this.patientNameColumn.FillWeight = 107.3242F;
            this.patientNameColumn.HeaderText = "اسم الحالة";
            this.patientNameColumn.MinimumWidth = 12;
            this.patientNameColumn.Name = "patientNameColumn";
            this.patientNameColumn.ReadOnly = true;
            // 
            // doctorNameColumn
            // 
            this.doctorNameColumn.FillWeight = 107.3242F;
            this.doctorNameColumn.HeaderText = "اسم الطبيب";
            this.doctorNameColumn.MinimumWidth = 12;
            this.doctorNameColumn.Name = "doctorNameColumn";
            this.doctorNameColumn.ReadOnly = true;
            // 
            // timeColumn
            // 
            this.timeColumn.FillWeight = 107.3242F;
            this.timeColumn.HeaderText = "الوقت";
            this.timeColumn.MinimumWidth = 12;
            this.timeColumn.Name = "timeColumn";
            this.timeColumn.ReadOnly = true;
            // 
            // TreatmentCol
            // 
            this.TreatmentCol.FillWeight = 107.3242F;
            this.TreatmentCol.HeaderText = "التشخيص";
            this.TreatmentCol.MinimumWidth = 12;
            this.TreatmentCol.Name = "TreatmentCol";
            this.TreatmentCol.ReadOnly = true;
            // 
            // phoneNumberColumn
            // 
            this.phoneNumberColumn.FillWeight = 107.3242F;
            this.phoneNumberColumn.HeaderText = "المدفوع";
            this.phoneNumberColumn.MinimumWidth = 12;
            this.phoneNumberColumn.Name = "phoneNumberColumn";
            this.phoneNumberColumn.ReadOnly = true;
            // 
            // notesColumn
            // 
            this.notesColumn.FillWeight = 107.3242F;
            this.notesColumn.HeaderText = "ملاحظات";
            this.notesColumn.MinimumWidth = 12;
            this.notesColumn.Name = "notesColumn";
            this.notesColumn.ReadOnly = true;
            // 
            // stateColumn
            // 
            this.stateColumn.FillWeight = 107.3242F;
            this.stateColumn.HeaderText = "الحالة";
            this.stateColumn.MinimumWidth = 12;
            this.stateColumn.Name = "stateColumn";
            this.stateColumn.ReadOnly = true;
            // 
            // PatientID
            // 
            this.PatientID.HeaderText = "ر.ح";
            this.PatientID.MinimumWidth = 12;
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            // 
            // todayAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3173, 1428);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "todayAppointmentsForm";
            this.Text = "todayAppointmentsForm";
            this.Load += new System.EventHandler(this.todayAppointmentsForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayAppointmentsDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox doctorNameCmb;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox searchCmb;
        private System.Windows.Forms.DataGridView todayAppointmentsDgv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TreatmentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
    }
}